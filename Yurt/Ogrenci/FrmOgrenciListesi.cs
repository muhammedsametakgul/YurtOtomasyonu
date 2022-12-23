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
    public partial class FrmOgrenciListesi : Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
           
            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAd From Ogrenci", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAd from Ogrenci where OgrenciAd LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            lblTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * From Ogrenci Where OgrenciTc='"+lblTc.Text+"'",sql.Baglan());
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                //Kişisel Bilgiler
                TxtAd.Text = dr[2].ToString();
                MskDogum.Text = dr["OgrenciDogum"].ToString();
                MskTc.Text = dr["OgrenciTc"].ToString();
                txtBolum.Text = dr["OgrenciBolum"].ToString();
                txtDogum.Text = dr["DogduguYer"].ToString();
                CmbOda.Text = dr["OgrenciOdaNo"].ToString();

                //Veli Bilgileri
                txtVeliAd.Text = dr["VeliAd"].ToString();
                cmbYakin.Text = dr["VeliYakinlik"].ToString();
                MskVeliTel.Text = dr["VeliTel"].ToString();

                //İletişim Bilgileri
                txtIl.Text = dr["IlIlce"].ToString();
                rchAdres.Text = dr["OgrenciAdres"].ToString();
                TxtMail.Text = dr["OgrenciMail"].ToString();
                MskTel.Text = dr["OgrenciTelefon"].ToString();

            }
        }
    }
}
