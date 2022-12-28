using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.Müdür;
using System.Data.SqlClient;

namespace Yurt
{
    public partial class FrmProfilDuzenle : Form
    {
        public FrmProfilDuzenle()
        {
            InitializeComponent();
        }
        string tc;
        Sql sql = new Sql();
        private void FrmProfilDuzenle_Load(object sender, EventArgs e)
        {
            tc = FrmMudurAnaSayfa.tcAna;
            SqlCommand komut = new SqlCommand("Select * From Mudur Where mudurTc=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",tc);
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                label5.Text = dr[0].ToString();
                txtAd.Text = dr[2].ToString();
                mskTc.Text = dr[1].ToString();
                txtMail.Text = dr[5].ToString();
                    mskTel.Text = dr[6].ToString();
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?","UYARI",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update Mudur Set mudurTc=@p1,mudurAdSoyad=@p2,mudurEmail=@p3,mudurTel=@p4 Where mudurid=@p5", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", mskTc.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", txtMail.Text);
                komut.Parameters.AddWithValue("@p4", mskTel.Text);
                komut.Parameters.AddWithValue("@p5", label5.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Profiliniz Başarıyla Güncellendi");
            }
        }
    }
}
