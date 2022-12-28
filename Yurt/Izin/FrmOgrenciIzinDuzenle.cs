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
    public partial class FrmOgrenciIzinDuzenle : Form
    {
        public FrmOgrenciIzinDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmIzinDuzenle_Load(object sender, EventArgs e)
        {
            Guncelle_Grid();
            
        }
        
        public  void Guncelle_Grid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Izinid,OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis From OgrenciIzin ORDER BY Baslangic ASC", sql.Baglan());

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "İzin ID";
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[3].HeaderText = "Sebep";
            dataGridView1.Columns[4].HeaderText = "Başlangıç";
            dataGridView1.Columns[5].HeaderText = "Bitiş";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            lblTc.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSebep.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            DateBas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            DateBit.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
       

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
               if(TxtSebep.Text != "")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?","UYARI",MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komut1 = new SqlCommand("Update OgrenciIzin set Sebep=@p1,Baslangic=@p2,Bitis=@p3 where Izinid=@p4", sql.Baglan());
                        komut1.Parameters.AddWithValue("@p1", TxtSebep.Text);
                        komut1.Parameters.AddWithValue("@p2", DateBas.Value.Date);
                        komut1.Parameters.AddWithValue("@p3", DateBit.Value.Date);
                        komut1.Parameters.AddWithValue("@p4", lblid.Text);
                        komut1.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Güncellendi");

                        Guncelle_Grid();
                        sql.Baglan().Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurunuz");
                }
            }
                
            catch(Exception exp)
            {
                MessageBox.Show("Bir Hata Oluştu ! Daha Sonra Tekrar Deneyiniz");
                MessageBox.Show(exp.Message);
               
            }

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string ara = txtArama.Text;
            SqlDataAdapter da = new SqlDataAdapter("select Izinid,OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where OgrenciAdSoyad LIKE '%" + ara + "%' ORDER BY Baslangic ASC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "İzin ID";
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[3].HeaderText = "Sebep";
            dataGridView1.Columns[4].HeaderText = "Başlangıç";
            dataGridView1.Columns[5].HeaderText = "Bitiş";




        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Silmek İStediğinize Emin Misiniz?","UYARI",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    if (lblid.Text != "")
                    {

                        SqlCommand komut = new SqlCommand("Delete From OgrenciIzin Where Izinid=@p1", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", lblid.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Silindi");
                        Guncelle_Grid();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bir Hücre Seçiniz");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Lütfen Bir Hücre Seçiniz");

                }
            }
        }
    }
}
