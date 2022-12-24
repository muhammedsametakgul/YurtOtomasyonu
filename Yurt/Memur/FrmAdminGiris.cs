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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
       
       
        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TxtSifre.UseSystemPasswordChar = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void checkboxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxSifreGoster.Checked)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void FrmAdminGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaGiris a = new AnaGiris();
            a.Show();
        }
        public static string tc_memur;
        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Admin Where YoneticiTc=@p1 and YoneticiSifre =@p2", sql.Baglan());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Admin.MainForm frm = new Admin.MainForm();
                frm.lblName.Text = dr[1].ToString();
                frm.lblTc.Text = dr[3].ToString();
                //frm.ad = dr[1].ToString();
                frm.Show();
                tc_memur = TxtKullaniciAd.Text;
                //FrmAdmin a = new FrmAdmin();
                //a.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("TC kimlik numarası veya şifre hatalıdır!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtKullaniciAd.Text = "";
                TxtSifre.Text = "";

            }
        }
    }
}
