using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.Müdür;

namespace Yurt
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm = new FrmAdminGiris();
            frm.Show();
            this.Hide();
        }

        private void AnaGiris_Load(object sender, EventArgs e)
        {
            btnMudurGiris.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMudurGiris frm = new FrmMudurGiris();
            frm.Show();
            this.Hide();
        }

        private void AnaGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
