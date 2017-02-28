namespace _14253607P
{
    partial class hesapislemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EkHesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KulBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HesapNo,
            this.MusteriNo,
            this.EkHesap,
            this.Bakiye,
            this.KulBakiye});
            this.dataGridView1.Location = new System.Drawing.Point(389, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 587);
            this.dataGridView1.TabIndex = 2;
            // 
            // HesapNo
            // 
            this.HesapNo.DataPropertyName = "HesapNo";
            this.HesapNo.HeaderText = "Hesap Numarası";
            this.HesapNo.Name = "HesapNo";
            this.HesapNo.ReadOnly = true;
            this.HesapNo.Width = 120;
            // 
            // MusteriNo
            // 
            this.MusteriNo.DataPropertyName = "MusteriNo";
            this.MusteriNo.HeaderText = "Müşteri Numarası";
            this.MusteriNo.Name = "MusteriNo";
            this.MusteriNo.ReadOnly = true;
            this.MusteriNo.Width = 120;
            // 
            // EkHesap
            // 
            this.EkHesap.DataPropertyName = "EkHesap";
            this.EkHesap.HeaderText = "Ek Hesap";
            this.EkHesap.Name = "EkHesap";
            this.EkHesap.ReadOnly = true;
            this.EkHesap.Width = 120;
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
            this.KulBakiye.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 109);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yeni Hesap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 109);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hesap Kapatma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 109);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hesap Hareketleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 109);
            this.button4.TabIndex = 6;
            this.button4.Text = "Havale Tablosu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hesapislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 616);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "hesapislemleri";
            this.Text = "HESAP İŞLEMLERİ";
            this.Load += new System.EventHandler(this.hesapislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EkHesap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn KulBakiye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}