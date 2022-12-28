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
    enum aylar 
    {   Ocak=1,
        Şubat,
        Mart,
        Nisan,
        Mayıs,
        Haziran,
        Temmuz,
        Ağustos,
        Eylül,
        Ekim,
        Kasım,
        Aralık

    }
    public partial class FrmGelirListesi : Form
    {
        public FrmGelirListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmGelirListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi From Gelir",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
          
            dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
            dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[2].HeaderText = "Mail";
            dataGridView1.Columns[3].HeaderText = "Tarih";
            dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
            dataGridView1.Columns[5].HeaderText = "Firma Adı";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi from Gelir where Odeyen LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
            dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[2].HeaderText = "Mail";
            dataGridView1.Columns[3].HeaderText = "Tarih";
            dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
            dataGridView1.Columns[5].HeaderText = "Firma Adı";
            if (rbBireysel.Checked)
            {


                SqlDataAdapter da2 = new SqlDataAdapter("select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi from Gelir where Odeyen  LIKE '%" + ara + "%' and FirmaAdi='Bireysel'", sql.Baglan());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
                dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
                dataGridView1.Columns[2].HeaderText = "Mail";
                dataGridView1.Columns[3].HeaderText = "Tarih";
                dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
                dataGridView1.Columns[5].HeaderText = "Firma Adı";
            }
            if (rbFirma.Checked)
            {

                SqlDataAdapter da2 = new SqlDataAdapter("select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi from Gelir where Odeyen  LIKE '%" + ara + "%' and FirmaAdi !='Bireysel'", sql.Baglan());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
                dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
                dataGridView1.Columns[2].HeaderText = "Mail";
                dataGridView1.Columns[3].HeaderText = "Tarih";
                dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
                dataGridView1.Columns[5].HeaderText = "Firma Adı";
            }
        }


        private void txtTarih_TextChanged(object sender, EventArgs e)
        {
            string ara = txtTarih.Text;


            SqlDataAdapter da = new SqlDataAdapter("select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi from Gelir where OdemeTarih LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
            dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[2].HeaderText = "Mail";
            dataGridView1.Columns[3].HeaderText = "Tarih";
            dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
            dataGridView1.Columns[5].HeaderText = "Firma Adı";
            if (rbBireysel.Checked)
            {
                

                SqlDataAdapter da2 = new SqlDataAdapter("select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi from Gelir where OdemeTarih LIKE '%" + ara + "%' and FirmaAdi='Bireysel'", sql.Baglan());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
                dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
                dataGridView1.Columns[2].HeaderText = "Mail";
                dataGridView1.Columns[3].HeaderText = "Tarih";
                dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
                dataGridView1.Columns[5].HeaderText = "Firma Adı";
            }
            if (rbFirma.Checked)
            {

                SqlDataAdapter da2 = new SqlDataAdapter("select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi from Gelir where OdemeTarih LIKE '%" + ara + "%' and FirmaAdi !='Bireysel'", sql.Baglan());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
                dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
                dataGridView1.Columns[2].HeaderText = "Mail";
                dataGridView1.Columns[3].HeaderText = "Tarih";
                dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
                dataGridView1.Columns[5].HeaderText = "Firma Adı";
            }
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBireysel.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi From Gelir Where FirmaAdi='Bireysel'", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
                dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
                dataGridView1.Columns[2].HeaderText = "Mail";
                dataGridView1.Columns[3].HeaderText = "Tarih";
                dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
                dataGridView1.Columns[5].HeaderText = "Firma Adı";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi From Gelir", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            rbFirma.Checked = false;
            rbBireysel.Checked = false;
            txtAra.Clear();
            txtTarih.Clear();
        }

        private void rbFirma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFirma.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi From Gelir Where FirmaAdi!='Bireysel' ", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "Ödeyen Kişi";
                dataGridView1.Columns[1].HeaderText = "Telefon Numarası";
                dataGridView1.Columns[2].HeaderText = "Mail";
                dataGridView1.Columns[3].HeaderText = "Tarih";
                dataGridView1.Columns[4].HeaderText = "Ödeme Miktarı";
                dataGridView1.Columns[5].HeaderText = "Firma Adı";
            }
        }
    }
}
