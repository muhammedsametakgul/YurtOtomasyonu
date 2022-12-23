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

namespace Yurt.Müdür
{
    public partial class FrmYoneticiListesi : Form
    {
        public FrmYoneticiListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void FrmYoneticiListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da= new SqlDataAdapter("Select * From Admin",sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from Admin where YoneticiAd LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
