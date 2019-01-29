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

    }
}
