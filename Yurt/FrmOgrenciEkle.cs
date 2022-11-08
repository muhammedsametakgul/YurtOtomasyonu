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
    public partial class FrmOgrenciEkle : Form
    {
        public FrmOgrenciEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void Form1_Load(object sender, EventArgs e)
        {
            //bölümleri comboboxa aktarma
            SqlCommand komut1 = new SqlCommand("Select * From Bolumler",sql.Baglan());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbBolum.Items.Add(dr1[1].ToString());
                
            }

            //Boş odaları gösterme
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif",sql.Baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CmbOda.Items.Add(dr2[0].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Öğrenci Eklemek
            SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrenciAd,OgrenciSoyad,OgrenciDogum,OgrenciTc,OgrenciBolum," +
                "OgrenciSifre,OgrenciMail,OgrenciTelefon,OgrenciOdaNo) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",sql.Baglan());

            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskDogum.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", CmbBolum.Text);
            komut.Parameters.AddWithValue("@p6", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", MskTel.Text);
            komut.Parameters.AddWithValue("@p9", CmbOda.Text);
            komut.ExecuteNonQuery();


            //Odadaki aktif kalan kişi sayısını arttırmak
            SqlCommand komut2 = new SqlCommand("Update Odalar set OdaAktif =OdaAktif+1 where OdaNo=@p1",sql.Baglan());
            komut2.Parameters.AddWithValue("@p1",CmbOda.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Eklendi");
           

            sql.Baglan().Close();
            
            this.Close();




        }
    }
}
