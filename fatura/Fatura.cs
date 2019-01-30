using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatura
{
    public partial class Fatura : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenId;
        List<secilenUrun> urunlistesi = new List<secilenUrun>();

        public Fatura()
        {
            InitializeComponent();
        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            MusteriSehirDoldur();
            UrunDoldur();
            //  IlDoldur();
            listele();
        }

        //private void IlDoldur()
        //{
        //    var list = from i in db.iller select new { i.IlId, i.IlAdi };
        //    comboBoxSehir.DisplayMember = "IlAdi";
        //    comboBoxSehir.ValueMember = "IlId";
        //    comboBoxSehir.DataSource = list;
        //}

        private void UrunDoldur()
        {
            var list = from u in db.urunler
                       orderby u.UrunAdi
                       select new
                       { u.UrunId, u.UrunAdi };

            comboBoxÜrünAdı.DisplayMember = "UrunAdi";
            comboBoxÜrünAdı.ValueMember = "UrunId";
            comboBoxÜrünAdı.DataSource = list.ToList();

        }

        private void MusteriSehirDoldur()
        {
            var list = db.iller.ToList();
            comboBoxSehir.ValueMember = "IlId";
            comboBoxSehir.DisplayMember = "IlAdi";
            comboBoxSehir.DataSource = list;
        }

        private void comboBoxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceDoldur();
        }

        private void IlceDoldur()
        {
            var ilce = from i in db.ilceler
                       where i.IlId == (int)comboBoxSehir.SelectedValue
                       orderby i.IlceAdi
                       select new { i.IlceId, i.IlceAdi};
            comboBoxİlce.DisplayMember = "IlceAdi";
            comboBoxİlce.ValueMember = "IlceId";
            comboBoxİlce.DataSource = ilce.ToList();

        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            urunlistesi.Add(new secilenUrun
            {
                UrunId = (int)comboBoxÜrünAdı.SelectedValue,
                UrunAdi = comboBoxÜrünAdı.Text,
                Kdv = Convert.ToDecimal(textkdv.Text),
                urunFiyat = Convert.ToDecimal(textÜrünFiyatı.Text),
                Miktar = Convert.ToDecimal(numericMiktar.Value),
                toplamTutar = Convert.ToDecimal(textÜrünFiyatı.Text) * Convert.ToDecimal(numericMiktar.Value)
            }
            );
            listele();
        }

        private void buttonUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = urunlistesi.Where(x => x.UrunId == secilenId).FirstOrDefault();
                if (secilenId == (int)comboBoxÜrünAdı.SelectedValue)
                {

                    urun.Miktar = (decimal)numericMiktar.Value;
                    urun.toplamTutar = Convert.ToDecimal(textÜrünFiyatı.Text) * Convert.ToDecimal(numericMiktar.Value);

                }
                else
                {
                    urun.UrunId = (int)comboBoxÜrünAdı.SelectedValue;
                    urun.UrunAdi = comboBoxÜrünAdı.Text;
                    urun.urunFiyat = Convert.ToDecimal(textÜrünFiyatı.Text);
                    urun.Miktar = Convert.ToDecimal(numericMiktar.Value);
                    urun.toplamTutar = Convert.ToDecimal(textÜrünFiyatı.Text) * Convert.ToDecimal(numericMiktar.Value);
                }
                listele();
            }
            catch (Exception )
            {
                MessageBox.Show("Lütfen Listden Ürün Seçiniz");
                
            }
            
        }

        private void listele()
        {
            dataGridView1.DataSource = urunlistesi.Select(x => new
            {
                x.UrunId,
                x.UrunAdi,
                x.urunFiyat,
                x.Miktar,
                x.Kdv,
                x.toplamTutar,
                genelToplam = x.toplamTutar + (x.toplamTutar * x.Kdv)/100
            }
            ).ToList();

            dataGridView1.Columns[0].Visible = false;
            temizle();
            faturatoplam();
        }

        private void faturatoplam()
        {
            decimal toplam = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam = Convert.ToDecimal(dataGridView1[6,i].Value);
            }
            labelfaturaToplam.Text=toplam.ToString("{0:0:00}") + "TL";

        }

        private void temizle()
        {
            numericMiktar.Value = 0;

        }

        //silme
        private void buttonUrunsil_Click(object sender, EventArgs e)
        {
            var urun = urunlistesi.Where(x => x.UrunId == secilenId).FirstOrDefault();
            urunlistesi.Remove(urun);
            listele();
        }

        //transaction yapılıyor veri bütünlüğünü korumak için.
        private void button4_Click(object sender, EventArgs e)
        {
            DbContextTransaction trans = db.Database.BeginTransaction();
            try
            {
            FaturaMasterKaydet();
            FaturaDetayKaydet();
            trans.Commit();
            }
            catch (Exception)
            {
                trans.Rollback();
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }

        }

        private void FaturaDetayKaydet()
        {
            foreach (secilenUrun item in urunlistesi)
            {
                FaturaDetay f = new FaturaDetay();
                f.FaturaId = Convert.ToInt32(labelfaturano.Text);
                f.UrunId = item.UrunId;
                f.Miktar = item.Miktar;
                f.Kdv = item.Kdv;
               
                f.ToplamFiyat = item.Miktar * item.urunFiyat;
                f.KdvliFiyat = f.ToplamFiyat+(f.ToplamFiyat * item.Kdv)/100;
                db.faturadetay.Add(f);
                db.SaveChanges();

                MessageBox.Show("hele şükür bitti.");
            }


        }

        private void FaturaMasterKaydet()
        {
            FaturaMaster f = new FaturaMaster();
            f.IrsaliyeNo = Convert.ToInt32(textİrsaliye.Text);
            f.OdemeTarihi = dateTimePicker1.Value;
            f.MusteriId =(int) comboBoxMusteri.SelectedValue;
            db.faturamaster.Add(f);
            db.SaveChanges();
            labelfaturano.Text = f.FaturaId.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            urunlistesi.Clear();

        }

        private void comboBoxÜrünAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            var u=db.urunler.Find((int)comboBoxÜrünAdı.SelectedValue);
                
            decimal fiyat = db.urunler.Find((int)comboBoxÜrünAdı.SelectedValue).BirimFiyat;
            textÜrünFiyatı.Text = u.BirimFiyat.ToString();
            textÜrünBirimi.Text = u.birim.BirimAdi;
            textkdv.Text = "8";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var urun = urunlistesi.Where(x => x.UrunId == secilenId).FirstOrDefault();
            comboBoxÜrünAdı.SelectedValue = secilenId;
            numericMiktar.Value = urun.Miktar;
        }

        private void comboBoxİlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriDoldur();
        }

        private void MusteriDoldur()
        {
            var list = (from m in db.musteriler where m.IlceId == (int)comboBoxİlce.SelectedValue orderby m.MusteriUnvani select new { m.IlceId, m.MusteriId,m.MusteriUnvani}).ToList();
            if (list.Count != 0)
            {
                comboBoxMusteri.DisplayMember = "MusteriUnvani";
                comboBoxMusteri.ValueMember = "MusteriId";
                comboBoxMusteri.DataSource = list;
            }
            else { comboBoxMusteri.DataSource = null; }
        }
    }
   }

