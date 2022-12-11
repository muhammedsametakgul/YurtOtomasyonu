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
    public partial class FrmBolumDuzenle : Form
    {
        public FrmBolumDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        public bool a = false;
        public bool b = false;
        private void FrmBolumDuzenle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bolumler ",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            textBox2.Visible = a;
            label1.Visible = a;
            label2.Visible = a;
            label3.Visible = a;
            BtnSil.Visible = b;
            BtnGuncelle.Visible = a;
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label3.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Bolumler set BolumAd=@p1 where Bolumid=@p2",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2",label3.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Başarıyla Güncellendi");
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bolumler ", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Baglan().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete Bolumler where Bolumid=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",label3.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Silindi");
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bolumler ", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Baglan().Close();
        }
    }
}
