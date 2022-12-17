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

namespace Yurt.YoneticiIslemleri
{
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelTc,PersonelAdSoyad,PersonelDepartman,PersonelTelefon,PersonelMail,PersonelAdres,PersonelSifre) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", sql.Baglan());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", CmbDep.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p7", TxtSifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla eklendi");
            sql.Baglan().Close();
        }
    }
}
