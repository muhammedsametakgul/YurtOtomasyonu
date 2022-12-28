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
using DevExpress.Utils.DirectXPaint;


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
            txtFirma.Text = "Bireysel";
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
      
            try
            {
                if(txtOdeyen.Text !="" && mskTel.Text !="" && txtEmail.Text!="" && mskOdenenMiktar.Text != "")
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Eklemek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                       
                            SqlCommand komut = new SqlCommand("Insert into Gelir (Odeyen,OdeyenTelefon,OdeyenMail,OdemeTarih,OdemeMiktar,FirmaAdi) Values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.Baglan());
                            komut.Parameters.AddWithValue("@p1", txtOdeyen.Text);
                            komut.Parameters.AddWithValue("@p2", mskTel.Text);
                            komut.Parameters.AddWithValue("@p3", txtEmail.Text);
                            komut.Parameters.AddWithValue("@p4", dtTarih.Value.Date);
                            komut.Parameters.AddWithValue("@p5", mskOdenenMiktar.Text);


                            komut.Parameters.AddWithValue("@p6", txtFirma.Text);

                            MessageBox.Show("Başarıyla Eklendi");
                            komut.ExecuteNonQuery();
                            sql.Baglan().Close();
                            txtOdeyen.Clear();
                            mskTel.Clear();
                            txtEmail.Clear();
                            mskOdenenMiktar.Clear();
                            txtFirma.Clear();
                            txtFirma.Text = "";
        

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
                } 
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oldu !  Lütfen Tekrar Deneyiniz");
         
            }
        }

        private void mskTarih_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void mskTel_Click(object sender, EventArgs e)
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
