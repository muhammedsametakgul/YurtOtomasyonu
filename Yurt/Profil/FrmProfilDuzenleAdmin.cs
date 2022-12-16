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
    public partial class FrmProfilDuzenleAdmin : Form
    {
        public FrmProfilDuzenleAdmin()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmProfilDuzenleAdmin_Load(object sender, EventArgs e)

            
        {
            timer1.Start();
            FrmAdminGiris frm= new FrmAdminGiris();

            string a= frm.TxtKullaniciAd.Text;
            SqlCommand komut = new SqlCommand("Select * From Admin where YoneticiTc=@p1",sql.Baglan());
            komut.Parameters.Add("@p1", a);
            SqlDataReader dr =komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTc.Text = dr[3].ToString();
                txtSifre.Text = dr[4].ToString();
                txtEmail.Text = dr[5].ToString();
              
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
      
        
    }
}
