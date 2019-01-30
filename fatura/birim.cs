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
    public partial class birim : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenid;
        
        public birim()
        {
            InitializeComponent();
        }

        private void birim_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {   //1.yöntem
            var list = db.birimler.Select(I => new { I.BirimId, I.BirimAdi }).ToList();
            dataGridView1.DataSource = list;
            txtbirimdi.Clear();
            txtbirimdi.Focus();
            //2.yöntem
            var list2 = from b in db.birimler select new {b.BirimId,b.BirimAdi };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Birim b = new Birim();
            b.BirimAdi=txtbirimdi.Text;
            db.birimler.Add(b);
            db.SaveChanges();
            Listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var birim = db.birimler.Find(secilenid);
            txtbirimdi.Text = birim.BirimAdi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Birim b = db.birimler.Find(secilenid);
            b.BirimAdi = txtbirimdi.Text;
            db.SaveChanges();
            Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Birim b = db.birimler.Find(secilenid);
            db.birimler.Remove(b);
            db.SaveChanges();
            Listele();
        }
    }
}
