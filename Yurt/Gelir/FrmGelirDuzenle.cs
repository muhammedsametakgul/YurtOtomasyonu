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

namespace Yurt.Gelir
{
    public partial class FrmGelirDuzenle : Form
    {
        public FrmGelirDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void FrmGelirDuzenle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Gelir",sql.Baglan());
            DataTable dt= new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        public void Goster()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Gelir", sql.Baglan());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
             txtOdeyenKisi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtEmail.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dtTarih.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtOdenen.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            SqlCommand komut1 = new SqlCommand("Select * From Gelir",sql.Baglan());
            rbFirma.Checked = false;
            rbBireysel.Checked = false;
            txtFirma.Visible = true;
            lblFirma.Visible = true;
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                if (dr["FirmaAdi"] != null)
                {
                   
                    txtFirma.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                }
               
            }
        }

        private void rbFirma_CheckedChanged(object sender, EventArgs e)
        {
            txtFirma.Visible = true; lblFirma.Visible = true;
            txtFirma.Text = "";
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            txtFirma.Visible = false; lblFirma.Visible = false;
            txtFirma.Text = "Bireysel";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Gelir set Odeyen=@p1,OdeyenTelefon=@p2,OdeyenMail=@p3,OdemeTarih=@p4,OdemeMiktar=@p5,FirmaAdi=@p6 where Odemeid=@p7", sql.Baglan()); ;
            komut.Parameters.AddWithValue("@p1",txtOdeyenKisi.Text);
            komut.Parameters.AddWithValue("@p2",mskTel.Text);
            komut.Parameters.AddWithValue("@p3",txtEmail.Text);
            komut.Parameters.AddWithValue("@p4",dtTarih.Text);
            komut.Parameters.AddWithValue("@p5",txtOdenen.Text);
            komut.Parameters.AddWithValue("@p6",txtFirma.Text);
            komut.Parameters.AddWithValue("@p7",lblid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla güncellendi");
            Goster();
            sql.Baglan().Close();
            
        }
    }
}
