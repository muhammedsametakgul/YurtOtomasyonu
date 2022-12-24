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

namespace Yurt
{
    public partial class FrmGiderlerListesi : Form
    {
        public FrmGiderlerListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmGiderlerListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Elektrik,Dogalgaz,Internet,Gida,Personel,Su,Diger,GiderAy From Giderler ",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtTarihAra.Text;

            SqlDataAdapter da = new SqlDataAdapter("select * from Giderler where GiderAy LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rbAylik_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAylik.Checked) {
                SqlDataAdapter da = new SqlDataAdapter("Select Elektrik,Dogalgaz,Internet,Gida,Personel,Su,Diger,GiderAy  From Giderler ", sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void rbPersonelMaas_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPersonelMaas.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select PersonelTc,PersonelAdSoyad,PersonelMaas From Personel",sql.Baglan());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void rbMemurMaas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
