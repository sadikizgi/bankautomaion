namespace _14253607P
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogrulama = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.exHata = new System.Windows.Forms.Label();
            this.btnGirisyap = new System.Windows.Forms.Button();
            this.txtKuladi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // lblDogrulama
            // 
            this.lblDogrulama.AutoSize = true;
            this.lblDogrulama.Location = new System.Drawing.Point(126, 266);
            this.lblDogrulama.Name = "lblDogrulama";
            this.lblDogrulama.Size = new System.Drawing.Size(0, 13);
            this.lblDogrulama.TabIndex = 2;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(183, 266);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 3;
            // 
            // exHata
            // 
            this.exHata.AutoSize = true;
            this.exHata.Location = new System.Drawing.Point(246, 266);
            this.exHata.Name = "exHata";
            this.exHata.Size = new System.Drawing.Size(0, 13);
            this.exHata.TabIndex = 4;
            // 
            // btnGirisyap
            // 
            this.btnGirisyap.Location = new System.Drawing.Point(162, 179);
            this.btnGirisyap.Name = "btnGirisyap";
            this.btnGirisyap.Size = new System.Drawing.Size(114, 34);
            this.btnGirisyap.TabIndex = 5;
            this.btnGirisyap.Text = "GİRİŞ";
            this.btnGirisyap.UseVisualStyleBackColor = true;
            this.btnGirisyap.Click += new System.EventHandler(this.btnGirisyap_Click);
            // 
            // txtKuladi
            // 
            this.txtKuladi.Location = new System.Drawing.Point(129, 82);
            this.txtKuladi.Name = "txtKuladi";
            this.txtKuladi.Size = new System.Drawing.Size(167, 20);
            this.txtKuladi.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(129, 128);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 20);
            this.txtSifre.TabIndex = 7;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 325);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKuladi);
            this.Controls.Add(this.btnGirisyap);
            this.Controls.Add(this.exHata);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.lblDogrulama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "KULLANICI GİRİŞİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogrulama;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label exHata;
        private System.Windows.Forms.Button btnGirisyap;
        private System.Windows.Forms.TextBox txtKuladi;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

