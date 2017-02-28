using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _14253607P
{
    public partial class yeniuye : Form
    {
        public yeniuye()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Kullanıcıyı eklemek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {

                if (txtKuladi.Text == "" || txtSifre.Text == "")
                {
                    MessageBox.Show("ALANLAR BOŞ GEÇİLEMEZ");
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("select count(kadi) from kullanici where kadi = '" + txtKuladi.Text + "'", baglanti);
                    int sayi = (int)komut1.ExecuteScalar();
                    baglanti.Close();
                    if (sayi != 0)
                    {
                        MessageBox.Show("KAYIT ZATEN VAR !");
                    }
                    else
                    {
                        baglanti.Open();
                        SqlCommand ekle = new SqlCommand("INSERT INTO kullanici (kadi,sifre) VALUES ('" + txtKuladi.Text + "','" + txtSifre.Text + "')", baglanti);
                        try
                        {
                            ekle.ExecuteNonQuery();
                            baglanti.Close();
                            lblkaydet.Text = "KULLANICI EKLEME BAŞARILI.";
                            txtKuladi.Clear();
                            txtSifre.Clear();
                        }
                        catch
                        {
                            lblkaydet.Text = "KULLANICI EKLEME BAŞARISIZ.";
                        }
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show(" Kullanıcıyı silmek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete From kullanici where kadi='" + txtSil.Text + "'";

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                lblsil.Text = "SİLME İŞLEMİ BAŞARILI.";
                txtSil.Clear();
            }
        }

        private void yeniuye_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Kullanıcıyı güncellemek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand();                
                guncelle.Connection = baglanti;
                guncelle.CommandText = "update kullanici set sifre = @sifre where kadi = @kadi ";
                guncelle.Parameters.AddWithValue("@sifre", textBox1.Text);
                guncelle.Parameters.AddWithValue("@kadi", textBox2.Text);

                
                
                try
                {
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();
                    label6.Text = "KULLANICI GüNCELLEME BAŞARILI.";
                }
                catch
                {
                    label6.Text = "olmadı.";
                }

            }
        }
    }
}
