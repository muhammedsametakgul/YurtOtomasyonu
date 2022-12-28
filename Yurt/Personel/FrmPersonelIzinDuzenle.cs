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
    public partial class FrmPersonelIzinDuzenle : Form
    {
        public FrmPersonelIzinDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmPersonelIzinDuzenle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From PersonelIzin ORDER BY Baslangic DESC", sql.Baglan()) ;
            DataTable dt= new DataTable();  
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "İzin ID";
            dataGridView1.Columns[2].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[3].HeaderText = "Sebep";
            dataGridView1.Columns[4].HeaderText = "Başlangıç";
            dataGridView1.Columns[5].HeaderText = "Bitiş";
            dataGridView1.Columns[6].HeaderText = "Departman";
            


        }
        public void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From PersonelIzin ORDER BY Baslangic DESC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "İzin ID";
            dataGridView1.Columns[2].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[3].HeaderText = "Sebep";
            dataGridView1.Columns[4].HeaderText = "Başlangıç";
            dataGridView1.Columns[5].HeaderText = "Bitiş";
            dataGridView1.Columns[6].HeaderText = "Departman";
        }
       
        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSebep.Text != "")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komutGuncelle = new SqlCommand("Update PersonelIzin  SET Sebep=@p1,Baslangic=@p2,Bitis=@p3 where Izinid=@p4 ", sql.Baglan());
                        komutGuncelle.Parameters.AddWithValue("@p1", txtSebep.Text);
                        komutGuncelle.Parameters.AddWithValue("@p2", dtBas.Value.Date);
                        komutGuncelle.Parameters.AddWithValue("@p3", dtBit.Value.Date);
                        komutGuncelle.Parameters.AddWithValue("@p4", lblid.Text);
                        komutGuncelle.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Güncellendi");

                        Goster();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kişi Seçtiğinize Emin Olunuz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu! Lütfen Tekrar Deneyiniz");
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (lblid.Text != "")
            {
                try
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand komutSil = new SqlCommand("Delete PersonelIzin where Izinid=@d1", sql.Baglan());
                        komutSil.Parameters.AddWithValue("@d1", lblid.Text);
                        komutSil.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Silindi");


                        Goster();
                    }
                }catch(Exception ee)
                {
                    MessageBox.Show("Lütfen Önce Birini Seçiniz");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Hücre Seçtiğinize Emin Olunuz");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                mskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtSebep.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                dtBas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                dtBit.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
