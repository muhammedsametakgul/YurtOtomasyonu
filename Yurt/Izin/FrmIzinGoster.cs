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
    public partial class FrmIzinGoster : Form
    {
        public FrmIzinGoster()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmIzinGoster_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From OgrenciIzin",sql.Baglan());
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ara = TxtAra.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from OgrenciIzin where OgrenciAdSoyad LIKE '%" + ara + "%'", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
