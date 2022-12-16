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
            
                SqlDataAdapter da = new SqlDataAdapter("Select OgrenciAd as Ad,OgrenciTc as TC , OgrenciBolum as Bölüm,OgrenciMail as Mail,OgrenciTelefon as Telefon,OgrenciOdaNo as Oda  From Ogrenci", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Baglan().Close();




         
            //tıklanan butona göre hangi araçları visible yapacağımıza karar veriyoruz
            
            ////bölümleri comboboxa aktarma
            //SqlCommand komut1 = new SqlCommand("Select * From Bolumler", sql.Baglan());
            //SqlDataReader dr1 = komut1.ExecuteReader();
            //while (dr1.Read())
            //{
            //    CmbBolum.Items.Add(dr1[1].ToString());

            //}

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
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Uyarı", "Silmek istediğinize emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete Ogrenci  where OgrenciTc =@p1", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", MskTc.Text);
                komut.ExecuteNonQuery();
            }
            SqlDataAdapter da = new SqlDataAdapter("Select * From Ogrenci", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Baglan().Close();
           
          
          
        }

        //Öğrenci Güncelleme İşlemi Yapılıyor
        private void button2_Click(object sender, EventArgs e)
        {
            string bolum=txtBolum.Text.Trim();
            SqlCommand komut = new SqlCommand("Update Ogrenci set OgrenciAd=@p1,OgrenciDogum=@p2" +
                ",OgrenciTc=@p3,OgrenciBolum=@p4,OgrenciMail=@p5,OgrenciTelefon= @p6,VeliTel=@p7,OgrenciOdaNo=@p8 ,OgrenciAdres=@p9 ,VeliAd=@p10," +
                "VeliYakinlik =@p11,Il=@p12,Ilce=@p13" +
                " where Ogrenciid=@p14 ",sql.Baglan());

            komut.Parameters.AddWithValue("@p1",TxtAd.Text.ToUpper());
            komut.Parameters.AddWithValue("@p2",MskDogum.Text);
            komut.Parameters.AddWithValue("@p3",MskTc.Text);
            komut.Parameters.AddWithValue("@p4",bolum);
            komut.Parameters.AddWithValue("@p5",TxtMail.Text);
            komut.Parameters.AddWithValue("@p6",MskTel.Text);
            komut.Parameters.AddWithValue("@p8",CmbOda.Text);
            komut.Parameters.AddWithValue("@p9",rchAdres.Text);
            komut.Parameters.AddWithValue("@p7",MskVeliTel.Text);
            komut.Parameters.AddWithValue("@p10",txtVeliAd.Text.ToUpper());
           // komut.Parameters.AddWithValue("@p11",txtVeliSoyad.Text);
            komut.Parameters.AddWithValue("@p11",cmbYakin.Text);
            komut.Parameters.AddWithValue("@p12",txtIl.Text.ToUpper());
            komut.Parameters.AddWithValue("@p13",txtIlce.Text.ToUpper());
            komut.Parameters.AddWithValue("@p14",label10.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Güncellendi");

            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciAd as Ad,OgrenciTc as TC , OgrenciBolum as Bölüm,OgrenciMail as Mail,OgrenciTelefon as Telefon,OgrenciOdaNo as Oda  From Ogrenci", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Baglan().Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
           // SqlDataAdapter da = new SqlDataAdapter("Select OgrenciAd,OgrenciTc,OgrenciBolum,OgrenciMail,OgrenciTelefon,OgrenciOdaNo From Ogrenci", sql.Baglan());

            TxtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBolum.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbOda.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrenciTc=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                label10.Text = dr[0].ToString();
                MskDogum.Text = dr[3].ToString();
                rchAdres.Text = dr[12].ToString();
                MskVeliTel.Text = dr[8].ToString();
                txtVeliAd.Text = dr[9].ToString();
                //txtVeliSoyad.Text = dr[10].ToString();
                cmbYakin.Text = dr[10].ToString();
                txtIl.Text = dr[12].ToString();
                txtIlce.Text = dr[13].ToString();
            }
            
        }


        //Arama textbox'a her bir harf girildiğinde sqlden sorgu yapılarak kişiye dinamik olarak sonuçlar getirilecek
        private void txtArama_TextChanged(object sender, EventArgs e)
        {

            string ara = txtArama.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from Ogrenci where OgrenciAd LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Uyarı","Silmek istediğinize emin misiniz?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete Ogrenci  where OgrenciTc =@p1", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", MskTc.Text);
                komut.ExecuteNonQuery();
            }
            
        }
    }
}
