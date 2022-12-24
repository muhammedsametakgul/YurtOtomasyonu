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
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Eklemek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into Personel (PersonelTc,PersonelAdSoyad,PersonelDepartman,PersonelTelefon,PersonelMail,PersonelAdres,PersonelDogumTarihi,PersonelMaas) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sql.Baglan());
                komut.Parameters.AddWithValue("@p1", MskTc.Text);
                komut.Parameters.AddWithValue("@p2", TxtAd.Text.ToUpper());
                komut.Parameters.AddWithValue("@p3", CmbDep.Text);
                komut.Parameters.AddWithValue("@p4", mskTel.Text);
                komut.Parameters.AddWithValue("@p5", txtMail.Text);
                komut.Parameters.AddWithValue("@p6", TxtAdres.Text);
                komut.Parameters.AddWithValue("@p7", mskDogum.Text);
                komut.Parameters.AddWithValue("@p8",mskMaas.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla eklendi");
                sql.Baglan().Close();
            }
        }

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {

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

        private void mskTel_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void mskDogum_Click(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox.Focus();
            if (textBox != null)
            {

                textBox.Select(0, 0);

            }
        }

        private void mskDogum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
