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

namespace Yurt.YoneticiIslemleri
{
    public partial class FrmPersonelDuzenle : Form
    {
      
        public FrmPersonelDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        //datagridviewi güncel tutuyor
        public void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Personeller", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            dataGridView1.DataSource = dt;
        }
        private void FrmPersonelDuzenle_Load(object sender, EventArgs e)
        {

            Goster();
        }
       
      

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label6.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbDep.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtTel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dinamik olarak arıyor
            SqlDataAdapter da = new SqlDataAdapter("select * from Personeller where PersonelAdSoyad LIKE '%" + textBox1.Text + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Personeller set  PersonelTc=@p1,PersonelAdSoyad=@p2," +
                "PersonelDepartman=@p3,PersonelSifre=@p4 ,PersonelTelefon=@p5,PersonelAdres=@p6 where Personelid=@p7",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.Parameters.AddWithValue("@p2",TxtAd.Text);
            komut.Parameters.AddWithValue("@p3",CmbDep.Text);
            komut.Parameters.AddWithValue("@p4",TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5",TxtTel.Text);
            komut.Parameters.AddWithValue("@p6",TxtAdres.Text);
            komut.Parameters.AddWithValue("@p7",label6.Text);

          

            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla güncellendi");
            Goster();
            sql.Baglan().Close();
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete Personeller  where PersonelTc =@p1", sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla silindi");
            TxtAd.Text = "";
            MskTc.Text = "";
            CmbDep.Text= "";
            TxtSifre.Text="";
            TxtTel.Text = "";
            TxtAdres.Text = "";
            Goster();

            sql.Baglan().Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
