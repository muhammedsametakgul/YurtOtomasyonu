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

namespace Yurt.SifremiUnuttum
{
    public partial class FrmSifreUnuttum : Form
    {
        public FrmSifreUnuttum()
        {
            InitializeComponent();
        }
        Sql sql= new Sql();
       
        string kod2;
        string ad;
        private void btnDogrula_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailmesaji = new MailMessage();
                SmtpClient istemci = new SmtpClient();

                istemci.Credentials = new System.Net.NetworkCredential("denememaili232323@gmail.com", "hoqpfbbjxjfcxluo");
                SqlCommand komut2 = new SqlCommand("Select mudurEmail From Mudur Where MudurTc=@o1", sql.Baglan());
                komut2.Parameters.AddWithValue("@o1", mskTc.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    txtMail.Text = dr2[0].ToString();

                }
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mailmesaji.To.Add(txtMail.Text);
                mailmesaji.From = new MailAddress("denememaili232323@gmail.com");
                mailmesaji.Subject = "Ödeme Makbuz";
                SqlCommand komut = new SqlCommand("Select mudurAdSoyad From Mudur Where mudurTc=@p1", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", mskTc.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    ad = dr[0].ToString();
                }
                kod2 = RandomKod.RandomKodOlustur(); ;

                mailmesaji.Body = "Merhaba Sayın " + ad + "\nŞifrenizi Unuttuğunuz için Şifre Güncelleme Talebi Gönderdiniz.\nDoğrulama Kodunuz:" + kod2;
                istemci.Send(mailmesaji);
                groupBox2.Visible = true;
                groupBox1.Visible = false;
            }catch(Exception ex)
            {
                MessageBox.Show("Mail Gönderilemedi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if(kod2 == mskDogrulama.Text)
            {
                groupBox3.Visible = true;
                groupBox2.Visible=false;
                MessageBox.Show("Doğrulama Başarılı");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text == txtSifre2.Text)
            {
                SqlCommand komut = new SqlCommand("Update Mudur set mudurSifre=@p1 Where mudurTc=@p2", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", txtSifre.Text);
                komut.Parameters.AddWithValue("@p2", mskTcSifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellenmiştir");
                AnaGiris frm = new AnaGiris();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Şifrelerin Uyuştuğuna Emin Olunuz");
            }
        }

        private void FrmSifreUnuttum_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
        }

        private void FrmSifreUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
