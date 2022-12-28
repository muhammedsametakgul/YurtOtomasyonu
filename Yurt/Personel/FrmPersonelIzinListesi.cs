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

namespace Yurt.Personel
{
    public partial class FrmPersonelIzinListesi : Form
    {
        public FrmPersonelIzinListesi()
        {
            InitializeComponent();
        }

        Sql sql = new Sql();
        
        private void FrmPersonelIzinListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman From PersonelIzin ORDER BY Baslangic DESC",sql.Baglan());   
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            dataGridView1.RowHeadersVisible = false;
        
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Sebep";
            dataGridView1.Columns[3].HeaderText = "Başlangıç";
            dataGridView1.Columns[4].HeaderText = "Bitiş";
            dataGridView1.Columns[5].HeaderText = "Departman";



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtArama.Text;
            SqlDataAdapter da = new SqlDataAdapter("select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where PersonelAdSoyad LIKE '%" + ara + "%' or Baslangic LIKE '%"+ara+"%' ORDER BY Baslangic DESC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Sebep";
            dataGridView1.Columns[3].HeaderText = "Başlangıç";
            dataGridView1.Columns[4].HeaderText = "Bitiş";
            dataGridView1.Columns[5].HeaderText = "Departman";
        }

        private void rbMemur_CheckedChanged(object sender, EventArgs e)
        {
           if(rbMemur.Checked)
            {
                string a = "Memur";
                SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where Departman= '" + a + "'", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                    dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
                dataGridView1.Columns[0].HeaderText = "TC";
                dataGridView1.Columns[2].HeaderText = "Sebep";
                dataGridView1.Columns[3].HeaderText = "Başlangıç";
                dataGridView1.Columns[4].HeaderText = "Bitiş";
                dataGridView1.Columns[5].HeaderText = "Departman";
            }
        }

        private void rbPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersonel.Checked)
            {
                string a = "Personel";
                SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where Departman= '" + a + "'", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
                dataGridView1.Columns[0].HeaderText = "TC";
                dataGridView1.Columns[2].HeaderText = "Sebep";
                dataGridView1.Columns[3].HeaderText = "Başlangıç";
                dataGridView1.Columns[4].HeaderText = "Bitiş";
                dataGridView1.Columns[5].HeaderText = "Departman";
            }
        }

       
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            rbPersonel.Checked = false;
            rbMemur.Checked = false;
           
            txtArama.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin ", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Sebep";
            dataGridView1.Columns[3].HeaderText = "Başlangıç";
            dataGridView1.Columns[4].HeaderText = "Bitiş";
            dataGridView1.Columns[5].HeaderText = "Departman";

        }
    }
}
