using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yurt.Müdür
{
    public partial class FrmAdminİslemleriGuncelleme : Form
    {
        public FrmAdminİslemleriGuncelleme()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {   if(txtAd.Text!="" && mskTc.Text!="" && txtEmail.Text!="" && mskTel.Text!="")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komutGuncelle = new SqlCommand("Update Admin Set YoneticiAdSoyad=@p1,YoneticiTc=@p2,YoneticiEmail=@p3 ,YoneticiTelefon=@p4 where Yoneticiid=@p5", sql.Baglan());
                        komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());

                        komutGuncelle.Parameters.AddWithValue("@p2", mskTc.Text);
                        komutGuncelle.Parameters.AddWithValue("@p3", txtEmail.Text);
                        komutGuncelle.Parameters.AddWithValue("@p4", mskTel.Text);
                        komutGuncelle.Parameters.AddWithValue("@p5", lblid.Text);
                        komutGuncelle.ExecuteNonQuery();
                        Goster();
                        txtAd.Text = "";
                        mskTc.Text = "";
                        txtEmail.Text = "";
                        mskTel.Text = "";
                        MessageBox.Show("Başarıyla Güncellendi");

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen güncellemek için birini seçiniz !");
                
            }
        }
        public void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select YoneticiAdSoyad,YoneticiTc,YoneticiEmail,YoneticiTelefon from Admin", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAd.Text!="" && mskTc.Text != "")
                {
                    DialogResult d2 = new DialogResult();
                    d2 = MessageBox.Show("Silmek istediğnize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);
                    if (d2 == DialogResult.Yes)
                    {
                        SqlCommand komutSil = new SqlCommand("Delete Admin where Yoneticiid=@p1", sql.Baglan());
                        komutSil.Parameters.AddWithValue("@p1", lblid.Text);
                        komutSil.ExecuteNonQuery();
                        Goster();
                        txtAd.Text = "";
                        mskTc.Text = "";
                        txtEmail.Text = "";
                        mskTel.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Öncelikle Birini Seçiniz");
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek için birini seçiniz");
            }
        }

        private void FrmAdminİslemleriGuncelleme_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select YoneticiAdSoyad,YoneticiTc,YoneticiEmail,YoneticiTelefon from Admin", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();    

            SqlCommand komut = new SqlCommand("Select Yoneticiid from Admin where YoneticiTc=@p1", sql.Baglan());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblid.Text = dr[0].ToString();
            }
        }

        private void telef(object sender, EventArgs e)
        {

        }
    }
}
