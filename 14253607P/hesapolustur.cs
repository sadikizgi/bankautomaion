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
    public partial class hesapolustur : Form
    {
        public hesapolustur()
        {
            InitializeComponent();
        }

        private void hesapolustur_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from hesaplar", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewhesaplar.DataSource = dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show(" Müşteriyi eklemek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("select count(musNo) from musteriler where musNo = '" + textBox2.Text + "'", baglanti);
                int sayi = (int)komut1.ExecuteScalar();
                baglanti.Close();
                if (sayi != 0)
                {
                
                baglanti.Open();
                SqlCommand ekle = new SqlCommand();

                ekle.Connection = baglanti;
                ekle.CommandText = "insert into hesaplar(HesapNo,MusteriNo,EkHesap,Bakiye,KulBakiye) values (@hno,@mno,@ekhesap,@bakiye,@kulbakiye)";
                ekle.Parameters.AddWithValue("@hno", textBox1.Text);
                ekle.Parameters.AddWithValue("@mno", textBox2.Text);
                ekle.Parameters.AddWithValue("@ekhesap", textBox3.Text);
                ekle.Parameters.AddWithValue("@bakiye", textBox4.Text);

                int sayi1 = Convert.ToInt32(textBox3.Text);
                int sayi2 = Convert.ToInt32(textBox4.Text);
                int toplam;
                toplam = sayi1 + sayi2;
                ekle.Parameters.AddWithValue("@kulbakiye", toplam);





                try
                {
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Hesap ekleme işlemi başarılı .");
                    baglanti.Close();
                }
                catch
                {
                    MessageBox.Show("hata");
                }
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from hesaplar", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewhesaplar.DataSource = dt;
                baglanti.Close();

            }
                else
                {
                    MessageBox.Show("BÖYLE BİR MÜŞTERİ NUMARASI YOKTUR TEKRAR DENAYİN");
                }
            }
        }

       
    }
    }


