namespace fatura
{
    partial class FormFaturaSorgulama
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
            this.comboBoxSehir = new System.Windows.Forms.ComboBox();
            this.comboBoxİlce = new System.Windows.Forms.ComboBox();
            this.comboBoxMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxfatura = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSehir
            // 
            this.comboBoxSehir.FormattingEnabled = true;
            this.comboBoxSehir.Location = new System.Drawing.Point(600, 27);
            this.comboBoxSehir.Name = "comboBoxSehir";
            this.comboBoxSehir.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSehir.TabIndex = 0;
            this.comboBoxSehir.SelectedIndexChanged += new System.EventHandler(this.comboBoxSehir_SelectedIndexChanged);
            // 
            // comboBoxİlce
            // 
            this.comboBoxİlce.FormattingEnabled = true;
            this.comboBoxİlce.Location = new System.Drawing.Point(600, 54);
            this.comboBoxİlce.Name = "comboBoxİlce";
            this.comboBoxİlce.Size = new System.Drawing.Size(121, 21);
            this.comboBoxİlce.TabIndex = 0;
            this.comboBoxİlce.SelectedIndexChanged += new System.EventHandler(this.comboBoxİlce_SelectedIndexChanged);
            // 
            // comboBoxMusteri
            // 
            this.comboBoxMusteri.FormattingEnabled = true;
            this.comboBoxMusteri.Location = new System.Drawing.Point(600, 81);
            this.comboBoxMusteri.Name = "comboBoxMusteri";
            this.comboBoxMusteri.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMusteri.TabIndex = 0;
            this.comboBoxMusteri.SelectedIndexChanged += new System.EventHandler(this.comboBoxMusteri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FATURA NO İLE SORGULAMA";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(545, 35);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(31, 13);
            this.labe.TabIndex = 1;
            this.labe.Text = "Şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "İlçe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Müşteri Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tüm Siparişleri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fatura No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 197);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxfatura
            // 
            this.textBoxfatura.Location = new System.Drawing.Point(135, 54);
            this.textBoxfatura.Name = "textBoxfatura";
            this.textBoxfatura.Size = new System.Drawing.Size(125, 20);
            this.textBoxfatura.TabIndex = 6;
            this.textBoxfatura.TextChanged += new System.EventHandler(this.textBoxfatura_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 311);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(801, 195);
            this.dataGridView2.TabIndex = 7;
            // 
            // FormFaturaSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(856, 518);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxfatura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMusteri);
            this.Controls.Add(this.comboBoxİlce);
            this.Controls.Add(this.comboBoxSehir);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FormFaturaSorgulama";
            this.Text = "FormFaturaSorgulama";
            this.Load += new System.EventHandler(this.FormFaturaSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSehir;
        private System.Windows.Forms.ComboBox comboBoxİlce;
        private System.Windows.Forms.ComboBox comboBoxMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxfatura;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}