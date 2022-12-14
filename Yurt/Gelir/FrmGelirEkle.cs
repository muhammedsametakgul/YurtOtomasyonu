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


namespace Yurt.Gelir
{
    public partial class FrmGelirEkle : Form
    {
        public FrmGelirEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            txtFirma.Visible = false;
            lblFirma.Visible = false;
        }

        private void rbFirma_CheckedChanged(object sender, EventArgs e)
        {
            txtFirma.Visible = true;
            lblFirma.Visible = true;
        }

        private void FrmGelirEkle_Load(object sender, EventArgs e)
        {
            txtFirma.Visible = false;
            lblFirma.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Gelir (Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi) Values (@p1,@p2,@p3,@p4,@p5,@p6)",sql.Baglan() );
            komut.Parameters.AddWithValue("@p1",txtOdeyen.Text);
            komut.Parameters.AddWithValue("@p2",mskTel.Text);
            komut.Parameters.AddWithValue("@p3",txtEmail.Text);
            komut.Parameters.AddWithValue("@p4",mskTarih.Text);
            komut.Parameters.AddWithValue("@p5",txtOdenen.Text);
            if (rbFirma.Checked)
            {
                komut.Parameters.AddWithValue("@p6",txtFirma.Text);
            }
            MessageBox.Show("başarıyla eklendi");
            komut.ExecuteNonQuery();
            sql.Baglan().Close();
            
        }
    }
}
