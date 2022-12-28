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

namespace Yurt.GeciciFormlar
{
    public partial class FrmGeciciAnaSayfa : Form
    {
        public FrmGeciciAnaSayfa()
        {
            InitializeComponent();
        }
        DateTime zaman=DateTime.Now;
        private void FrmGeciciAnaSayfa_Load(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Select Count(*) From Ogrenci", sql.Baglan());
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    lblSayi.Text = dr[0].ToString();
            //}
        }
    }
}
