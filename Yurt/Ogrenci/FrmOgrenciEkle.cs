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

namespace Yurt
{
    public partial class FrmOgrenciEkle : Form
    {
        public FrmOgrenciEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Boş odaları gösterme
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif",sql.Baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CmbOda.Items.Add(dr2[0].ToString());
            }

            //Yurt Ucreti  Çekme
            string ucret;
            SqlCommand komutCekme = new SqlCommand("Select YurtUcreti From YurtUcreti where Aktifmi=1 ",sql.Baglan());
            SqlDataReader dr = komutCekme.ExecuteReader();
            if (dr.Read())
            {
                txtYurtUcreti.Text = dr[0].ToString();
            }

        }

      

      

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBolum.Clear();
            cmbDogdugu.Text = "";
            cmbYasadigi.Text = "";
            MskTc.Text = "";
            MskTel.Text = "";
            rchAdres.Text = "";
            txtVeliAd.Text = "";
            TxtAd.Text = "";
            TxtMail.Text = "";
            MskDogum.Text = "";
            cmbYakin.Text = "";
            CmbOda.Text = "";
            txtVeliAd.Text = "";
          
            MskVeliTel.Text = "";

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && MskDogum.Text != "" && MskTc.Text != "" && TxtMail.Text != "" && MskTel.Text != "" && CmbOda.Text != "" && rchAdres.Text != "" && MskVeliTel.Text != "" && txtVeliAd.Text != "" && cmbYakin.Text != "" && cmbYasadigi.Text != "" && cmbDogdugu.Text != "")
            {
                DialogResult dialogResult = DialogResult.OK;
                dialogResult = MessageBox.Show("Eklemek istediğinize emin misiniz?","UYARI",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        //Öğrenci Eklemek
                        string bolum = txtBolum.Text.Trim().ToUpper();
                        SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrenciAd,OgrenciDogum,OgrenciTc,OgrenciBolum," +
                            "OgrenciMail,OgrenciTelefon,OgrenciOdaNo,OgrenciAdres,VeliTel,VeliAd,VeliYakinlik,IlIlce,Dogduguyer) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", sql.Baglan());

                        komut.Parameters.AddWithValue("@p1", TxtAd.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p2", MskDogum.Text);
                        komut.Parameters.AddWithValue("@p3", MskTc.Text);
                        komut.Parameters.AddWithValue("@p4", bolum.ToUpper());
                        komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                        komut.Parameters.AddWithValue("@p6", MskTel.Text);
                        komut.Parameters.AddWithValue("@p7", CmbOda.Text);
                        komut.Parameters.AddWithValue("@p8", rchAdres.Text);
                        komut.Parameters.AddWithValue("@p9", MskVeliTel.Text);
                        komut.Parameters.AddWithValue("@p10", txtVeliAd.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p11", cmbYakin.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p12", cmbYasadigi.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p13", cmbDogdugu.Text.ToUpper());

                        komut.ExecuteNonQuery();


                        //Odadaki aktif kalan kişi sayısını arttırmak
                        SqlCommand komut2 = new SqlCommand("Update Odalar set OdaAktif =OdaAktif+1 where OdaNo=@h1", sql.Baglan());
                        komut2.Parameters.AddWithValue("@h1", CmbOda.Text);
                        komut2.ExecuteNonQuery();
                        MessageBox.Show("Öğrenci Eklendi");



                        SqlCommand komut3 = new SqlCommand("insert into Borclar1 (OgrenciTc,OgrenciAd,OgrenciMail,OgrenciTel,OgrenciKalanBorc) " +
                            "values (@b1,@b2,@b3,@b4,@b5)", sql.Baglan());
                        komut3.Parameters.AddWithValue("@b1", MskTc.Text);
                        komut3.Parameters.AddWithValue("@b2", TxtAd.Text);

                        komut3.Parameters.AddWithValue("b3", TxtMail.Text);
                        komut3.Parameters.AddWithValue("@b4", MskTel.Text);
                        komut3.Parameters.AddWithValue("b5", txtYurtUcreti.Text);
                        komut3.ExecuteNonQuery();


                        txtBolum.Clear();
                        cmbDogdugu.Text = "";
                        cmbYasadigi.Text = "";
                        MskTc.Text = "";
                        MskTel.Text = "";
                        rchAdres.Text = "";
                        txtVeliAd.Text = "";
                        TxtAd.Text = "";
                        TxtMail.Text = "";
                        MskDogum.Text = "";
                        cmbYakin.Text = "";
                        CmbOda.Text = "";
                        txtVeliAd.Text = "";
                       
                        MskVeliTel.Text = "";
                        sql.Baglan().Close();


                    }
                    catch (Exception exp)
                    {
                        DialogResult d = new DialogResult();
                        d = MessageBox.Show("Öğrenci Eklenemedi.Veritabanlı sıkıntı olabilir bekleyiniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
        }


        private void MskDogum_Click_1(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskTc_Click_1(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskVeliTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskVeliTel_Click_1(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskTel_Click_1(object sender, EventArgs e)
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
