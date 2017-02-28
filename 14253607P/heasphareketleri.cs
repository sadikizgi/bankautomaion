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
    public partial class heasphareketleri : Form
    {
        public heasphareketleri()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Convert.ToInt32(tbhesapno.Text) > 0)
                {
                    SqlConnection bag = new SqlConnection();
                    bag.ConnectionString = "Server =.;Database=uyeler;Trusted_Connection=true;";
                    bag.Open();
                    SqlParameter prm = new SqlParameter("@hesapNo", tbhesapno.Text);
                    string sql = "";
                    sql = "SELECT * FROM hesaplar WHERE hesapNo = @hesapNo ";
                    SqlCommand cmd = new SqlCommand(sql, bag);
                    cmd.Parameters.Add(prm);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dr = new DataTable();
                    da.Fill(dr);

                    if (dr.Rows.Count > 0)
                    {
                        label8.Text = "İşlem gerçekleşti";
                        DialogResult c;
                        c = MessageBox.Show(" İşlem Yapılsın mı ?  ", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (c == DialogResult.Yes)
                        {
                            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                            baglanti.Open();
                            SqlCommand ekle = new SqlCommand();
                            ekle.Connection = baglanti;

                            ekle.CommandText = "insert into islemTab(islemNo,hesapNo,islemTur,miktar,tarih) values (@islemno,@hesapno,@islemtur,@miktar,@tarih) ";
                            ekle.Parameters.AddWithValue("@islemno", tbislemno.Text);
                            ekle.Parameters.AddWithValue("@hesapno", tbhesapno.Text);

                            if (cbislemtur.SelectedIndex == 0)
                            {
                                ekle.Parameters.AddWithValue("@islemtur", Convert.ToInt32(1));
                            }
                            if (cbislemtur.SelectedIndex == 1)
                            {
                                ekle.Parameters.AddWithValue("@islemtur", Convert.ToInt32(2));
                            }
                            if (cbislemtur.SelectedIndex == 2)
                            {

                                ekle.Parameters.AddWithValue("@islemtur", Convert.ToInt32(3));
                            }

                            if (Convert.ToInt32(tbmiktar.Text) > 750)
                            {
                                try
                                {
                                    MessageBox.Show("limiti aştınız günde 750 den fazla para çekemezsiniz.");
                                }
                                catch
                                {

                                }                              
                            }
                            else
                            {
                                ekle.Parameters.AddWithValue("@miktar", tbmiktar.Text);
                            }

                            ekle.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);


                            try
                            {

                                ekle.ExecuteNonQuery();
                                MessageBox.Show("İşlem Gerçekleşti .");
                                baglanti.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Tüm işlemler İptal edildi");
                            }

                            baglanti.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter("Select * from islemTab", baglanti);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewislemtab.DataSource = dt;
                            baglanti.Close();


                        }

                    }
                    else
                    {
                        MessageBox.Show("Böyle bir Hesap numarası Yok !");
                        label8.ResetText();
                        label8.Text = "Uygun bir hesap numarası girmeniz gerekiyor";
                    }
                }
            }
            catch (Exception)
            {
                label8.ResetText();
                
            }

            // EK HESAP PARA YATIRMA
            if (cbislemtur.SelectedIndex == 0)
            {
                if (cbekhesapbakiye.SelectedIndex == 0)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "update hesaplar set EkHesap = @ekhesap where HesapNo = @hesapno";
                    ekle.Parameters.AddWithValue("@ekhesap", tbmiktar.Text);
                    ekle.Parameters.AddWithValue("@hesapno", tbhesapno.Text);


                    try
                    {
                        ekle.CommandText = string.Format("update hesaplar set EkHesap = EkHesap + '{0}' , KulBakiye = KulBakiye + '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbhesapno.Text);
                        ekle.ExecuteNonQuery();
                        
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Para Ek hesaba eklenemedi.");
                    }

                }
                // BAKİYE YE PARA YATIRMA
                if (cbekhesapbakiye.SelectedIndex == 1)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "update hesaplar set Bakiye = @bakiye where HesapNo = @hesapno";
                    ekle.Parameters.AddWithValue("@bakiye", tbmiktar.Text);
                    ekle.Parameters.AddWithValue("@hesapno", tbhesapno.Text);

                    try
                    {
                        ekle.CommandText = string.Format("update hesaplar set Bakiye = Bakiye + '{0}' , KulBakiye = KulBakiye + '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbhesapno.Text);
                        ekle.ExecuteNonQuery();
                        
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Paranınız bakiyeye eklenemedi.");
                    }
                }
            }

            if (cbislemtur.SelectedIndex == 1)
            {
                // EK HESAPTAN PARA ÇEKME
                if (cbekhesapbakiye.SelectedIndex == 0)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "update hesaplar set EkHesap = @ekhesap where HesapNo = @hesapno";
                    ekle.Parameters.AddWithValue("@ekhesap", tbmiktar.Text);
                    ekle.Parameters.AddWithValue("@hesapno", tbhesapno.Text);


                    try
                    {
                        ekle.CommandText = string.Format("update hesaplar set EkHesap = EkHesap - '{0}' , KulBakiye = KulBakiye - '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbhesapno.Text);
                        ekle.ExecuteNonQuery();
                        MessageBox.Show("Para Ek hesabatan çekildi .");
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Para Ek hesabatan çekilemedi.");
                    }

                }
                // BAKİYEDEN PARA ÇEKME

                if (cbekhesapbakiye.SelectedIndex == 1)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "update hesaplar set Bakiye = @bakiye where HesapNo = @hesapno";
                    ekle.Parameters.AddWithValue("@bakiye", tbmiktar.Text);
                    ekle.Parameters.AddWithValue("@hesapno", tbhesapno.Text);

                    try
                    {
                        ekle.CommandText = string.Format("update hesaplar set Bakiye = Bakiye - '{0}' , KulBakiye = KulBakiye - '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbhesapno.Text);
                        ekle.ExecuteNonQuery();
                        
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Paranınız bakiyeden çekilemedi.");
                    }
                }

            }


            // HAVALE 
            if (cbislemtur.SelectedIndex == 2)
            {
                if (cbekhesapbakiye.SelectedIndex == 1)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "update hesaplar set Bakiye = @bakiye where HesapNo = @hesapno";
                    ekle.Parameters.AddWithValue("@bakiye", tbmiktar.Text);
                    ekle.Parameters.AddWithValue("@hesapno", tbhesapno.Text);
                    try
                    {
                        ekle.CommandText = string.Format("update hesaplar set Bakiye = Bakiye - '{0}' , KulBakiye = KulBakiye - '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbhesapno.Text);
                        ekle.ExecuteNonQuery();
                        
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Havale yapılamadı para çekilemedi.");
                    }


                    if (Convert.ToInt32(tbalicino.Text) > 0)
                    {
                        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                        bag.Open();
                        SqlCommand eklen = new SqlCommand();
                        eklen.Connection = bag;
                        eklen.CommandText = "update hesaplar set Bakiye = @bakiye where HesapNo = @hesapno";
                        eklen.Parameters.AddWithValue("@bakiye", tbmiktar.Text);
                        eklen.Parameters.AddWithValue("@hesapno", tbalicino.Text);
                        try
                        {
                            eklen.CommandText = string.Format("update hesaplar set Bakiye = Bakiye + '{0}' , KulBakiye = KulBakiye + '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbalicino.Text);
                            eklen.ExecuteNonQuery();
                            
                            bag.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Havale yapılamadı para eklenemedi.");
                        }
                    }
                }
                // HAVALE 2. kısım
                if (cbekhesapbakiye.SelectedIndex == 0)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand();
                    ekle.Connection = baglanti;
                    ekle.CommandText = "update hesaplar set EkHesap = @ekhesap where HesapNo = @hesapno";
                    ekle.Parameters.AddWithValue("@ekhesap", tbmiktar.Text);
                    ekle.Parameters.AddWithValue("@hesapno", tbhesapno.Text);


                    try
                    {
                        ekle.CommandText = string.Format("update hesaplar set EkHesap = EkHesap - '{0}' , KulBakiye = KulBakiye - '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbhesapno.Text);
                        ekle.ExecuteNonQuery();
                        
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Para Ek hesabatan çekilemedi.");
                    }

                    if (Convert.ToInt32(tbalicino.Text) > 0)
                    {
                        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                        bag.Open();
                        SqlCommand eklen = new SqlCommand();
                        eklen.Connection = bag;
                        eklen.CommandText = "update hesaplar set EkHesap = @ekhesap where HesapNo = @hesapno";
                        eklen.Parameters.AddWithValue("@ekhesap", tbmiktar.Text);
                        eklen.Parameters.AddWithValue("@hesapno", tbalicino.Text);


                        try
                        {
                            eklen.CommandText = string.Format("update hesaplar set EkHesap = EkHesap + '{0}' , KulBakiye = KulBakiye + '{1}' where ( HesapNo = '{2}' )", Convert.ToInt32(tbmiktar.Text), Convert.ToInt32(tbmiktar.Text), tbalicino.Text);
                            eklen.ExecuteNonQuery();
                           
                            bag.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Para Ek hesabatan çekilemedi.");
                        }
                    }

                    }
                }
            if(cbislemtur.SelectedIndex == 2)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
                baglanti.Open();
                SqlCommand ekle = new SqlCommand();
                ekle.Connection = baglanti;

                ekle.CommandText = "insert into havale(GonderenHesap,AlanHesap,Tarih) values (@gonderenhesap , @alanhesap , @tarih) ";
                ekle.Parameters.AddWithValue("@gonderenhesap", tbhesapno.Text);
                ekle.Parameters.AddWithValue("@alanhesap", tbalicino.Text);
                ekle.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }

        }

        private void heasphareketleri_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from islemTab", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewislemtab.DataSource = dt;
            baglanti.Close();
        }

        private void cbislemtur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbislemtur.SelectedIndex == 0)
            {
                tbalicino.Enabled = false;
            }
            if (cbislemtur.SelectedIndex == 1)
            {
                tbalicino.Enabled = false;
            }
            if (cbislemtur.SelectedIndex == 2)
            {
                cbekhesapbakiye.Enabled = true;                            
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbalicino.Text = "";
            tbhesapno.Text = "";
            tbislemno.Text = "";
            tbmiktar.Text = "";
            cbekhesapbakiye.Text = "";
            cbislemtur.Text = "";
            cbekhesapbakiye.Enabled = true;
            tbalicino.Enabled = true;
            label8.Text = "";
        }
    }
}
