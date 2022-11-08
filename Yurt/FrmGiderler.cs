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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik,Dogalgaz,Internet,Gida,Personel,Su,Diger,GiderAy)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",sql.Baglan());
            komut.Parameters.AddWithValue("@p1", MskElektrik.Text);
            komut.Parameters.AddWithValue("@p2", MskDogalgaz.Text);
            komut.Parameters.AddWithValue("@p3", MskInternet.Text);
            komut.Parameters.AddWithValue("@p4",MskGida.Text);
            komut.Parameters.AddWithValue("@p5",MskPersonel.Text);
            komut.Parameters.AddWithValue("@p6",MskSu.Text);
            komut.Parameters.AddWithValue("@p7",MskDiger.Text);
            komut.Parameters.AddWithValue("@p8",MskTarih.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
