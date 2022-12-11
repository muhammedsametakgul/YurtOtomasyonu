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
            SqlDataAdapter da = new SqlDataAdapter("select * from Personeller where PersonelAdSoyad LIKE '%" + TxtAdAra.Text + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

   

        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Personeller",sql.Baglan());
            DataTable d = new DataTable();
            da.Fill(d);
            dataGridView1.DataSource = d;
        }
    }
}
