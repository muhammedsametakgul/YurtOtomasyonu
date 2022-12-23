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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Yurt.YoneticiIslemleri
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void TxtAdAra_TextChanged(object sender, EventArgs e)
        {
            //dinamik olarak arıyor
            SqlDataAdapter da = new SqlDataAdapter("select PersonelTc,PersonelAdSoyad from Personel where PersonelAdSoyad LIKE '%" + TxtAdAra.Text + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

   

        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad From Personel",sql.Baglan());
            DataTable d = new DataTable();
            da.Fill(d);
            dataGridView1.DataSource = d;
            gbIletisim.Visible=false;
            gbPersonelEkle.Visible=false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbIletisim.Visible = true;
            gbPersonelEkle.Visible = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MskTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * From Personel Where PersonelTc= '"+MskTc.Text+"'",sql.Baglan());
            SqlDataReader dr =komut.ExecuteReader();
            while(dr.Read())
            {
                CmbDep.Text = dr[3].ToString();
                mskTel.Text = dr[4].ToString();
                txtMail.Text = dr[5].ToString();
                TxtAdres.Text = dr[6].ToString();
                mskDogum.Text = dr[7].ToString();   
            }
            //CmbDep.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            //mskTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            //txtMail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            //TxtAdres.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            //mskDogum.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();  
        }

        private void MskTc_Click(object sender, EventArgs e)
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
