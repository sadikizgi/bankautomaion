namespace _14253607P
{
    partial class hesapolustur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewhesaplar = new System.Windows.Forms.DataGridView();
            this.HesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EkHesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KulBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhesaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(27, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Hesap Oluşturma";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bakiye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ek Hesap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Müşteri Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hesap Numarası";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 176);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "OLUŞTUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewhesaplar
            // 
            this.dataGridViewhesaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewhesaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HesapNo,
            this.MusteriNo,
            this.EkHesap,
            this.Bakiye,
            this.KulBakiye});
            this.dataGridViewhesaplar.Location = new System.Drawing.Point(408, 44);
            this.dataGridViewhesaplar.Name = "dataGridViewhesaplar";
            this.dataGridViewhesaplar.Size = new System.Drawing.Size(684, 513);
            this.dataGridViewhesaplar.TabIndex = 1;
            // 
            // HesapNo
            // 
            this.HesapNo.DataPropertyName = "HesapNo";
            this.HesapNo.HeaderText = "Hesap Numarası";
            this.HesapNo.Name = "HesapNo";
            this.HesapNo.ReadOnly = true;
            this.HesapNo.Width = 130;
            // 
            // MusteriNo
            // 
            this.MusteriNo.DataPropertyName = "MusteriNo";
            this.MusteriNo.HeaderText = "Müşteri Numarası";
            this.MusteriNo.Name = "MusteriNo";
            this.MusteriNo.ReadOnly = true;
            this.MusteriNo.Width = 130;
            // 
            // EkHesap
            // 
            this.EkHesap.DataPropertyName = "EkHesap";
            this.EkHesap.HeaderText = "Ek Hesap";
            this.EkHesap.Name = "EkHesap";
            this.EkHesap.ReadOnly = true;
            this.EkHesap.Width = 130;
            // 
            // Bakiye
            // 
            this.Bakiye.DataPropertyName = "Bakiye";
            this.Bakiye.HeaderText = "Bakiye";
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.ReadOnly = true;
            this.Bakiye.Width = 120;
            // 
            // KulBakiye
            // 
            this.KulBakiye.DataPropertyName = "KulBakiye";
            this.KulBakiye.HeaderText = "Kullanılabilir Bakiye";
            this.KulBakiye.Name = "KulBakiye";
            this.KulBakiye.ReadOnly = true;
            this.KulBakiye.Width = 130;
            // 
            // hesapolustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 592);
            this.Controls.Add(this.dataGridViewhesaplar);
            this.Controls.Add(this.groupBox1);
            this.Name = "hesapolustur";
            this.Text = "hesapolustur";
            this.Load += new System.EventHandler(this.hesapolustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhesaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewhesaplar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EkHesap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn KulBakiye;
    }
}