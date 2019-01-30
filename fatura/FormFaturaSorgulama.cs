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
    public partial class FormFaturaSorgulama : Form
    {
        FaturaContext db = new FaturaContext();
        int secileId;
        public FormFaturaSorgulama()
        {
            InitializeComponent();
        }

        private void FormFaturaSorgulama_Load(object sender, EventArgs e)
        {

          
            SehirEkle();
            //UrunEkle();
            

            listele();

        }

        private void listele()
        {
            dataGridView1.DataSource = (from f in db.faturamaster
                                        where f.FaturaId.ToString().Contains(textBoxfatura.Text)
                                        orderby f.FaturaTarihi descending
                                        select new
                                        {
                                            f.FaturaId,
                                            f.MusteriId,
                                            f.musteri.MusteriUnvani
 ,
                                            f.FaturaTarihi,
                                            f.OdemeTarihi,
                                            f.IrsaliyeNo,
                                            sehir = f.musteri.ilce.il.IlAdi,
                                            ilce = f.musteri.ilce.IlceAdi
                                        }).ToList();
        }

        private void SehirEkle()
        {
            var list = db.iller.ToList();
            comboBoxSehir.DisplayMember = "IlAdi";
            comboBoxSehir.ValueMember = "IlId";
            comboBoxSehir.DataSource = list;

        }

        private void comboBoxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceDoldur();


        }

        private void IlceDoldur()
        {
            var list = db.ilceler.Where(x => x.IlId == (int)comboBoxSehir.SelectedValue).ToList();
            comboBoxİlce.DisplayMember = "IlceAdi";
            comboBoxİlce.ValueMember = "IlceId";
            comboBoxİlce.DataSource = list;



        }

        private void comboBoxİlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = db.musteriler.Where(x => x.IlceId == (int)comboBoxİlce.SelectedValue).ToList();
            comboBoxMusteri.DisplayMember = "MusteriUnvani";
            comboBoxMusteri.ValueMember = "MusteriId";
            comboBoxMusteri.DataSource = list;

        }

        private void comboBoxMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from i in db.faturamaster
                                       where i.MusteriId == (int)comboBoxMusteri.SelectedValue
                                       orderby i.FaturaTarihi
                                       select new
                                       {
                                           i.FaturaId,
                                           i.MusteriId,
                                           i.musteri.MusteriUnvani,
                                           sehir=i.musteri.ilce.il.IlAdi,
                                           ilce=i.musteri.ilce.IlceAdi,
                                           i.FaturaTarihi,
                                           i.IrsaliyeNo,
                                           i.OdemeTarihi


                                       }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from i in db.faturamaster
                                       
                                        orderby i.FaturaTarihi
                                        select new
                                        {
                                            i.FaturaId,
                                            i.MusteriId,
                                            i.musteri.MusteriUnvani,
                                            sehir = i.musteri.ilce.il.IlAdi,
                                            ilce = i.musteri.ilce.IlceAdi,
                                            i.FaturaTarihi,
                                            i.IrsaliyeNo,
                                            i.OdemeTarihi


                                        }).ToList();
        }

        private void textBoxfatura_TextChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secileId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            dataGridView2.DataSource = (from fd in db.faturadetay where fd.FaturaId == secileId orderby fd.UrunId select fd).ToList();
        }
    }
}
