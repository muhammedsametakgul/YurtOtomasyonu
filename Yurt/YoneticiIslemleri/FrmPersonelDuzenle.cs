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
            SqlDataAdapter da = new SqlDataAdapter("Select * From Personel", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            dataGridView1.DataSource = dt;
        }
        private void FrmPersonelDuzenle_Load(object sender, EventArgs e)
        {

            Goster();
        }
       
      

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dinamik olarak arıyor
            SqlDataAdapter da = new SqlDataAdapter("select * from Personel where PersonelAdSoyad LIKE '%" + textBox1.Text + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Personel set  PersonelTc=@p1,PersonelAdSoyad=@p2," +
                "PersonelDepartman=@p3,PersonelTelefon=@p4,PersonelMail=@p5,PersonelSifre=@p6 ,PersonelAdres=@p7 where Personelid=@p8", sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.Parameters.AddWithValue("@p2",TxtAd.Text);
            komut.Parameters.AddWithValue("@p3",CmbDep.Text);
            komut.Parameters.AddWithValue("@p4",mskTel.Text);
            komut.Parameters.AddWithValue("@p5",txtMail.Text);
            komut.Parameters.AddWithValue("@p6",TxtSifre.Text);
            komut.Parameters.AddWithValue("@p7",TxtAdres.Text);
            komut.Parameters.AddWithValue("@p8",label6.Text);

          

            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla güncellendi");
            Goster();
            sql.Baglan().Close();
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete Personel  where PersonelTc =@p1", sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla silindi");
            TxtAd.Text = "";
            MskTc.Text = "";
            CmbDep.Text= "";
            TxtSifre.Text="";
            mskTel.Text = "";
            TxtAdres.Text = "";
            txtMail.Text = "";
            Goster();

            sql.Baglan().Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label6.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbDep.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            mskTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
