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
    public partial class FrmOgrenciIzinDuzenle : Form
    {
        public FrmOgrenciIzinDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmIzinDuzenle_Load(object sender, EventArgs e)
        {
            Guncelle_Grid();
            
        }
        
        public  void Guncelle_Grid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From OgrenciIzin", sql.Baglan());

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            lblTc.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSebep.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            DateBas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            DateBit.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
       

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("Update OgrenciIzin set Sebep=@p1,Baslangic=@p2,Bitis=@p3 where Izinid=@p4", sql.Baglan());
                komut1.Parameters.AddWithValue("@p1", TxtSebep.Text);
                komut1.Parameters.AddWithValue("@p2", DateBas.Text);
                komut1.Parameters.AddWithValue("@p3", DateBit.Text);
                komut1.Parameters.AddWithValue("@p4", lblid.Text);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellendi");
             
                Guncelle_Grid();
                sql.Baglan().Close();
            }
                
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string ara = txtArama.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from OgrenciIzin where OgrenciAdSoyad LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //string ara = txtArama.Text;
          //SqlDataAdapter da = new SqlDataAdapter("select * from OgrenciIzin where OgrenciAdSoyad LIKE '%" + ara + " %'", sql.Baglan());

            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

        }
    }
}
