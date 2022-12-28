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
    public partial class FrmGiderEkle : Form
    {
        public FrmGiderEkle()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if(MskElektrik.Text!="" && MskDogalgaz.Text!="" && MskInternet.Text!="" && MskGida.Text!="" && MskPersonel.Text !="" && MskSu.Text !="" && MskDiger.Text !="" ) {
                DialogResult d = new DialogResult();
                d = MessageBox.Show("Eklemek İstediğnize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik,Dogalgaz,Internet,Gida,Personel,Su,Diger,GiderAy)" +
                  "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sql.Baglan());
                    komut.Parameters.AddWithValue("@p1", MskElektrik.Text);
                    komut.Parameters.AddWithValue("@p2", MskDogalgaz.Text);
                    komut.Parameters.AddWithValue("@p3", MskInternet.Text);
                    komut.Parameters.AddWithValue("@p4", MskGida.Text);
                    komut.Parameters.AddWithValue("@p5", MskPersonel.Text);
                    komut.Parameters.AddWithValue("@p6", MskSu.Text);
                    komut.Parameters.AddWithValue("@p7", MskDiger.Text);
                    komut.Parameters.AddWithValue("@p8", MskTarih.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MskElektrik.Text = "";
                    MskDogalgaz.Text = "";
                    MskInternet.Text = "";
                    MskGida.Text = "";
                    MskPersonel.Text = "";
                    MskSu.Text = "";
                    MskDiger.Text = "";
                    MskTarih.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuza Emin Olunuz");
            }
            

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

        private void FrmGiderEkle_Load(object sender, EventArgs e)
        {
            int personel=0;
            int memur=0;
            SqlCommand komut = new SqlCommand("Select Sum(PersonelMaas) From Personel ",sql.Baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                personel = Convert.ToInt32(dr[0].ToString());
            }
            SqlCommand komut2 = new SqlCommand("Select Sum(YoneticiMaas) From Admin",sql.Baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                memur = Convert.ToInt32(dr2[0].ToString());
            }
           
            MskPersonel.Text = (memur + personel).ToString();
        }
    }
}
