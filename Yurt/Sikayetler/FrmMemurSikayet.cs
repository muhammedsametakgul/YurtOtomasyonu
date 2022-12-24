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
using Yurt.Müdür;

namespace Yurt.Sikayetler
{
    public partial class FrmMemurSikayet : Form
    {
        public FrmMemurSikayet()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        string tarih;
        private void FrmMemurSikayet_Load(object sender, EventArgs e)
        {
            //sistem tarihi alma
            DateTime date = DateTime.Now;
     
            tarih = date.ToLongDateString() + date.ToLongTimeString();



            SqlCommand komut = new SqlCommand("Select YoneticiAdSoyad From Admin where YoneticiTc=@p1 ",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",FrmAdminGiris.tc_memur);
           
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtKimden.Text = dr[0].ToString();
                lblAd.Text = dr[0].ToString();
            }
            sql.Baglan();


            SqlDataAdapter da = new SqlDataAdapter("Select * From Sikayetler Where SikayetEden='" + lblAd.Text + "' or Kime='"+lblAd.Text+"'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void rbMemur_CheckedChanged(object sender, EventArgs e)
        {
            cmbKime.Items.Clear();  
            if(rbMemur.Checked) {
                //combobox doldurma
                SqlCommand komut2 = new SqlCommand("Select YoneticiAdSoyad from Admin ", sql.Baglan());
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbKime.Items.Add(dr2[0]);
                }
                sql.Baglan();


            }
        }

        private void rbMudur_CheckedChanged(object sender, EventArgs e)
        {
            cmbKime.Items.Clear();
            //combobox doldurma
            SqlCommand komut2 = new SqlCommand("Select mudurAdSoyad from Mudur ", sql.Baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbKime.Items.Add(dr2[0]);
            }
            sql.Baglan();
        }
        public void Goster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Sikayetler Where SikayetEden='" + lblAd.Text + "' or Kime='" + lblAd.Text + "'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Insert into Sikayetler (SikayetEden,Kime,SikayetMetni,Tarih) Values(@p1,@p2,@p3,@p4)", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", txtKimden.Text);
                komut.Parameters.AddWithValue("@p2", cmbKime.Text);
                komut.Parameters.AddWithValue("@p3", rchMetin.Text);
                komut.Parameters.AddWithValue("@p4", tarih);
                komut.ExecuteNonQuery();
                Goster();
                sql.Baglan().Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
          //  txtKimden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbKime.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            rchMetin.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            if(cmbKime.Text == txtKimden.Text)
            {
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
            }
            else
            {

                btnSil.Enabled = true;
                btnGuncelle.Enabled = true;
            }
           

            SqlCommand komut = new SqlCommand("Select Okundu from Sikayetler where Sikayetid=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",lblid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                if (dr[0].ToString() == "True")
                {
                    cbOkundu.Checked = true;
                }
                else
                {
                    cbOkundu.Checked = false;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

              
                    SqlCommand komut = new SqlCommand("Update Sikayetler set SikayetEden=@p1,Kime=@p2,SikayetMetni=@p3,Tarih=@p4 where Sikayetid=@p5 ", sql.Baglan());
                    komut.Parameters.AddWithValue("@p1", txtKimden.Text);
                    komut.Parameters.AddWithValue("@p2", cmbKime.Text);
                    komut.Parameters.AddWithValue("@p3", rchMetin.Text);
                    komut.Parameters.AddWithValue("@p4", tarih);
                    komut.Parameters.AddWithValue("@p5", lblid.Text);

                    komut.ExecuteNonQuery();
                    Goster();
                    sql.Baglan().Close();
                
              
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

           
            
                DialogResult d = new DialogResult();
                d = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Delete Sikayetler where Sikayetid=@p1", sql.Baglan());
                    komut.Parameters.AddWithValue("@p1", lblid.Text);
                    komut.ExecuteNonQuery();
                    Goster();

                    sql.Baglan().Close();
                
           
            }
        }

        private void cbOkundu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOkundu.Checked)
            {
                SqlCommand komut = new SqlCommand("Update Sikayetler set Okundu=1 where Sikayetid=@p1 and Kime=@p2", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", lblid.Text);
                komut.Parameters.AddWithValue("@p2",lblAd.Text);
                komut.ExecuteNonQuery();
                Goster();
                sql.Baglan().Close();


            }
            else
            {
                SqlCommand komut = new SqlCommand("Update Sikayetler set Okundu=0 where Sikayetid=@p1 and Kime=@p2", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", lblid.Text);
                komut.Parameters.AddWithValue("@p2", lblAd.Text);
                komut.ExecuteNonQuery();
                Goster();
                sql.Baglan().Close();

            }
        }

        private void cbHepsiOkundu_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHepsiOkundu.Checked)
            {
                SqlCommand komut = new SqlCommand("Update Sikayetler set Okundu=1 where  Kime=@p1 ", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", lblAd.Text);
               
                komut.ExecuteNonQuery();
                Goster();
                sql.Baglan().Close();

            }
           
        }

        private void rbGonderilen_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Sikayetler Where SikayetEden='" + txtKimden.Text + "'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rbGelen_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Sikayetler Where Kime='" + txtKimden.Text + "'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rbOkunmayanlar_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Sikayetler Where Okundu= 0 and Kime='" + txtKimden.Text + "'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rbOkunanlar_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Sikayetler Where Okundu= 1" +
                " and Kime='" + txtKimden.Text + "'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            Goster();
        }
    }
}
