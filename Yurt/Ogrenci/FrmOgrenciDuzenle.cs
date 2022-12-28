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
    public partial class FrmOgrenciDuzenle : Form
    {
        public FrmOgrenciDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
    
       
        
        private void FrmOgrenciDuzenle_Load(object sender, EventArgs e)
        {
            
                SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc as TC ,OgrenciAd as Ad, OgrenciBolum as Bölüm,OgrenciMail as Mail,OgrenciTelefon as Telefon,OgrenciOdaNo as Oda  From Ogrenci", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Baglan().Close();
            dataGridView1.RowHeadersVisible = false;


            //Boş odaları gösterme
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", sql.Baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CmbOda.Items.Add(dr2[0].ToString());
            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MskTc.Text.Length != 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Delete Ogrenci  where OgrenciTc =@p1", sql.Baglan());
                        komut.Parameters.AddWithValue("@p1", MskTc.Text);
                        komut.ExecuteNonQuery();

                        SqlCommand komut2 = new SqlCommand("Delete Borclar1 Where OgrenciTc=@pp1", sql.Baglan());
                        komut2.Parameters.AddWithValue("@pp1", MskTc.Text);
                        komut2.ExecuteNonQuery();

                        SqlCommand komut3 = new SqlCommand("Update Odalar set OdaAktif=OdaAktif-1 Where OdaNo=@h1", sql.Baglan());
                        komut3.Parameters.AddWithValue("@h1", CmbOda.Text);
                        komut3.ExecuteNonQuery();



                    }
                  
                }
                else
                {
                    MessageBox.Show("Lütfen Öncelikle Birini Seçiniz!");
                }
                SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc as TC ,OgrenciAd as Ad, OgrenciBolum as Bölüm,OgrenciMail as Mail,OgrenciTelefon as Telefon,OgrenciOdaNo as Oda  From Ogrenci", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                sql.Baglan().Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
          
          
        }
     static   string oda_no;

        //Öğrenci Güncelleme İşlemi Yapılıyor
        private void button2_Click(object sender, EventArgs e)
        {
            #region OgrenciGUncelleme
            try
            {
              
            if (TxtAd.Text != "" && MskDogum.Text !="" && MskTc.Text !="" && TxtMail.Text!="" && MskTel.Text !="" && CmbOda.Text !="" && txtAdres.Text != "" && MskVeliTel.Text !="" && txtVeliAd.Text !="" && cmbYakin.Text !="" && cmbYasadigi.Text !="" && cmbDogdugu.Text!="" )
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        string bolum = txtBolum.Text.Trim();
                        SqlCommand komut = new SqlCommand("Update Ogrenci set OgrenciAd=@p1,OgrenciDogum=@p2" +
                            ",OgrenciTc=@p3,OgrenciBolum=@p4,OgrenciMail=@p5,OgrenciTelefon= @p6,VeliTel=@p7,OgrenciOdaNo=@p8  ,VeliAd=@p10," +
                            "VeliYakinlik =@p11,IlIlce=@p12,Dogduguyer=@p13" +
                            " where Ogrenciid=@p14 ", sql.Baglan());

                        komut.Parameters.AddWithValue("@p1", TxtAd.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p2", MskDogum.Text);
                        komut.Parameters.AddWithValue("@p3", MskTc.Text);
                        komut.Parameters.AddWithValue("@p4", bolum.ToUpper());
                        komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                        komut.Parameters.AddWithValue("@p6", MskTel.Text);
                        komut.Parameters.AddWithValue("@p7", MskVeliTel.Text);
                        komut.Parameters.AddWithValue("@p8", CmbOda.Text);
                        //komut.Parameters.AddWithValue("@p9", txtAdres.Text);
                        komut.Parameters.AddWithValue("@p10", txtVeliAd.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p11", cmbYakin.Text);
                        komut.Parameters.AddWithValue("@p12", cmbYasadigi.Text.ToUpper());
                        komut.Parameters.AddWithValue("@p13", cmbDogdugu.Text);
                        komut.Parameters.AddWithValue("@p14", label10.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Güncellendi");


                        SqlCommand komut2 = new SqlCommand("Update Ogrenci set OgrenciAdres=@pp1 where OgrenciTC=@pp2",sql.Baglan());
                        komut2.Parameters.AddWithValue("@pp1",txtAdres.Text);
                        komut2.Parameters.AddWithValue("@pp2",MskTc.Text);
                        komut2.ExecuteNonQuery();

                        SqlCommand komut3 = new SqlCommand("Update Odalar set OdaAktif=OdaAktif-1 Where OdaNo=@c1",sql.Baglan());
                        komut3.Parameters.AddWithValue("@c1",lblOda.Text);
                        komut3.ExecuteNonQuery();

                        SqlCommand komut4 = new SqlCommand("Update Odalar set OdaAktif=OdaAktif+1 Where OdaNo=@d1 ",sql.Baglan());
                        komut4.Parameters.AddWithValue("@d1",CmbOda.Text);
                        komut4.ExecuteNonQuery();

                        SqlCommand komut5 = new SqlCommand("Update Borclar1 set OgrenciAd=@b1,OgrenciMail=@b2,OgrenciTel=@b3 Where OgrenciTc=@b4",sql.Baglan());
                        komut5.Parameters.AddWithValue("@b1",TxtAd.Text);
                        komut5.Parameters.AddWithValue("@b2",TxtMail.Text);
                        komut5.Parameters.AddWithValue("@b3",MskTel.Text);
                        komut5.Parameters.AddWithValue("@b4",MskTc.Text);
                        komut5.ExecuteNonQuery();


                        SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc as TC ,OgrenciAd as Ad, OgrenciBolum as Bölüm,OgrenciMail as Mail,OgrenciTelefon as Telefon,OgrenciOdaNo as Oda  From Ogrenci", sql.Baglan());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        sql.Baglan().Close();
                    }
                
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanların Doldurduğunuzdan Emin Olunuz");
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oldu !  Lütfen Tekrar Deneyiniz");
               
              
            }
            #endregion
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

      


        //Arama textbox'a her bir harf girildiğinde sqlden sorgu yapılarak kişiye dinamik olarak sonuçlar getirilecek
        private void txtArama_TextChanged(object sender, EventArgs e)
        {

            string ara = txtArama.Text;
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc as TC , OgrenciAd as Ad,OgrenciBolum as Bölüm,OgrenciMail as Mail,OgrenciTelefon as Telefon,OgrenciOdaNo as Oda from Ogrenci where OgrenciAd LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete Ogrenci  where OgrenciTc =@p1", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", MskTc.Text);
                komut.ExecuteNonQuery();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            #region datagridviewGosterme
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
           
            // SqlDataAdapter da = new SqlDataAdapter("Select OgrenciAd,OgrenciTc,OgrenciBolum,OgrenciMail,OgrenciTelefon,OgrenciOdaNo From Ogrenci", sql.Baglan());
            MskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBolum.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbOda.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrenciTc=@p1", sql.Baglan());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label10.Text = dr[0].ToString();
                MskDogum.Text = dr[3].ToString();
                lblOda.Text= dr[7].ToString();
                txtAdres.Text = dr[11].ToString();
                MskVeliTel.Text = dr[8].ToString();
                txtVeliAd.Text = dr[9].ToString();
                //txtVeliSoyad.Text = dr[10].ToString();
                cmbYakin.Text = dr[10].ToString();
                cmbYasadigi.Text = dr[12].ToString();
              
                cmbDogdugu.Text = dr[13].ToString();
                #endregion
            }
        }

        
        
    }
}
