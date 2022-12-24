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

namespace Yurt.Müdür
{
    public partial class FrmAdminIslemleri : Form
    {
        public FrmAdminIslemleri()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void FrmYoneticiEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select YoneticiAdSoyad,YoneticiTc,YoneticiEmail,YoneticiSifre from Admin",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);    
            dataGridView1.DataSource= dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
            mskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            SqlCommand komut = new SqlCommand("Select Yoneticiid from Admin where YoneticiTc=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lblid.Text = dr[0].ToString();
            }

        }
        public  void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select YoneticiAd,YoneticiSoyad,YoneticiTc,YoneticiEmail,YoneticiSifre from Admin", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Eklemek istediğinize emin misiniz?","Bilgi",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Insert into Admin (YoneticiAd,YoneticiSoyad,YoneticiTc,YoneticiEmail,YoneticiSifre) Values (@p1,@p2,@p3,@p4,@p5)", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTc.Text);
                komut.Parameters.AddWithValue("@p4", txtEmail.Text);
                komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                komut.ExecuteNonQuery();
                Goster();
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = new DialogResult();
                d = MessageBox.Show("Güncellemek istediğinize emin misiniz?","Bilgi",MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    SqlCommand komutGuncelle = new SqlCommand("Update Admin Set YoneticiAd=@p1,YoneticiSoyad=@p2,YoneticiTc=@p3,YoneticiEmail=@p4,YoneticiSifre=@p5  where Yoneticiid=@p6", sql.Baglan());
                    komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text.ToUpper());
                    komutGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text.ToUpper());
                    komutGuncelle.Parameters.AddWithValue("@p3", mskTc.Text);
                    komutGuncelle.Parameters.AddWithValue("@p4", txtEmail.Text);
                    komutGuncelle.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komutGuncelle.Parameters.AddWithValue("@p6", lblid.Text);
                    komutGuncelle.ExecuteNonQuery();
                    Goster();
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show("Lütfen güncellemek için birini seçiniz !");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d2 = new DialogResult();
                d2 = MessageBox.Show("Silmek istediğnize emin misiniz?","Bilgi",MessageBoxButtons.YesNo);
                if (d2 == DialogResult.Yes)
                {
                    SqlCommand komutSil = new SqlCommand("Delete Admin where Yoneticiid=@p1", sql.Baglan());
                    komutSil.Parameters.AddWithValue("@p1", lblid.Text);
                    komutSil.ExecuteNonQuery();
                    Goster();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("Lütfen silmek için birini seçiniz");
            }
        }

        private void mskTc_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }
    }
}
