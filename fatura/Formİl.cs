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

    public partial class Formİl : Form
    {
        FaturaContext db = new FaturaContext();
        public Formİl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = new Il();
                il.IlAdi = txtİlAdi.Text;
                db.iller.Add(il);
                db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {
                string str = ex.Message;

            }
        }

        private void Listele()
        {
            var list = db.iller.Select(I => new { I.IlAdi, I.IlId }).ToList();
            dataGridView1.DataSource = list;
            txtİlAdi.Clear();
            txtİlAdi.Focus();
        }
    }
}
