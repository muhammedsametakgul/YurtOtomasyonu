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
    public partial class FrmYoneticiSifreGuncelle : Form
    {
        public FrmYoneticiSifreGuncelle()
        {
            InitializeComponent();
        }
        Sql sql=new Sql();
        public string tc_sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            

           if(TxtSifre.Text == TxtSifre2.Text)
            {

                SqlCommand komut = new SqlCommand("Update Admin set YoneticiSifre=@p1 where  YoneticiTc=@p2", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", TxtSifre.Text);
                komut.Parameters.AddWithValue("@p2",MskTcSifreGuncelleme.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla güncellendi");
                sql.Baglan().Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifreler Uyuşmuyor.Tekrar Deneyiniz");
                TxtSifre.Text = "";
                TxtSifre2.Text = "";
            }
        }
       // public string tc_sifre_guncelleme;
        private void YoneticiSifreGuncelle_Load(object sender, EventArgs e)
        {
            ///MskTcSifreGuncelleme.Text = tc_sifre_guncelleme;
           
        }

        private void MskTcSifreGuncelleme_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }
    }
}
