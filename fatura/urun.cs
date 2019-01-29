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
    public partial class urun : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenId;
        public urun()
        {
            InitializeComponent();
        }

        private void urun_Load(object sender, EventArgs e)
        {
            birimlistele();
            listele();


        }
        

        private void listele()
        {
            var liste = from u in db.urunler orderby u.UrunAdi select new { u.UrunId, u.UrunAdi, u.UrunKodu, u.birim.BirimAdi, u.BirimFiyat };
            dataGridView1.DataSource = liste.ToList();
        }

        private void birimlistele()
        {
            var blist = from b in db.birimler orderby b.BirimAdi select new { b.BirimId, b.BirimAdi };
            comboBox1.DisplayMember = "BirimAdi";
            comboBox1.ValueMember = "BirimId";
            comboBox1.DataSource = blist.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Urun u = new Urun();
                u.UrunAdi = txtUrunAdı.Text;
                u.UrunKodu = txtkod.Text;
                u.BirimFiyat=Convert.ToDecimal(txtBirimFiyat.Text);
                u.BirimId =(int) comboBox1.SelectedValue;
                db.urunler.Add(u);
                db.SaveChanges();
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("urun giriniz");
               
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Urun u = db.urunler.Find(secilenId);
                txtUrunAdı.Text = u.UrunAdi;
                txtkod.Text = u.UrunKodu;
                txtBirimFiyat.Text = u.BirimFiyat.ToString();
                comboBox1.SelectedValue = u.birim.BirimId;

            }
            catch (Exception)
            {


                return;
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun u = db.urunler.Find(secilenId);
            u.BirimId = (int)comboBox1.SelectedValue;
            u.UrunAdi = txtUrunAdı.Text;
            u.UrunKodu = txtkod.Text;
            u.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
            db.SaveChanges();
            listele();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Urun u = db.urunler.Find(secilenId);
            db.urunler.Remove(u);
            db.SaveChanges();
            listele();


        }
    }
}
