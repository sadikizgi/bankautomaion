namespace _14253607P
{
    partial class hesapsil
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(57, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Silme ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hesap Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silmek istediğiniz hesap Numarasını Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
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
            this.dataGridViewhesaplar.Location = new System.Drawing.Point(480, 12);
            this.dataGridViewhesaplar.Name = "dataGridViewhesaplar";
            this.dataGridViewhesaplar.Size = new System.Drawing.Size(684, 513);
            this.dataGridViewhesaplar.TabIndex = 2;
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
            // hesapsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 547);
            this.Controls.Add(this.dataGridViewhesaplar);
            this.Controls.Add(this.groupBox1);
            this.Name = "hesapsil";
            this.Text = "Hesap Silme";
            this.Load += new System.EventHandler(this.hesapsil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhesaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewhesaplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EkHesap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn KulBakiye;
    }
}