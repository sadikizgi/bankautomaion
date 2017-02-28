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
    public partial class hesapsil : Form
    {
        public hesapsil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                 
                 DialogResult c;
                 c = MessageBox.Show(" Hesabı  silmek istediğinize eminmisiniz ! ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (c == DialogResult.Yes)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("select count(HesapNo) from hesaplar where HesapNo = '" + textBox1.Text + "'", baglanti);
                    int sayi = (int)komut1.ExecuteScalar();
                    baglanti.Close();

                    if (sayi != 0)
                    {
                        SqlCommand sil = new SqlCommand();
                        baglanti.Open();

                        sil.Connection = baglanti;
                        sil.CommandText = "Delete From hesaplar where HesapNo='" + textBox1.Text + "'";

                        try
                        {
                            sil.ExecuteNonQuery();
                            MessageBox.Show("Hesap kalıcı olarak Silindi");
                            baglanti.Close();
                        }
                        catch
                        {
                            MessageBox.Show("silme işlemi hatalı tekrar kontrol ediniz.");
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
                        MessageBox.Show("BÖYLE BİR HESAP NUMARASSI YOK");
                    }
                }
                
        }

        private void hesapsil_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from hesaplar", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewhesaplar.DataSource = dt;
            baglanti.Close();
        }
    }
}
