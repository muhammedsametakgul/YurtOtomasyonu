﻿using System;
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
            ////bölümleri comboboxa aktarma
            //SqlCommand komut1 = new SqlCommand("Select * From Bolumler",sql.Baglan());
            //SqlDataReader dr1 = komut1.ExecuteReader();
            //while (dr1.Read())
            //{
            //    CmbBolum.Items.Add(dr1[1].ToString());
                
            //}

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
            string bolum=txtBolum.Text.Trim();
            SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrenciAd,OgrenciDogum,OgrenciTc,OgrenciBolum," +
                "OgrenciMail,OgrenciTelefon,OgrenciOdaNo,OgrenciAdres,VeliTel) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",sql.Baglan());

            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
          
            komut.Parameters.AddWithValue("@p2", MskDogum.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", bolum);
     
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", MskTel.Text);
            komut.Parameters.AddWithValue("@p7", CmbOda.Text);
            komut.Parameters.AddWithValue("@p8", rchAdres.Text) ;
            komut.Parameters.AddWithValue("@p9",MskVeliTel.Text);
            komut.ExecuteNonQuery();


            //Odadaki aktif kalan kişi sayısını arttırmak
            SqlCommand komut2 = new SqlCommand("Update Odalar set OdaAktif =OdaAktif+1 where OdaNo=@h1",sql.Baglan());
            komut2.Parameters.AddWithValue("@h1",CmbOda.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Eklendi");
            
            SqlCommand komut3= new SqlCommand("insert into Borclar1 (OgrenciTc,OgrenciAd,OgrenciMail,OgrenciTel) " +
                "values (@b1,@b2,@b3,@b4)",sql.Baglan());
            komut3.Parameters.AddWithValue("@b1",MskTc.Text);
            komut3.Parameters.AddWithValue("@b2",TxtAd.Text);
           
            komut3.Parameters.AddWithValue("b3",TxtMail.Text);
            komut3.Parameters.AddWithValue("@b4", MskTel.Text);
            komut3.ExecuteNonQuery();


         

            sql.Baglan().Close();
            
            this.Close();




        }

        private void MskTel_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void MskTel_EnabledChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
        }
    }
}