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

namespace Yurt.Personel
{
    public partial class FrmMaasİslemleri : Form
    {
        public FrmMaasİslemleri()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
        Sql sql = new Sql();
        private void FrmPersonelMaasIslemleri_Load(object sender, EventArgs e)
        {
            lblUyari.ForeColor = Color.Red;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Güncellemek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
             
             
              if(rbMemur.Checked)
                {
                    SqlCommand komut1 = new SqlCommand("Update Admin set YoneticiMaas=@p1 where YoneticiTc=@p2 ", sql.Baglan());
                    komut1.Parameters.AddWithValue("@p1", mskMaas.Text);
                    komut1.Parameters.AddWithValue("@p2", mskTc.Text);
                    komut1.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter("Select YoneticiTc,YoneticiAdSoyad,YoneticiMaas From Admin ", sql.Baglan());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Başarıyla Güncellendi");
                    mskMaas.Text = "";
                    mskTc.Text = "";
                    txtAd.Text = "";
                }
                if (rbPersonel.Checked)
                {
                    SqlCommand komut2 = new SqlCommand("Update Personel set PersonelMaas=@p1 where PersonelTc=@p2 ", sql.Baglan());
                    komut2.Parameters.AddWithValue("@p1", mskMaas.Text);
                    komut2.Parameters.AddWithValue("@p2", mskTc.Text);
                    komut2.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,PersonelMaas From Personel ", sql.Baglan());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Başarıyla Güncellendi");
                    mskMaas.Text = "";
                    mskTc.Text = "";
                    txtAd.Text = "";

                }
                sql.Baglan().Close();
            }
        }

        private void rbMemur_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMemur.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select YoneticiTc,YoneticiAdSoyad,YoneticiMaas From Admin ", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "TC";
                dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
                dataGridView1.Columns[2].HeaderText = "Maaş";
            }
        }

        private void rbPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPersonel.Checked) {
                SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,PersonelMaas From Personel ", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "TC";
                dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
                dataGridView1.Columns[2].HeaderText = "Maaş";
            }
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Mudur Where mudurTc=@p1 and mudurSifre=@p2 ",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",mskTCMudur.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblUyari.Text = "Başarıyla Doğrulandı";
                lblUyari.ForeColor = Color.Green;
                groupBox2.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Girdiğinizden Emin Olunuz!!");
            }
            sql.Baglan().Close();

           
        }

      
    }
}
