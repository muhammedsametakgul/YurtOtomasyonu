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
    public partial class FrmGiderDuzenle : Form
    {
        public FrmGiderDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?","UYARI",MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (MskElektrik.Text != "" && MskDogalgaz.Text != "" && MskInternet.Text != "" && MskGida.Text != "" && MskPersonel.Text != "" && MskSu.Text != "" && MskDiger.Text != "" && MskTarih.Text != "")
                    {
                        SqlCommand komut = new SqlCommand("Update Giderler set Elektrik=@p1,Dogalgaz=@p2,Internet=@p3,Gida=@p4," +
                  "Personel=@p5,Su=@p6,Diger=@p7,GiderAy=@p8 where Odemeid=@p9", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", MskElektrik.Text);
                        komut.Parameters.AddWithValue("@p2", MskDogalgaz.Text);
                        komut.Parameters.AddWithValue("@p3", MskInternet.Text);
                        komut.Parameters.AddWithValue("@p4", MskGida.Text);
                        komut.Parameters.AddWithValue("@p5", MskPersonel.Text);
                        komut.Parameters.AddWithValue("@p6", MskSu.Text);
                        komut.Parameters.AddWithValue("@p7", MskDiger.Text);
                        komut.Parameters.AddWithValue("@p8", MskTarih.Text);
                        komut.Parameters.AddWithValue("@p9", lblid.Text);
                        MskElektrik.Text = "";
                        MskDogalgaz.Text = "";
                        MskInternet.Text = "";
                        MskGida.Text = "";
                        MskPersonel.Text = "";
                        MskSu.Text = "";
                        MskDiger.Text = "";
                        MskTarih.Text = "";

                        komut.ExecuteNonQuery();

                        MessageBox.Show("Başarıyla Güncellendi");
                        //Güncellendikten sonra tabloyu güncelliyor
                        SqlDataAdapter da = new SqlDataAdapter("Select * From Giderler", sql.Baglan());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.Columns[8].HeaderText = "Tarih";

                        sql.Baglan().Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oldu !  Lütfen Tekrar Deneyiniz");
            }

        }

        

        private void FrmGiderDuzenle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Giderler", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[8].HeaderText = "Tarih";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //iki kere tıklanınca tablodaki verileri textboxlara çekiyor
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskElektrik.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskDogalgaz.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskInternet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskGida.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskPersonel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskSu.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            MskDiger.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            MskTarih.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text != "")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Silmek İstediğinize Emin Misiniz? ", "UYARI", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Delete  Giderler Where Odemeid=@p1", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", lblid.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Silindi");
                        SqlDataAdapter da = new SqlDataAdapter("Select * From Giderler", sql.Baglan());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.Columns[8].HeaderText = "Tarih";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme İşlemi Yapılamadı.Lütfen Birini Seçtiğinize Emin Olunuz.");
            }
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Mudur Where mudurTc=@p1 and mudurSifre=@p2 ", sql.Baglan());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                btnSil.Visible = true;
                groupBox1.Visible = false;
                lblUyari.Text = "Silme İşlemi Yapabilirsiniz";
                lblUyari.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Yanlış Doğrulama Yaptınız veya Yetkiniz Yok!");
            }
        }
    }

  
}
