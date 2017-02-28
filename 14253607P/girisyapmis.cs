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
    public partial class girisyapmis : Form
    {
        public girisyapmis()
        {
            InitializeComponent();
        }
        
        private void girisyapmis_Load(object sender, EventArgs e ) 
        {
            label1.Text = "HOŞGELDİNİZ "  ;
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from musteriler", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewmusteri.DataSource = dt;
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show(" Müşteriyi silmek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
          
                SqlCommand sil = new SqlCommand();
                baglanti.Open();

                sil.Connection = baglanti;
                sil.CommandText = "Delete From musteriler where musNo='" + textBox12.Text + "'";
                
                try
                {
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Müşteri kalıcı olarak Silindi");
                    baglanti.Close();
                }
                catch
                {
                    MessageBox.Show("silme işlemi hatalı tekrar kontrol ediniz.");
                }
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from musteriler", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewmusteri.DataSource = dt;
                baglanti.Close();

            }
        }
        private void dataGridViewmusteri_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int secili = e.RowIndex;
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from musteriler", baglanti);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "musteriler");
            textBox12.Text = ds.Tables["musteriler"].Rows[secili]["musNo"].ToString();
            textBox11.Text = ds.Tables["musteriler"].Rows[secili]["musAd"].ToString();
            textBox10.Text = ds.Tables["musteriler"].Rows[secili]["musSoyad"].ToString();
            textBox9.Text = ds.Tables["musteriler"].Rows[secili]["musAdres"].ToString();
            textBox8.Text = ds.Tables["musteriler"].Rows[secili]["musTel"].ToString();
            textBox7.Text = ds.Tables["musteriler"].Rows[secili]["musEmail"].ToString();

            baglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
        }

        private void buttonkeydet_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show(" Müşteriyi eklemek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                if (textBox12.Text == "" || textBox11.Text == "" || textBox10.Text == "" || textBox9.Text == "" || textBox8.Text == "" || textBox7.Text == "" )
                {
                    MessageBox.Show("TÜM ALANLARI DOLDURUNUZ . ALANLAR BOŞ GEÇİLEMEZ !");
                }
                else
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();

                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "insert into musteriler(musNo,musAd,musSoyad,musAdres,musTel,musEmail) values (@no,@ad,@soyad,@adres,@tel,@email)";
                    ekle.Parameters.AddWithValue("@no", textBox12.Text);
                    ekle.Parameters.AddWithValue("@ad", textBox11.Text);
                    ekle.Parameters.AddWithValue("@soyad", textBox10.Text);
                    ekle.Parameters.AddWithValue("@adres", textBox9.Text);
                    ekle.Parameters.AddWithValue("@tel", textBox8.Text);
                    ekle.Parameters.AddWithValue("@email", textBox7.Text);

                    try
                    {
                        ekle.ExecuteNonQuery();
                        MessageBox.Show("Müşteri ekleme işlemi başarılı .");
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("hata");
                    }
                    baglanti.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from musteriler", baglanti);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewmusteri.DataSource = dt;
                    baglanti.Close();
                }
            }
        }
        private void buttonvazgeç_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
        }

        private void buttonduzelt_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show(" Müşteriyi bilgilerini düzeltmek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");

                SqlCommand duzelt = new SqlCommand();
                baglanti.Open();

                duzelt.Connection = baglanti;
                duzelt.CommandText = "update  musteriler set musEmail = @email , musAd = @ad , musSoyad = @soyad , musAdres = @adres , musTel =@tel  where musNo = @no ";
                duzelt.Parameters.AddWithValue("@no", textBox12.Text);
                duzelt.Parameters.AddWithValue("@ad", textBox11.Text);
                duzelt.Parameters.AddWithValue("@soyad", textBox10.Text);
                duzelt.Parameters.AddWithValue("@adres", textBox9.Text);
                duzelt.Parameters.AddWithValue("@tel", textBox8.Text);
                duzelt.Parameters.AddWithValue("@email", textBox7.Text);

                try
                {
                    duzelt.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Bilgileri Düzeltildi");
                    baglanti.Close();
                }
                catch
                {
                    MessageBox.Show("düzeltme işlemi hatalı tekrar kontrol ediniz.");
                }
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from musteriler", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewmusteri.DataSource = dt;
                baglanti.Close();

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
