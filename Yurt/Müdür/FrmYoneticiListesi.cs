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

namespace Yurt.Müdür
{
    public partial class FrmYoneticiListesi : Form
    {
        public FrmYoneticiListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void FrmYoneticiListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da= new SqlDataAdapter("Select YoneticiTc,YoneticiAdSoyad From Admin",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            dataGridView1.RowHeadersVisible = false;
            groupBox1.Visible=false;
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select YoneticiTc,YoneticiAdSoyad from Admin where YoneticiAdSoyad LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * From Admin Where YoneticiTc=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtEmail.Text = dr[3].ToString();
                mskTel.Text = dr[6].ToString();
            }

        }
    }
}
