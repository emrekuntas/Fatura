namespace fatura
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlmleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.faturaİşlmleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.birimEkleToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.ilEkleToolStripMenuItem,
            this.ilçeEkleToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // birimEkleToolStripMenuItem
            // 
            this.birimEkleToolStripMenuItem.Name = "birimEkleToolStripMenuItem";
            this.birimEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.birimEkleToolStripMenuItem.Text = "Birim Ekle";
            this.birimEkleToolStripMenuItem.Click += new System.EventHandler(this.birimEkleToolStripMenuItem_Click);
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunEkleToolStripMenuItem.Text = "Urun Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // ilEkleToolStripMenuItem
            // 
            this.ilEkleToolStripMenuItem.Name = "ilEkleToolStripMenuItem";
            this.ilEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilEkleToolStripMenuItem.Text = "İl Ekle";
            this.ilEkleToolStripMenuItem.Click += new System.EventHandler(this.ilEkleToolStripMenuItem_Click);
            // 
            // ilçeEkleToolStripMenuItem
            // 
            this.ilçeEkleToolStripMenuItem.Name = "ilçeEkleToolStripMenuItem";
            this.ilçeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilçeEkleToolStripMenuItem.Text = "İlçe Ekle";
            this.ilçeEkleToolStripMenuItem.Click += new System.EventHandler(this.ilçeEkleToolStripMenuItem_Click);
            // 
            // faturaİşlmleriToolStripMenuItem
            // 
            this.faturaİşlmleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüleToolStripMenuItem,
            this.sorgulaToolStripMenuItem});
            this.faturaİşlmleriToolStripMenuItem.Name = "faturaİşlmleriToolStripMenuItem";
            this.faturaİşlmleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.faturaİşlmleriToolStripMenuItem.Text = "Fatura İşlmleri";
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.görüntüleToolStripMenuItem.Text = "Görüntüle/Sorgula/Düzenle";
            // 
            // sorgulaToolStripMenuItem
            // 
            this.sorgulaToolStripMenuItem.Name = "sorgulaToolStripMenuItem";
            this.sorgulaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.sorgulaToolStripMenuItem.Text = "FaturaOlustur";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaİşlmleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorgulaToolStripMenuItem;
    }
}

