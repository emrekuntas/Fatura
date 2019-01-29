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

        }

        private void Formilce_Load(object sender, EventArgs e)
        {
            ComboBoxListele();
        }
    }
}
