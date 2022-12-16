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

namespace Yurt.Personel
{
    public partial class FrmPersonelSifreİslemleri : Form
    {
        public FrmPersonelSifreİslemleri()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text== txtSifreYeniden.Text)
            {

                SqlCommand komut = new SqlCommand("Update Personeller set PersonelSifre=@p1 where PersonelTc=@p2 ", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", txtSifre.Text);
                komut.Parameters.AddWithValue("@p2", mskTc.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgi", "Başarıyla Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql.Baglan().Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor !!");
                txtSifre.Text = "";
                txtSifreYeniden.Text = "";
            }
        }
    }
}
