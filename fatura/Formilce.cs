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
    public partial class Formilce : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenId;

        public Formilce()
        {
            InitializeComponent();
        }

        public void ComboBoxListele()
        {
            var list = db.iller.Select(x => new { x.IlId, x.IlAdi }).OrderBy(x => x.IlAdi).ToList(); ;
            comboBox1.DisplayMember = "IlAdi";
            comboBox1.ValueMember = "IlId";
            comboBox1.DataSource = list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ilce ilce = new Ilce();
            ilce.IlceAdi=txtİlceAdi.Text;
            ilce.IlId = (int)comboBox1.SelectedValue;
            db.ilceler.Add(ilce);
            db.SaveChanges();
            listele();
            

        }

        private void Formilce_Load(object sender, EventArgs e)
        {
            ComboBoxListele();
            listele();
        }

        public void listele() {

            try
            {   //1. yöntem
                var list = db.ilceler.Select(I => new { I.IlId, I.IlceId, I.IlceAdi, SehirAdi = I.il.IlAdi })
                    .Where(I => I.IlId == (int)comboBox1.SelectedValue).OrderBy(I=>I.SehirAdi)
                    .ToList();
                
                //2.yöntem
                var liste2 = from i in db.ilceler where i.IlId == (int)comboBox1.SelectedValue select new { i.IlId, i.IlceId, i.il.IlAdi, i.IlceAdi };

                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;

                txtİlceAdi.Clear();
                txtİlceAdi.Focus();
               

            }
            catch (Exception)
            {

               
            }


        }

    }
}
