namespace _14253607P
{
    partial class havale
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
            this.GonderenHesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlanHesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GonderenHesap,
            this.islemNo,
            this.AlanHesap,
            this.Tarih});
            this.dataGridView1.Location = new System.Drawing.Point(182, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // GonderenHesap
            // 
            this.GonderenHesap.DataPropertyName = "GonderenHesap";
            this.GonderenHesap.HeaderText = "Gonderen Hesap";
            this.GonderenHesap.Name = "GonderenHesap";
            this.GonderenHesap.Width = 130;
            // 
            // islemNo
            // 
            this.islemNo.DataPropertyName = "islemNo";
            this.islemNo.HeaderText = "islem numarası";
            this.islemNo.Name = "islemNo";
            this.islemNo.Width = 130;
            // 
            // AlanHesap
            // 
            this.AlanHesap.DataPropertyName = "AlanHesap";
            this.AlanHesap.HeaderText = "Alan Hesap";
            this.AlanHesap.Name = "AlanHesap";
            this.AlanHesap.Width = 130;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 130;
            // 
            // havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 585);
            this.Controls.Add(this.dataGridView1);
            this.Name = "havale";
            this.Text = "havale";
            this.Load += new System.EventHandler(this.havale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonderenHesap;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlanHesap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
    }
}