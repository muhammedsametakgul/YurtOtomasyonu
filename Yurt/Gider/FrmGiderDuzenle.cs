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
    public partial class FrmGiderDuzenle : Form
    {
        public FrmGiderDuzenle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Giderler set Elektrik=@p1,Dogalgaz=@p2,Internet=@p3,Gida=@p4," +
                "Personel=@p5,Su=@p6,Diger=@p7,GiderAy=@p8 where Odemeid=@p9",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",MskElektrik.Text);
            komut.Parameters.AddWithValue("@p2", MskDogalgaz.Text);
            komut.Parameters.AddWithValue("@p3", MskInternet.Text);
            komut.Parameters.AddWithValue("@p4", MskGida.Text);
            komut.Parameters.AddWithValue("@p5", MskPersonel.Text);
            komut.Parameters.AddWithValue("@p6", MskSu.Text);
            komut.Parameters.AddWithValue("@p7", MskDiger.Text);
            komut.Parameters.AddWithValue("@p8", MskTarih.Text);
            komut.Parameters.AddWithValue("@p9",lblid.Text);

            komut.ExecuteNonQuery();

            MessageBox.Show("Başarıyla güncellendi");
            //Güncellendikten sonra tabloyu güncelliyor
            SqlDataAdapter da = new SqlDataAdapter("Select * From Giderler", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Baglan().Close();

        }

        

        private void FrmGiderDuzenle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Giderler", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //iki kere tıklanınca tablodaki verileri textboxlara çekiyor
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskElektrik.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskDogalgaz.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskInternet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskGida.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskPersonel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskSu.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            MskDiger.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            MskTarih.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void MskTarih_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskElektrik_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskDogalgaz_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskInternet_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskGida_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        
        private void MskPersonel_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskSu_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void MskDiger_Click(object sender, EventArgs e)
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
