using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.Müdür;
using System.Data.SqlClient;

namespace Yurt.Gelir
{
    public partial class FrmYurtUcreti : Form
    {
        public FrmYurtUcreti()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        DateTime zaman = DateTime.Now;

        string zamann;
        private void FrmYurtUcreti_Load(object sender, EventArgs e)
        {
            lblUyari.ForeColor = Color.Red;
            mskUcret.Visible= false;
            btnBelirle.Visible= false;
            lblUcret.Visible = false;
          
            dataGridView1.Visible=false;
            SqlDataAdapter da = new SqlDataAdapter("Select YurtUcreti,Tarih,Kim,Aktifmi From YurtUcreti",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
         zamann=zaman.ToString();
           
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Mudur Where mudurKullaniciAdi=@p1 and mudurSifre=@p2 ",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",txtKullanici.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();   

            if (dr.Read())
            {
                groupBox1.Visible= true;
            
                lblAd.Text = dr[2].ToString();

                txtKullanici.Visible= false;
                txtSifre.Visible=false;
                btnDogrula.Visible= false;
                mskUcret.Visible= true;
                btnBelirle.Visible = true;
                lblUcret.Visible= true;
                lblKullanici.Visible = false;    
                lblSifre.Visible = false;   
                
                dataGridView1.Visible = true;
                lblUyari.Text = "Doğrulama Başarılı";
                lblUyari.ForeColor = Color.Green;
            }

        }

        private void btnBelirle_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Yurt Ücretini değiştirmek istediğinize emin misiniz?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                //Yurt ÜCretini loglarda tutabilmek için

                SqlCommand komut = new SqlCommand("Insert into YurtUcreti (YurtUcreti,Tarih,Kim) Values(@p1,@p2,@p3)", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", mskUcret.Text);
                komut.Parameters.AddWithValue("@p2", zamann);
                komut.Parameters.AddWithValue("@p3", lblAd.Text);
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("Update YurtUcreti set Aktifmi=0 ",sql.Baglan());
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("Update YurtUcreti set Aktifmi=1 where Tarih =@pp1",sql.Baglan());
                komut3.Parameters.AddWithValue("@pp1",zamann);
                komut3.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select YurtUcreti,Tarih,Kim,Aktifmi From YurtUcreti", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;




            }

        }
    }
}
