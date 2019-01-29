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
            IlDoldur();
        }

        private void IlDoldur()
        {
            var list = from i in db.iller select new { i.IlId, i.IlAdi };
            comboBoxSehir.DisplayMember = "IlAdi";
            comboBoxSehir.ValueMember = "IlId";
            comboBoxSehir.DataSource = list;
        }

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
                       select new { i.IlceId, i.IlceAdi,i.IlId };
            comboBoxİlce.DisplayMember = "IlceAdi";
            comboBoxİlce.ValueMember = "IlceId";
            comboBoxİlce.DataSource = ilce.ToList();

        }
    }
}
