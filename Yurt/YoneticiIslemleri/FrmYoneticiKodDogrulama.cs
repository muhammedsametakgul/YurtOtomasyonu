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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;




namespace Yurt
{
    public partial class FrmYoneticiKodDogrulama : Form
    {
        public FrmYoneticiKodDogrulama()
        {
            InitializeComponent();
        }
        public string kod_disaridan_gelen;
        string kod_iceriden;
        string text_tc;
       
        private void FrmYoneticiKodDogrulama_Load(object sender, EventArgs e)
        {
            


        }

        Sql sql = new Sql();
        string kod;
        public string tc_kod;
        string email;
        private void button1_Click(object sender, EventArgs e)
        {

            kod_iceriden = textBox1.Text;
            

            if (kod_disaridan_gelen == kod_iceriden)
            {

                FrmYoneticiSifreGuncelle frm = new FrmYoneticiSifreGuncelle();
                frm.Show();
                this.Close();
                text_tc = label2.Text;
                MessageBox.Show(text_tc);
                FrmYoneticiSifreGuncelle frm2 = new FrmYoneticiSifreGuncelle();
                //frm2.tc_sifre_guncelleme = text_tc;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmYoneticiSifreİslemleri frm = new FrmYoneticiSifreİslemleri();
           
            SqlCommand komut = new SqlCommand("Select * From Admin where YoneticiTc =@p1", sql.Baglan());
            komut.Parameters.AddWithValue("@p1", tc_kod);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                email = dr[5].ToString();
                MailMessage mailmesaji2 = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                kod = RandomKod.RandomKodOlustur();

                istemci.Credentials = new System.Net.NetworkCredential("denememaili232323@gmail.com", "hoqpfbbjxjfcxluo");

                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mailmesaji2.To.Add(email);
                mailmesaji2.From = new MailAddress("denememaili232323@gmail.com");
                mailmesaji2.Subject = "Şifre Sıfırlama";
                mailmesaji2.Body = "Merhaba Sayın" + "Şifrenizi sıfırlamanız için doğrulama kodunuz: \n " + kod;
                istemci.Send(mailmesaji2);

                MessageBox.Show("Mail gönderildi");
                kod_disaridan_gelen = kod;

            }
            
        }
    }
}
