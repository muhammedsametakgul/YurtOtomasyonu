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
using System.Net.Mail;

namespace Yurt
{
    public partial class FrmOgrenciOdemeAl : Form
    {
        public FrmOgrenciOdemeAl()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmOgrenciOdemeAl_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAd From Ogrenci ORDER BY OgrenciAd ASC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "TC Kimlik NO";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
          



        }
        //Borç ödendikten sonra tabloda güncelleme yapıyor
        private void button1_Click(object sender, EventArgs e)
        {

            if (MskTc.Text != "")
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("Borç Güncellemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        int kalanBorc, odenen, yeniBorc;
                        kalanBorc = Convert.ToInt32(mskKalan.Text);
                        odenen = Convert.ToInt32(TxtOdenen.Text);
                        if (odenen <= kalanBorc)
                        {
                            yeniBorc = kalanBorc - odenen;
                            label6.Text = yeniBorc.ToString();
                            //borçları güncelleme
                            SqlCommand komut1 = new SqlCommand("Update Borclar1 set OgrenciKalanBorc=@p1 where OgrenciTc=@p2", sql.Baglan());
                            komut1.Parameters.AddWithValue("@p1", yeniBorc);
                            komut1.Parameters.AddWithValue("@p2", MskTc.Text);
                            MessageBox.Show("Borç Güncellendi");
                            komut1.ExecuteNonQuery();


                            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAd From Ogrenci ORDER BY OgrenciAd ASC", sql.Baglan());
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            cbGoster.Checked = false;
                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.Columns[0].HeaderText = "TC Kimlik NO";
                            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";


                            ////gelirler tablosuna ekleme

                            SqlCommand komut2 = new SqlCommand("insert into Gelir (Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar) values (@o1,@o2,@o3,@o4,@o5)", sql.Baglan());

                            komut2.Parameters.AddWithValue("@o1", TxtAd.Text);
                            komut2.Parameters.AddWithValue("@o2", lblTel.Text);
                            komut2.Parameters.AddWithValue("@o3", lblMail.Text);
                            komut2.Parameters.AddWithValue("@o4", dtOdeme.Value.Date);
                            komut2.Parameters.AddWithValue("@o5", TxtOdenen.Text);
                            komut2.ExecuteNonQuery();


                            try
                            {
                                MailMessage mailmesaji = new MailMessage();
                                SmtpClient istemci = new SmtpClient();

                                istemci.Credentials = new System.Net.NetworkCredential("denememaili232323@gmail.com", "hoqpfbbjxjfcxluo");

                                istemci.Port = 587;
                                istemci.Host = "smtp.gmail.com";
                                istemci.EnableSsl = true;
                                mailmesaji.To.Add(lblMail.Text);
                                mailmesaji.From = new MailAddress("denememaili232323@gmail.com");
                                mailmesaji.Subject = "Ödeme Makbuz";
                                mailmesaji.Body = "Merhaba Sayın" + " " + TxtAd.Text + ". \n " + dtOdeme.Text + " tarihinde " + TxtOdenen.Text +
                                    " tutarında borç ödediniz." + "Kalan Borcunuz: " + label6.Text + " \n Yurt Yönetimi";
                                istemci.Send(mailmesaji);

                                MessageBox.Show("Mail Olarak Ödeme Bilgileriniz Gönderilmiştir");

                                TxtAd.Text = "";
                                TxtOdenen.Text = "";
                                mskKalan.Text = "";
                                MskTc.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Ediniz!");
                            }



                            sql.Baglan().Close();

                        }
                        else
                        {
                            MessageBox.Show("Mevcut Borcunuzdan daha fazla para ödeyemezsiniz");
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Ödeme Yapılamadı!!! Lütfen Borcunuzdan Fazla Tutar Girmeyiniz!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kişi Seçtiğinize Emin Olunuz");
            }


        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string arancakKisi = TxtArama.Text.Trim();
            SqlDataAdapter adaptor = new SqlDataAdapter("select OgrenciTc,OgrenciAd from Ogrenci where OgrenciAd LIKE '%" + arancakKisi + "%' ORDER BY OgrenciAd ASC", sql.Baglan());
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "TC Kimlik NO";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            sql.Baglan().Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            

            SqlCommand komut2 = new SqlCommand("Select OgrenciKalanBorc,OgrenciTel From Borclar1 Where OgrenciTc=@p1", sql.Baglan());
            komut2.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                mskKalan.Text = dr2[0].ToString();
                lblTel.Text= dr2[1].ToString();

            }


            SqlCommand komut = new SqlCommand("Select OgrenciMail From Borclar1 Where OgrenciTc=@p1", sql.Baglan());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblMail.Text = dr[0].ToString();
            }
        }

        private void TxtArama_Click(object sender, EventArgs e)
        {
            
        }

        private void cbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if(cbGoster.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAd,OgrenciKalanBorc From Borclar1",sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);    
                dataGridView1.DataSource= dt;
                dataGridView1.Columns[0].HeaderText = "TC Kimlik NO";
                dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
                dataGridView1.Columns[2].HeaderText = "Kalan Borç";
   
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAd From Ogrenci ORDER BY OgrenciAd ASC", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}

