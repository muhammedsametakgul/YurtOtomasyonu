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

namespace Yurt.YoneticiIslemleri
{
    public partial class FrmPersonelDuzenle : Form
    {
      
        public FrmPersonelDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        //datagridviewi güncel tutuyor
        public void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,PersonelDepartman,PersonelTelefon,PersonelMail,PersonelAdres,PersonelDogumTarihi From Personel ORDER BY PersonelAdSoyad ASC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Departman";
            dataGridView1.Columns[3].HeaderText = "Telefon";
            dataGridView1.Columns[4].HeaderText = "E-Mail";
            dataGridView1.Columns[5].HeaderText = "Adres";
            dataGridView1.Columns[6].HeaderText = "Doğum Tarihi";

        }
        private void FrmPersonelDuzenle_Load(object sender, EventArgs e)
        {

            Goster();
        }
       
      

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dinamik olarak arıyor
            SqlDataAdapter da = new SqlDataAdapter("select  PersonelTc,PersonelAdSoyad,PersonelDepartman,PersonelTelefon,PersonelMail,PersonelAdres,PersonelDogumTarihi from Personel where PersonelAdSoyad LIKE '%" + txtAra.Text + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Departman";
            dataGridView1.Columns[3].HeaderText = "Telefon";
            dataGridView1.Columns[4].HeaderText = "E-Mail";
            dataGridView1.Columns[5].HeaderText = "Adres";
            dataGridView1.Columns[6].HeaderText = "Doğum Tarihi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MskTc.Text!="" && TxtAd.Text!="" && CmbDep.Text!="" && mskTel.Text!="" && TxtAdres.Text!="" )
                {

                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Güncelleme Yapmak İstediğinize Emin Misiniz?","UYARI",MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Update Personel set  PersonelTc=@p1,PersonelAdSoyad=@p2," +
                 "PersonelDepartman=@p3,PersonelTelefon=@p4,PersonelMail=@p5,PersonelAdres=@p6,PersonelDogumTarihi=@p7 where Personelid=@p8", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", MskTc.Text);
                        komut.Parameters.AddWithValue("@p2", TxtAd.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p3", CmbDep.Text);
                        komut.Parameters.AddWithValue("@p4", mskTel.Text);
                        komut.Parameters.AddWithValue("@p5", txtMail.Text);

                        komut.Parameters.AddWithValue("@p6", TxtAdres.Text);
                        komut.Parameters.AddWithValue("@p7",mskDogum.Text);
                        komut.Parameters.AddWithValue("@p8", lblid.Text);

                        TxtAd.Text = "";
                        MskTc.Text = "";
                        CmbDep.Text = "";

                        mskDogum.Text = "";
                        mskTel.Text = "";
                        TxtAdres.Text = "";
                        txtMail.Text = "";

                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla güncellendi");
                        Goster();
                        sql.Baglan().Close();
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
                }

                
               
            }catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu! Tekrar Deneyiniz");
            }
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MskTc.Text != "")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Silmek İstediğinize Emin Misiniz?","UYARI",MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Delete Personel  where PersonelTc =@p1", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", MskTc.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla silindi");
                        TxtAd.Text = "";
                        MskTc.Text = "";
                        CmbDep.Text = "";

                        mskDogum.Text = "";
                        mskTel.Text = "";
                        TxtAdres.Text = "";
                        txtMail.Text = "";
                        Goster();

                        sql.Baglan().Close();
                    }

                }
                else
                {
                   MessageBox.Show("Lütfen Bir Kişi Seçtiğinize Emin Olunuz!! ");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu! Lütfen Tekrar Deneyiniz");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
          
            MskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbDep.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            mskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
         

            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskDogum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            SqlCommand komut = new SqlCommand("Select Personelid From Personel Where PersonelTc=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblid.Text = dr[0].ToString();
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbDep.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            mskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();


            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskDogum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            SqlCommand komut = new SqlCommand("Select Personelid From Personel Where PersonelTc=@p1", sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblid.Text = dr[0].ToString();
            }
        }

   
    }
    }

