using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatura
{
    public partial class musteri : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenID;

        public musteri()
        {
            InitializeComponent();
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            ilDoldur();
            
            listele();
        }

        private void listele()
        {
            var müşteriler = from m in db.musteriler
                             select new
                             {
                                 m.MusteriId,
                                 m.MusteriUnvani,
                                 m.MusteriAdresi,
                                 m.ilce.IlceAdi,
                                 sehirAdi=m.ilce.il.IlAdi
                             };
            dataGridView1.DataSource = müşteriler.ToList();
            textadress.Clear();
            txtMusteriUnvani.Clear();
            txtMusteriUnvani.Focus();

        }

        private void ilDoldur()
        {
            var iller = from il in db.iller select new { il.IlId, il.IlAdi };
            comboBoxşehir.ValueMember = "IlId";
            comboBoxşehir.DisplayMember = "IlAdi";
            comboBoxşehir.DataSource = iller.ToList();
            
        }

        private void comboBoxşehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcedoldur();
        }

        private void ilcedoldur()
        {
            
            var list = from i in db.ilceler
                       where    i.IlId == (int)comboBoxşehir.SelectedValue
                       orderby i.IlceAdi
                       select new
                       {
                           i.IlceId,
                           i.IlceAdi,
                           i.IlId
                       };

            comboBoxilce.DisplayMember = "IlceAdi";
            comboBoxilce.ValueMember = "IlceId";
            comboBoxilce.DataSource = list.ToList();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.MusteriUnvani = txtMusteriUnvani.Text;
            m.MusteriAdresi = textadress.Text;
            m.IlceId = (int)comboBoxilce.SelectedValue;
            db.musteriler.Add(m);
            db.SaveChanges();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri m = db.musteriler.Find(secilenID);
            m.MusteriUnvani = txtMusteriUnvani.Text;
            m.MusteriAdresi = textadress.Text;
            m.IlceId = (int)comboBoxilce.SelectedValue;
            db.SaveChanges();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var musteri = db.musteriler.Find(secilenID);

            txtMusteriUnvani.Text = musteri.MusteriUnvani;
            textadress.Text = musteri.MusteriAdresi;
           comboBoxilce.SelectedValue= musteri.IlceId;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri m = db.musteriler.Find(secilenID);
            db.musteriler.Remove(m);
            db.SaveChanges();
            listele();

        }
    }
}
