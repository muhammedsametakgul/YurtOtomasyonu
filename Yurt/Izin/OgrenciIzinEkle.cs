﻿using System;
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
namespace Yurt
{
    public partial class OgrenciIzinEkle : Form
    {
        public OgrenciIzinEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        public int gun;
        public int yeni_gun;
        public  static int gecici_gun;
        private void OgrenciIzinEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciAd,OgrenciTc,OgrenciTelefon,VeliTel from Ogrenci",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
          
      
            
                SqlCommand komut = new SqlCommand("insert into OgrenciIzin (OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis,OgrenciTel" +
               ",VeliTel) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", MskTc.Text);
                komut.Parameters.AddWithValue("@p2", TxtAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtSebep.Text);
                komut.Parameters.AddWithValue("@p4", DateBas.Text);
                komut.Parameters.AddWithValue("@p5", DateBit.Text);
                komut.Parameters.AddWithValue("@p6", MskOgrenciTel.Text);
                komut.Parameters.AddWithValue("@p7", MskVeliTel.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyl eklendi");
             
              
            sql.Baglan().Close();
      
              
                

            
           

            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtAd.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTc.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskOgrenciTel.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskVeliTel.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();

           
        }
    }
}
