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
    public partial class FrmOgrenciListesi : Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();
        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Ogrenci", sql.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
