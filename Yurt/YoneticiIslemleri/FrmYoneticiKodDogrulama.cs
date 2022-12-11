using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.YoneticiIslemleri;

namespace Yurt
{
    public partial class FrmYoneticiKodDogrulama : Form
    {
        public FrmYoneticiKodDogrulama()
        {
            InitializeComponent();
        }
        public string kod_disaridan_gelen;
        string kod_iceriden;
       
        private void FrmYoneticiKodDogrulama_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            kod_iceriden = textBox1.Text;
            

            if (kod_disaridan_gelen == kod_iceriden)
            {
                YoneticiSifreGuncelle frm = new YoneticiSifreGuncelle();
                frm.Show();
                this.Close();
            }
        }
    }
}
