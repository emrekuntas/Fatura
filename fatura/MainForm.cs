﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            Formİl form = new Formİl();
            form.Show();
        }

        private void ilçeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formilce form = new Formilce();
            form.Show();
        }

        private void birimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birim birim = new birim();
            birim.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteri m = new musteri();
            m.Show();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urun u = new urun();
            u.Show();
        }

        private void sorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatura f = new Fatura();
            f.Show();
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFaturaSorgulama f = new FormFaturaSorgulama();
            f.Show();
        }
    }
}
