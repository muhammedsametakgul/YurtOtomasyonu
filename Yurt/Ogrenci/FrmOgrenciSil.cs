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

namespace Yurt.Ogrenci
{
    public partial class FrmOgrenciSil : Form
    {
        public FrmOgrenciSil()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();


        private void FrmOgrenciSil_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da= new SqlDataAdapter("Select  * From Ogrenci",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from Ogrenci where OgrenciAd LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = new DialogResult();
            dr=MessageBox.Show("Uyarı","Başarıyla silindi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {

                SqlCommand komut = new SqlCommand("Delete Ogrenci where Ogrenciid='" + lblid.Text + "'", sql.Baglan());
                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgi","Başarıyla Silindi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                SqlDataAdapter da = new SqlDataAdapter("Select  * From Ogrenci", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else
            {
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
