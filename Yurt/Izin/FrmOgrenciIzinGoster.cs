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
    public partial class FrmOgrenciIzinGoster : Form
    {
        public FrmOgrenciIzinGoster()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        DateTime zaman = DateTime.Now;
        DateTime gecici;
        string sistem;
        string data;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


   
        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = TxtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where  OgrenciAdSoyad LIKE '%" + ara + "%' or OgrenciTc LIKE '%" + ara + "%'  ORDER BY Baslangic ASC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
           
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[2].HeaderText = "Sebep";
            dataGridView1.Columns[3].HeaderText = "Başlangıç";
            dataGridView1.Columns[4].HeaderText = "Bitiş";

        }

        private void FrmOgrenciIzinGoster_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis From OgrenciIzin  ORDER BY Baslangic DESC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[2].HeaderText = "Sebep";
            dataGridView1.Columns[3].HeaderText = "Başlangıç";
            dataGridView1.Columns[4].HeaderText = "Bitiş";






        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            lblTc.Text = dataGridView1.Rows[secilen].Cells["OgrenciTc"].Value.ToString();

           
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnListele_Click(object sender, EventArgs e)
        {
            string ara = TxtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where  OgrenciAdSoyad LIKE '%" + ara + "%' or OgrenciTc LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[2].HeaderText = "Sebep";
            dataGridView1.Columns[3].HeaderText = "Başlangıç";
            dataGridView1.Columns[4].HeaderText = "Bitiş";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void rbey_CheckedChanged(object sender, EventArgs e)
        {
            if(rbey.Checked)
            {
                string ara = TxtAra.Text;
                SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where   OgrenciAdSoyad LIKE '%" + ara + "%' or OgrenciTc LIKE '%" + ara + "%' ORDER BY Baslangic ASC", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "TC";
                dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
                dataGridView1.Columns[2].HeaderText = "Sebep";
                dataGridView1.Columns[3].HeaderText = "Başlangıç";
                dataGridView1.Columns[4].HeaderText = "Bitiş";
            }
        }

        private void rbye_CheckedChanged(object sender, EventArgs e)
        {
            string ara = TxtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where    OgrenciAdSoyad LIKE '%" + ara + "%' or OgrenciTc LIKE '%" + ara + "%' ORDER BY Baslangic DESC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[2].HeaderText = "Sebep";
            dataGridView1.Columns[3].HeaderText = "Başlangıç";
            dataGridView1.Columns[4].HeaderText = "Bitiş";
        }

    }
}
