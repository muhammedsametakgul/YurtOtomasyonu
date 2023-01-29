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

namespace Yurt.Gelir
{
    public partial class FrmGelirDuzenle : Form
    {
        public FrmGelirDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void FrmGelirDuzenle_Load(object sender, EventArgs e)
        {
            //Form yüklenince Datagridviewe bilgiler çekildi
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Gelir ORDER BY OdemeTarih DESC",sql.Baglan());
            DataTable dt= new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "Ödeme ID";
            dataGridView1.Columns[1].HeaderText = "Ödeyen Kişi";
            dataGridView1.Columns[2].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[3].HeaderText = "Mail";
            dataGridView1.Columns[4].HeaderText = "Tarih";
            dataGridView1.Columns[5].HeaderText = "Ödeme Miktar";
            dataGridView1.Columns[6].HeaderText = "Firma Adı";


        }
        public void Goster()
        {
            //işlemler sonrası datagridview güncel olması için bir metot
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Gelir", sql.Baglan());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        
        private void rbFirma_CheckedChanged(object sender, EventArgs e)
        {
            //firma varsa firma text kutucuğu visible oluyor
            txtFirma.Visible = true; lblFirma.Visible = true;
            txtFirma.Text = "";
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            //firma seçilmeyip bireysel seçildiyse firma text kutucuğu invisible oluyor
            txtFirma.Visible = false; lblFirma.Visible = false;
            txtFirma.Text = "Bireysel";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //sisteme eklemek için 
            try
            {
                if (txtOdeyenKisi.Text != "" && mskTel.Text != "" && txtEmail.Text != "" && dtTarih.Text != "" && txtOdenen.Text != "" && txtFirma.Text != "" && lblid.Text != "")
                {
                    DialogResult d = new DialogResult();
                d = MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?","Uyarı",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    
                        SqlCommand komut = new SqlCommand("Update Gelir set Odeyen=@p1,OdeyenTelefon=@p2,OdeyenMail=@p3,OdemeTarih=@p4,OdemeMiktar=@p5,FirmaAdi=@p6 where Odemeid=@p7", sql.Baglan()); ;
                        komut.Parameters.AddWithValue("@p1", txtOdeyenKisi.Text);
                        komut.Parameters.AddWithValue("@p2", mskTel.Text);
                        komut.Parameters.AddWithValue("@p3", txtEmail.Text);
                        komut.Parameters.AddWithValue("@p4", dtTarih.Value.Date);
                        komut.Parameters.AddWithValue("@p5", txtOdenen.Text);
                        komut.Parameters.AddWithValue("@p6", txtFirma.Text);
                        komut.Parameters.AddWithValue("@p7", lblid.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla güncellendi");
                        Goster();
                        txtOdeyenKisi.Clear();
                        mskTel.Clear();
                        txtEmail.Clear();
                        txtOdenen.Clear();
                        txtFirma.Clear();
                        sql.Baglan().Close();
                    }else
                    {
                        MessageBox.Show("Lütfen Tüm Bilgileri Eksiksiz Giriniz");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oldu Sanırım! Tekrar Deneyiniz");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridviewden tıklandığında bilgileri çekmek için kullanıldı
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOdeyenKisi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dtTarih.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtOdenen.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            SqlCommand komut1 = new SqlCommand("Select * From Gelir Where Odemeid=@p1", sql.Baglan());
            komut1.Parameters.AddWithValue("@p1",lblid.Text);
            rbFirma.Checked = false;
            rbBireysel.Checked = false;
            txtFirma.Visible = true;
            lblFirma.Visible = true;
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                if (dr[6].ToString() != "Bireysel")
                {
                    txtFirma.Visible = true;
                    lblFirma.Visible = true;
                    rbFirma.Checked = true;
                    txtFirma.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                   
                }
                else
                {
                    rbBireysel.Checked = true;
                    txtFirma.Visible = false;
                    lblFirma.Visible = false;
                }

            }

        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
            //silme işlemi
            try
            {   
                if(lblid.Text != "")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Silmek İstediğinize Emin Misiniz?","Uyarı",MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Delete Gelir Where Odemeid=@p1", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", lblid.Text);
                        komut.ExecuteNonQuery();
                        sql.Baglan().Close();
                        MessageBox.Show("Silme İşlemi Başarılı");
                        txtOdeyenKisi.Clear();
                        mskTel.Clear();
                        txtEmail.Clear();
                        txtOdenen.Clear();
                        txtFirma.Clear();
                       DateTime simdi =DateTime.Now;
                        dtTarih.Text = simdi.ToShortDateString();
                        Goster();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kişi Seçtiğinize Emin Olunuz");
                }

            }catch(Exception ex)
            {

                MessageBox.Show("Lütfen Bir Kişi Seçtiğinize Emin Olunuz");
            }
        }
    }
}
