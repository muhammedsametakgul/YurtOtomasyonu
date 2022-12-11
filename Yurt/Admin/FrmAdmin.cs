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
using Yurt.YoneticiIslemleri;

namespace Yurt
{
    public partial class FrmAdmin : Form
    {
        FrmYoneticiSifreİslemleri frmYonetici;
        FrmPersonelEkle frmPersonelEkle;
        FrmPersonelDuzenle frmPersonelDuzenle;
        FrmPersonelListesi frmPersonelListesi;
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

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void öğrenciÖdemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciOdemeAl frm = new FrmOgrenciOdemeAl();
            frm.Show();
        }

        private void gelirListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirListesi frm = new FrmGelirListesi();
            frm.Show();
        }

        private void izinEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciIzinEkle frm = new OgrenciIzinEkle();
            frm.Show();
        }

        private void izinDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void izinEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OgrenciIzinEkle frm = new OgrenciIzinEkle();
            frm.Show();
        }

        private void izinGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzinGoster frm = new FrmIzinGoster();
            frm.Show();
        }

        private void yöneticiŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             if (frmYonetici == null || frmYonetici.IsDisposed)
             { frmYonetici=new FrmYoneticiSifreİslemleri(); frmYonetici.Show(); }//Form2 kapatılmış ise gösteriyor
             else
             {
                frmYonetici.Visible = true;//Hide ile gizlemenin etkisini kaldırıyor
             if (frmYonetici.Created) //Form oluşturulmuş ise sadece aktif ediyor
                    frmYonetici.Activate();
             }
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonelEkle == null || frmPersonelEkle.IsDisposed)
            { frmPersonelEkle = new FrmPersonelEkle(); frmPersonelEkle.Show(); }//Form2 kapatılmış ise gösteriyor
            else
            {
                frmPersonelEkle.Visible = true;//Hide ile gizlemenin etkisini kaldırıyor
                if (frmPersonelEkle.Created) //Form oluşturulmuş ise sadece aktif ediyor
                    frmPersonelEkle.Activate();
            }

        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonelDuzenle == null || frmPersonelDuzenle.IsDisposed)
            { frmPersonelDuzenle = new FrmPersonelDuzenle(); frmPersonelDuzenle.Show(); }//Form2 kapatılmış ise gösteriyor
            else
            {
                frmPersonelDuzenle.Visible = true;//Hide ile gizlemenin etkisini kaldırıyor
                if (frmPersonelDuzenle.Created) //Form oluşturulmuş ise sadece aktif ediyor
                    frmPersonelDuzenle.Activate();
            }
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonelListesi == null || frmPersonelListesi.IsDisposed)
            { frmPersonelListesi = new FrmPersonelListesi(); frmPersonelListesi.Show(); }//Form2 kapatılmış ise gösteriyor
            else
            {
                frmPersonelListesi.Visible = true;//Hide ile gizlemenin etkisini kaldırıyor
                if (frmPersonelListesi.Created) //Form oluşturulmuş ise sadece aktif ediyor
                    frmPersonelListesi.Activate();
            }
        }
    }
    }

