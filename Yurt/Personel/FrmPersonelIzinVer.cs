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
using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors;

namespace Yurt
{
    public partial class FrmPersonelIzinVer : Form
    {
        public FrmPersonelIzinVer()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskTc.Text !="" && txtAdSoyad.Text!="" && txtSebep.Text!="" )
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Insert into PersonelIzin (PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman) Values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", mskTc.Text);
                        komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@p3", txtSebep.Text);
                        komut.Parameters.AddWithValue("@p4", dtBas.Value.Date);
                        komut.Parameters.AddWithValue("@p5", dtBit.Value.Date);
                        if (rbMemur.Checked)
                        {
                            komut.Parameters.AddWithValue("@p6", rbMemur.Text);
                        }
                        if (rbPersonel.Checked)
                        {
                            komut.Parameters.AddWithValue("@p6", rbPersonel.Text);
                        }
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla İzin EKlendi");
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal edildi");
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
                MessageBox.Show(ex.Message);
            }
       
            

        }
        public void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad from Personel ", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            dgvGoster.Columns[1].HeaderText = "Ad-Soyad";
            dgvGoster.Columns[0].HeaderText = "TC";
       
        }
      
        private void FrmPersonelIzinVer_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvGoster.SelectedCells[0].RowIndex;

            mskTc.Text = dgvGoster.Rows[secilen].Cells[0].Value.ToString();
            txtAdSoyad.Text = dgvGoster.Rows[secilen].Cells[1].Value.ToString();
        }

        private void rbPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPersonel.Checked)
            {
                Goster();
            }
        }

        private void rbMemur_CheckedChanged(object sender, EventArgs e)
        {
         if(rbMemur.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select YoneticiTc,YoneticiAdSoyad from Admin", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGoster.DataSource = dt;
                dgvGoster.Columns[1].HeaderText = "Ad-Soyad";
                dgvGoster.Columns[0].HeaderText = "TC";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
