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
            SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman From PersonelIzin",sql.Baglan());   
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtArama.Text;
            SqlDataAdapter da = new SqlDataAdapter("select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where PersonelAdSoyad LIKE '%" + ara + "%' or Baslangic LIKE '%"+ara+"%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
            }
        }

        private void rbGecmis_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGecmis.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where Aktifmi=0", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAktif.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where Aktifmi=1", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            if(rbHepsi.Checked) {
               

                if(rbMemur.Checked)
                {
                    string a = "Memur";
                    SqlDataAdapter da2 = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where Departman= '" + a + "'", sql.Baglan());
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView1.DataSource = dt2;

                }
                else if(rbPersonel.Checked)
                {
                    string a = "Personel";
                    SqlDataAdapter da3 = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin where Departman= '" + a + "'", sql.Baglan());
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    dataGridView1.DataSource = dt3;

                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin ", sql.Baglan());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            rbPersonel.Checked = false;
            rbMemur.Checked = false;
            rbHepsi.Checked = false;
            rbGecmis.Checked = false;
            rbGecmis.Checked = false;
            txtArama.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,Sebep,Baslangic,Bitis,Departman from PersonelIzin ", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
    }
}
