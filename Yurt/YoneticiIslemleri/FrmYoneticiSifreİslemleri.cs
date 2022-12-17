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
using Yurt.YoneticiIslemleri;

namespace Yurt
{
    public partial class FrmYoneticiSifreİslemleri : Form
    {
        public FrmYoneticiSifreİslemleri()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        string email;
        string ad;
        public string kod;
        string tc;
       


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Admin where YoneticiTc =@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            FrmYoneticiKodDogrulama frm = new FrmYoneticiKodDogrulama();

            //YoneticiSifreGuncelle frm2 = new YoneticiSifreGuncelle();
            //frm2.tc_sifre_guncelleme = MskTC.Text;
            //frm.label2.Text=MskTC.Text;

            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                
                
              
               
                
                email = dr[5].ToString();
                ad = dr[1].ToString();
               frm.tc_kod=MskTC.Text;
               
                
                MailMessage mailmesaji = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                 kod = RandomKod.RandomKodOlustur();
                frm.kod_disaridan_gelen = kod;
                istemci.Credentials = new System.Net.NetworkCredential("denememaili232323@gmail.com", "hoqpfbbjxjfcxluo");

                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mailmesaji.To.Add(email);
                mailmesaji.From = new MailAddress("denememaili232323@gmail.com");
                mailmesaji.Subject = "Şifre Sıfırlama";
                mailmesaji.Body = "Merhaba Sayın" + " " + ad +"Şifrenizi sıfırlamanız için doğrulama kodunuz: \n "+kod;
                istemci.Send(mailmesaji);

                MessageBox.Show("Mail gönderildi");
               
                this.Close();
              
               
                frm.ShowDialog();
               
            }
            sql.Baglan().Close();
        }

        private void FrmYoneticiSifreİslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
