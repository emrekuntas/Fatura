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
        int secilenID;

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
            var list = db.iller.Select(I => new { I.IlId, I.IlAdi }).ToList();
            dataGridView1.DataSource = list;
            txtİlAdi.Clear();
            txtİlAdi.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Il il = db.iller.Find(secilenID);
            txtİlAdi.Text = il.IlAdi;

        }

        private void Formİl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             Il il = db.iller.Find(secilenID);
            il.IlAdi = txtİlAdi.Text;
            db.SaveChanges();
            Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("il seçiniz..");
               
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = db.iller.Find(secilenID);
                db.iller.Remove(il);
                db.SaveChanges();
                Listele();

            }
            catch (Exception ex)
            {

                MessageBox.Show("il seçiniz..");
            }
        }
    }
}
