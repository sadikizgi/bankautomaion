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
    public partial class hesapozeti : Form
    {
        public hesapozeti()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=true");
        private void hesapozeti_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglanti;

            ekle.CommandText = "select * , isl.tarih,isTur.aciklama from islemTab isl, islemturtab isTur where isl.islemTur=isTur.id ";

            baglanti.Close();
        }
    }
    }
}
