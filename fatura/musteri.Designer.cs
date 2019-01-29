namespace fatura
{
    partial class musteri
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
            this.txtMusteriUnvani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textadress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxşehir = new System.Windows.Forms.ComboBox();
            this.comboBoxilce = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriUnvani
            // 
            this.txtMusteriUnvani.Location = new System.Drawing.Point(97, 29);
            this.txtMusteriUnvani.Name = "txtMusteriUnvani";
            this.txtMusteriUnvani.Size = new System.Drawing.Size(288, 20);
            this.txtMusteriUnvani.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Musteri Unvani";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 210);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textadress
            // 
            this.textadress.Location = new System.Drawing.Point(97, 58);
            this.textadress.Multiline = true;
            this.textadress.Name = "textadress";
            this.textadress.Size = new System.Drawing.Size(288, 20);
            this.textadress.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "adress";
            // 
            // comboBoxşehir
            // 
            this.comboBoxşehir.FormattingEnabled = true;
            this.comboBoxşehir.Location = new System.Drawing.Point(97, 85);
            this.comboBoxşehir.Name = "comboBoxşehir";
            this.comboBoxşehir.Size = new System.Drawing.Size(121, 21);
            this.comboBoxşehir.TabIndex = 14;
            this.comboBoxşehir.SelectedIndexChanged += new System.EventHandler(this.comboBoxşehir_SelectedIndexChanged);
            // 
            // comboBoxilce
            // 
            this.comboBoxilce.FormattingEnabled = true;
            this.comboBoxilce.Location = new System.Drawing.Point(97, 112);
            this.comboBoxilce.Name = "comboBoxilce";
            this.comboBoxilce.Size = new System.Drawing.Size(121, 21);
            this.comboBoxilce.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Müşteri İlçesi";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(23, 88);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(68, 13);
            this.m.TabIndex = 16;
            this.m.Text = "Müşteri Şehri";
            // 
            // musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.m);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxilce);
            this.Controls.Add(this.comboBoxşehir);
            this.Controls.Add(this.textadress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriUnvani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "musteri";
            this.Text = "musteri";
            this.Load += new System.EventHandler(this.musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriUnvani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textadress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxşehir;
        private System.Windows.Forms.ComboBox comboBoxilce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m;
    }
}