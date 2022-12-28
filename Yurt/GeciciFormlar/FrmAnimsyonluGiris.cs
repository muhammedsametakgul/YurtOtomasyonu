using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt
{
    public partial class FrmAnimsyonluGiris : Form
    {
        int sayac = 0;
        public FrmAnimsyonluGiris()
        {
            InitializeComponent();
        }
        bool islem = false;

        private void FrmAnimsyonluGiris_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.009;
                if (this.Opacity == 0)
                {
                    AnaGiris frm = new AnaGiris();
                    frm.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
