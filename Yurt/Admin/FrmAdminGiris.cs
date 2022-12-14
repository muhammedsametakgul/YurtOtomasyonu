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
      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Admin Where YoneticiTc=@p1 and YoneticiSifre =@p2",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
                
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Admin.MainForm frm=new Admin.MainForm();
                frm.lblName.Text = dr[1].ToString();
                //frm.ad = dr[1].ToString();
                frm.Show();
                this.Hide();
                


            }
            else {
                MessageBox.Show("TC kimlik numarası veya şifre hatalıdır!!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                TxtKullaniciAd.Text = "";
                TxtSifre.Text = "";
            
            }
        
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        
    }
}
