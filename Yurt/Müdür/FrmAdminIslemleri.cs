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

namespace Yurt.Müdür
{
    public partial class FrmAdminIslemleri : Form
    {
        public FrmAdminIslemleri()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void FrmYoneticiEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select YoneticiAdSoyad,YoneticiTc,YoneticiEmail,YoneticiTelefon from Admin",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);    
            dataGridView1.DataSource= dt;
            dataGridView1.RowHeadersVisible = false;
             dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[0].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[2].HeaderText = "E-Mail";
            dataGridView1.Columns[3].HeaderText = "Telefon";
       

        }

     
        public  void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select YoneticiAdSoyad,YoneticiTc,YoneticiEmail,YoneticiTelefon from Admin", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[0].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[2].HeaderText = "E-Mail";
            dataGridView1.Columns[3].HeaderText = "Telefon";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAd.Text !="" && mskTc.Text != "" && txtEmail.Text!="" && txtSifre.Text!= "" && mskTel.Text != "")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Eklemek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Insert into Admin (YoneticiAdSoyad,YoneticiTc,YoneticiEmail,YoneticiSifre,YoneticiTelefon) Values (@p1,@p2,@p3,@p4,@p5)", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());

                        komut.Parameters.AddWithValue("@p2", mskTc.Text);
                        komut.Parameters.AddWithValue("@p3", txtEmail.Text);
                        komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                        komut.Parameters.AddWithValue("@p5", mskTel.Text);
                        komut.ExecuteNonQuery();
                        Goster();
                        txtAd.Clear();
                        mskTc.Clear();
                        txtEmail.Clear();
                        txtSifre.Clear();
                        mskTel.Clear();
                        MessageBox.Show("Başarıyla Eklendi.Memur Maaşını Belirlemek İçin Maaş Sekmesine Gidiniz!!!!");
                       
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğuza Emin Olunuz");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oldu !  Lütfen Tekrar Deneyiniz");
            
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
        }

       

        private void mskTc_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
