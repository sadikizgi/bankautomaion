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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisyap_Click(object sender, EventArgs e)
        {
           
            try

            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Server =.;Database=uyeler;Trusted_Connection=true;";
                baglanti.Open();
                SqlParameter prm1 = new SqlParameter("@kadi", txtKuladi.Text);
                SqlParameter prm2 = new SqlParameter("@sifre", txtSifre.Text);
                string sql = "";
                sql = "SELECT * FROM kullanici WHERE kadi = @kadi AND sifre = @sifre";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    lblHata.ResetText();
                    exHata.ResetText();
                    lblDogrulama.Text = "Başarılı giriş";
                    islemler giris = new islemler();
                    giris.Show();

                }
                else
                {
                    lblDogrulama.ResetText();
                    exHata.ResetText();
                    lblDogrulama.Text = "Hata ! Girmiş olduğunuz bilgiler hatalı";
                }
            }
            catch(Exception ex)
            {
                lblDogrulama.ResetText();
                lblHata.ResetText();
                exHata.Text = ex.Message;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniuye yeni = new yeniuye();
            yeni.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
