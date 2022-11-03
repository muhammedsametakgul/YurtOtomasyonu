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
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }
        //Sql bağlantısı oluşturuldu
        Sql sql = new Sql();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("Select * From Personeller Where PersonelTc=@p1 and PersonelSifre=@p2",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string departman = dr[3].ToString();
                if (departman == "Yemekhane")
                {
                    FrmYemekhaneGorevli frm = new FrmYemekhaneGorevli();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    FrmPersonel frm = new FrmPersonel();
                    frm.Show();
                    this.Hide();

                }

            }
            else {

                MessageBox.Show("TC kimlik numarası veya şifre hatalıdır!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtKullaniciAd.Text = "";
                TxtSifre.Text = "";
            }
            sql.Baglan().Close();


        }

        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
