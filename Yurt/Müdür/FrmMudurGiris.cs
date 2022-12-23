using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Yurt.Sikayetler;

namespace Yurt.Müdür
{
    public partial class FrmMudurGiris : Form
    {
        public FrmMudurGiris()
        {
            InitializeComponent();
        }

        Sql sql = new Sql();
       
        private void FrmMudurGiris_Load(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }
        public static string tcGiris;
        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Mudur Where mudurKullaniciAdi=@p1 and mudurSifre=@p2 ",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                TxtKullaniciAd.Text = dr[3].ToString();
                TxtSifre.Text = dr[4].ToString();
                FrmMudurAnaSayfa mdr = new FrmMudurAnaSayfa();
                tcGiris = dr[1].ToString();
                mdr.lblTCC.Text = dr[1].ToString();
                mdr.Show();
                this.Hide();



            }
            
        }

        private void checkboxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxSifreGoster.Checked)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar= true;
            }
        }

        private void FrmMudurGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaGiris ana = new AnaGiris();
            ana.Show();
         
        }
    }
}
