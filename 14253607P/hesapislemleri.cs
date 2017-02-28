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
    public partial class hesapislemleri : Form
    {
        public hesapislemleri()
        {
            InitializeComponent();
        }

        private void hesapislemleri_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from hesaplar", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapolustur hesap = new hesapolustur();
            hesap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hesapsil hesap = new hesapsil();
            hesap.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            heasphareketleri hesap = new heasphareketleri();
            hesap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            havale havale = new havale();
            havale.Show();
        }
    }
}
