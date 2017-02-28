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
    public partial class havale : Form
    {
        public havale()
        {
            InitializeComponent();
        }

        private void havale_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from havale", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
