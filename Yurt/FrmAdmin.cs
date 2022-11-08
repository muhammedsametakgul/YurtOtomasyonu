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
using DevExpress.XtraEditors.ViewInfo;

namespace Yurt
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciEkle frm = new FrmOgrenciEkle();
          
           
            frm.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmOgrenciListesi frm = new FrmOgrenciListesi();
            frm.Show();
           
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciDuzenle frm = new FrmOgrenciDuzenle();
            frm.b = true;
            frm.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciDuzenle frm = new FrmOgrenciDuzenle();
            frm.a = true;
            frm.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumEkle frm = new FrmBolumEkle();
            frm.Show();
        }

        private void bölümSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumDuzenle frm = new FrmBolumDuzenle();
            frm.b = true;
            frm.Show();
        }

        private void bölümGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBolumDuzenle frm = new FrmBolumDuzenle();
            frm.a = true;
            frm.Show();
        }

        private void öğrenciBorçlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciBorcListesi frm = new FrmOgrenciBorcListesi();
            frm.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //çıkış yaparken kullanıcıya soruldu
            if (MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin Misiniz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi frm = new FrmGiderListesi();
            frm.Show();
            
        }

        private void giderGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void giderDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderDuzenle frm = new FrmGiderDuzenle();
            frm.Show();
        }

        private void tarayıcıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tr/?hl=tr");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void öğrenciÖdemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

