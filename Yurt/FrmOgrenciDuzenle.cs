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
        public bool a=false;
        public bool b = false;
        
        private void FrmOgrenciDuzenle_Load(object sender, EventArgs e)
        {
            
                SqlDataAdapter da = new SqlDataAdapter("Select * From Ogrenci", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Baglan().Close();




         
            //tıklanan butona göre hangi araçları visible yapacağımıza karar veriyoruz
            TxtAd.Visible = a;
            TxtSoyad.Visible = a;
            MskDogum.Visible = a;
            MskTc.Visible = a;
            CmbBolum.Visible = a;
            TxtSifre.Visible = a;
            TxtMail.Visible = a;
            MskTel.Visible = a;
            CmbOda.Visible = a;
            label1.Visible = a;
            label2.Visible = a;
            label3.Visible = a;
            label4.Visible = a;
            label5.Visible = a;
            label6.Visible = a;
            label7.Visible = a;
            label8.Visible = a;
            label9.Visible = a;
            BtnGuncelle.Visible = a;
            BtnSil.Visible = b;

            //bölümleri comboboxa aktarma
            SqlCommand komut1 = new SqlCommand("Select * From Bolumler", sql.Baglan());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbBolum.Items.Add(dr1[1].ToString());

            }

            //Boş odaları gösterme
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", sql.Baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CmbOda.Items.Add(dr2[0].ToString());
            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskDogum.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbBolum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            CmbOda.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            label10.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete Ogrenci  where OgrenciTc =@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla silindi!");
            SqlDataAdapter da = new SqlDataAdapter("Select * From Ogrenci", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Baglan().Close();
            sql.Baglan().Close();
          
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ogrenci set OgrenciAd=@p1,OgrenciSoyad=@p2,OgrenciDogum=@p3" +
                ",OgrenciTc=@p4,OgrenciBolum=@p5,OgrenciSifre=@p6,OgrenciMail=@p7,OgrenciTelefon= @p8,OgrenciOdaNo=@p9 where " +
                "Ogrenciid=@p10 ",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",MskDogum.Text);
            komut.Parameters.AddWithValue("@p4",MskTc.Text);
            komut.Parameters.AddWithValue("@p5",CmbBolum.Text);
            komut.Parameters.AddWithValue("@p6",TxtSifre.Text);
            komut.Parameters.AddWithValue("@p7",TxtMail.Text);
            komut.Parameters.AddWithValue("@p8",MskTel.Text);
            komut.Parameters.AddWithValue("@p9",CmbOda.Text);
            komut.Parameters.AddWithValue("@p10",label10.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Güncellendi");
            SqlDataAdapter da = new SqlDataAdapter("Select * From Ogrenci", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            sql.Baglan().Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
