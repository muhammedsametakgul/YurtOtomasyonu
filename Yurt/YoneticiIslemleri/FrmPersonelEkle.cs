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
            try
            {
                if (MskTc.Text.Length != 0 && TxtAd.Text.Length != 0 && CmbDep.Text != "" && mskTel.Text.Length != 0 && txtMail.Text.Length != 0 && TxtAdres.Text != "" && mskDogum.Text != "" && mskMaas.Text != "")
                {
                    DialogResult d = new DialogResult();
                d = MessageBox.Show("Eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    
                  
                        SqlCommand komut = new SqlCommand("insert into Personel (PersonelTc,PersonelAdSoyad,PersonelDepartman,PersonelTelefon,PersonelMail,PersonelAdres,PersonelDogumTarihi,PersonelMaas) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", MskTc.Text);
                        komut.Parameters.AddWithValue("@p2", TxtAd.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p3", CmbDep.Text);
                        komut.Parameters.AddWithValue("@p4", mskTel.Text);
                        komut.Parameters.AddWithValue("@p5", txtMail.Text);
                        komut.Parameters.AddWithValue("@p6", TxtAdres.Text);
                        komut.Parameters.AddWithValue("@p7", mskDogum.Text);
                        komut.Parameters.AddWithValue("@p8", mskMaas.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla eklendi");
                        //Yemekhane Görevli Sayısı
                        SqlCommand komut1 = new SqlCommand("Select Count(*) From Personel Where PersonelDepartman= 'Yemekhane'", sql.Baglan());
                        SqlDataReader dr1 = komut1.ExecuteReader();
                        while (dr1.Read())
                        {
                            lblYemekhane.Text = dr1[0].ToString();
                        }

                        ///Güvenlik Sayısı
                        SqlCommand komut2 = new SqlCommand("Select Count(*) From Personel Where PersonelDepartman ='Güvenlik'", sql.Baglan());
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        while (dr2.Read())
                        {
                            lblGuvenlik.Text = dr2[0].ToString();
                        }
                        SqlCommand komut3 = new SqlCommand("Select Count(*) From Personel Where PersonelDepartman ='Kat Görevlisi'", sql.Baglan());
                        SqlDataReader dr3 = komut3.ExecuteReader();
                        while (dr3.Read())
                        {
                            lblKatGorevlisi.Text = dr3[0].ToString();
                        }
                        MskTc.Text = "";
                        TxtAd.Text = "";
                        CmbDep.Text = "";
                        mskTel.Text = "";
                        txtMail.Text = "";
                        TxtAdres.Text = "";
                        mskDogum.Text = "";
                        mskMaas.Text = "";

                        sql.Baglan().Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu! Tekrar Deneyiniz");
            }
        }

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {
            //Yemekhane Görevli Sayısı
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Personel Where PersonelDepartman= 'Yemekhane'",sql.Baglan());
           SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblYemekhane.Text = dr1[0].ToString();
            }

            ///Güvenlik Sayısı
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Personel Where PersonelDepartman ='Güvenlik'",sql.Baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblGuvenlik.Text = dr2[0].ToString();
            }
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Personel Where PersonelDepartman ='Kat Görevlisi'", sql.Baglan());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblKatGorevlisi.Text = dr3[0].ToString();
            }


        }

       

        private void mskDogum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void mskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void mskDogum_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskTc_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void mskMaas_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void mskTel_Click(object sender, EventArgs e)
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
