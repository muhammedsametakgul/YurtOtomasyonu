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
            SqlDataAdapter da = new SqlDataAdapter("Select * From Borclar1",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kalanBorc,odenen,yeniBorc;
            kalanBorc = Convert.ToInt32(label6.Text);
            odenen=Convert.ToInt32(TxtOdenen.Text);
            yeniBorc = kalanBorc - odenen;
            label6.Text = yeniBorc.ToString();
            //borçları güncelleme
            SqlCommand komut1 = new SqlCommand("Update Borclar1 set OgrenciKalanBorc=@p1 where OgrenciTc=@p2",sql.Baglan());
            komut1.Parameters.AddWithValue("@p1",label6.Text);
            komut1.Parameters.AddWithValue("@p2",MskTc.Text);
            MessageBox.Show("Borç Güncellendi");
            komut1.ExecuteNonQuery();


            //gelirler tablosuna ekleme
            SqlCommand komut2 = new SqlCommand("insert into Gelir (OdemeTarih,OdemeMiktar,Odeyen) values(@o1,@o2,@o3)", sql.Baglan());
            string ad = TxtAd.Text;
            komut2.Parameters.AddWithValue("@o1", MskOdemeTarih.Text);
            komut2.Parameters.AddWithValue("@o2", TxtOdenen.Text);
            komut2.Parameters.AddWithValue("@o3", ad);
            komut2.ExecuteNonQuery();

            MailMessage mailmesaji = new MailMessage();
            SmtpClient istemci = new SmtpClient();

            istemci.Credentials = new System.Net.NetworkCredential("denememaili232323@gmail.com", "hoqpfbbjxjfcxluo");

            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mailmesaji.To.Add(label7.Text);
            mailmesaji.From = new MailAddress("denememaili232323@gmail.com");
            mailmesaji.Subject = "Ödeme Makbuz";
            mailmesaji.Body = "Merhaba Sayın" + " " + TxtAd.Text + ". \n "+MskOdemeTarih.Text+" tarihinde "+TxtOdenen.Text+
                " tutarında borç ödediniz."+"Kalan Borcunuz: "+ label6.Text+" \n Yurt Yönetimi";
            istemci.Send(mailmesaji);
            
            MessageBox.Show("Mail gönderildi");

          
           
            sql.Baglan().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            label6.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            label7.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string arancakKisi = TxtArama.Text;

            SqlDataAdapter adaptor = new SqlDataAdapter("select * from Borclar1 where OgrenciAd LIKE '%" + arancakKisi + "%'", sql.Baglan()) ;
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Baglan().Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
