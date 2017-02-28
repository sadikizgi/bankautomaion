using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14253607P
{
    public partial class islemler : Form
    {
        public islemler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapislemleri hesap = new hesapislemleri();
            hesap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            girisyapmis giris = new girisyapmis();
            giris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yeniuye yeni = new yeniuye();
            yeni.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hesapozeti hesap = new hesapozeti();
            hesap.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gelirgider gelir = new gelirgider();
            gelir.Show();
        }
    }
}
