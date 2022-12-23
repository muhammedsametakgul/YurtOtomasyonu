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
using DevExpress.Utils.FormShadow;

namespace Yurt.Ogrenci
{
    public partial class FrmOdaListesi : Form
    {
        public FrmOdaListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmOdaListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OdaNo as OdaNumara,OdaKapasite as Kapasite,OdaAktif as AktifKalanKişi from Odalar",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;


            #region oda sayisi
            SqlCommand komutOda = new SqlCommand("Select Count(*) From Odalar ",sql.Baglan());
            SqlDataReader dr = komutOda.ExecuteReader();
            while (dr.Read())
            {
                lblOdaSayisi.Text = dr[0].ToString();
            }

            #endregion

            #region bos oda sayisi
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Odalar where OdaKapasite != OdaAktif", sql.Baglan());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBosOdaSyisi.Text = dr3[0].ToString();
            }
            #endregion

        }
        int sayi = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblOda.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
          

          
        }
        //öğrencileri datagridviewe aktarma
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           dataGridView2.Visible= true;
            dataGridView1.Visible= false;
            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciTc,OgrenciAd from Ogrenci where OgrenciOdaNo='" + lblOda.Text + "'", sql.Baglan());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            txtAra.Clear();



        }
        //ilk datagridviewe gidiyor
        private void btnGeriGel_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OdaNo as OdaNumara,OdaKapasite as Kapasite,OdaAktif as AktifKalanKişi from Odalar", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            gbKisisel.Visible= false;
            txtAra.Clear();

        }
        //öğrenci bilgilerini alma
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbKisisel.Visible= true;
            int secilen= dataGridView2.SelectedCells[0].RowIndex;
            lblTc.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciTc,OgrenciMail,OgrenciTelefon,OgrenciBolum,OgrenciDogum,IlIlce From Ogrenci where OgrenciTc=@p1",sql.Baglan());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAdSoyad.Text = dr[0].ToString();
                mskTc.Text= dr[1].ToString();
                txtMail.Text= dr[2].ToString();
                mskTel.Text= dr[3].ToString();
                txtBolum.Text= dr[4].ToString();
                mskDogum.Text= dr[5].ToString();
                txtYasadigiIl.Text = dr[6].ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select OdaNo as OdaNumara,OdaKapasite as Kapasite,OdaAktif as AktifKalanKişi from Odalar where OdaNo LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

      
    }
}
