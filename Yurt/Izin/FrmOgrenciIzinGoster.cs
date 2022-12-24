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
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where  OgrenciAdSoyad LIKE '%" + ara + "%' or OgrenciTc LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
      
        private void FrmOgrenciIzinGoster_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis From OgrenciIzin", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

           
            
            
        
        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            lblTc.Text = dataGridView1.Rows[secilen].Cells["OgrenciTc"].Value.ToString();

            SqlCommand komut = new SqlCommand("Select Aktifmi From OgrenciIzin Where OgrenciTc=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAktif.Text = dr[0].ToString();
            }
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void rbey_CheckedChanged(object sender, EventArgs e)
        {
            if(rbey.Checked)
            {
                string ara = TxtAra.Text;
                SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where Aktifmi=0 and  OgrenciAdSoyad LIKE '%" + ara + "%' or OgrenciTc LIKE '%" + ara + "%' ORDER BY BİTİS ASC", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void rbye_CheckedChanged(object sender, EventArgs e)
        {
            string ara = TxtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciTc,OgrenciAdSoyad,Sebep,Baslangic,Bitis from OgrenciIzin where    OgrenciAdSoyad LIKE '%" + ara + "%' or OgrenciTc LIKE '%" + ara + "%' ORDER BY BİTİS DESC", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
