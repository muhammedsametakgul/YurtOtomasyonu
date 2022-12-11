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
    public partial class FrmBolumEkle : Form
    {
        public FrmBolumEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",TxtBolum.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi");
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bolumler ", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Baglan().Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmBolumEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bolumler ",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
