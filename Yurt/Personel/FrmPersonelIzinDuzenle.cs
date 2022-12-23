using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yurt.Personel
{
    public partial class FrmPersonelIzinDuzenle : Form
    {
        public FrmPersonelIzinDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmPersonelIzinDuzenle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From PersonelIzin", sql.Baglan()) ;
            DataTable dt= new DataTable();  
            da.Fill(dt);
            dataGridView1.DataSource= dt;

            
        }
        public void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From PersonelIzin", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       
        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            DialogResult d = new DialogResult();
            d = MessageBox.Show("Bilgi","Güncellemek istediğinize emin misiniz?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                SqlCommand komutGuncelle = new SqlCommand("Update PersonelIzin  SET Sebep=@p1,Baslangic=@p2,Bitis=@p3 where Izinid=@p4 ", sql.Baglan());
                komutGuncelle.Parameters.AddWithValue("@p1", txtSebep.Text);
                komutGuncelle.Parameters.AddWithValue("@p2", dtBas.Text);
                komutGuncelle.Parameters.AddWithValue("@p3", dtBit.Text);
                komutGuncelle.Parameters.AddWithValue("@p4", lblid.Text);
                komutGuncelle.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellendi");

                Goster();
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bİlgi","Silmek istediğinize emin misiniz?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                SqlCommand komutSil = new SqlCommand("Delete PersonelIzin where Izinid=@d1", sql.Baglan());
                komutSil.Parameters.AddWithValue("@d1", lblid.Text);
                komutSil.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi");


                Goster();
            }
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                mskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtSebep.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                dtBas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                dtBit.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
