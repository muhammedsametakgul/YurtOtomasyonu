using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.Gelir;
using Yurt.Ogrenci;
using Yurt.Personel;
using Yurt.YoneticiIslemleri;
using System.Data.SqlClient;

namespace Yurt.Admin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm = new FrmAdminGiris();
            frm.Show();
            this.Hide();
        }
        Sql sql = new Sql();
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);


            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
           
        }

        private void izinGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string tc_main;
        private void MainForm_Load(object sender, EventArgs e)
        {
            // WindowState = FormWindowState.Maximized;

            SqlCommand komut = new SqlCommand("Select Count(*) from Ogrenci ",sql.Baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblSayi.Text = dr[0].ToString();
            }

            tc_main = lblTc.Text;
            timer1.Start();

        }


        
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciEkle());
            lblBaslik.Text = "Öğrenci Ekleme";
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciSil());
            lblBaslik.Text = "Öğrenci Silme";
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciDuzenle());
            lblBaslik.Text = "Öğrenci Düzenleme";
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciListesi());
            lblBaslik.Text = "Öğrenci Listesi";
        }

        private void izinVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform( new OgrenciIzinEkle());
            lblBaslik.Text = "Öğrenci İzin Verme";
        }

        private void izinleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciIzinGoster());
            lblBaslik.Text = "Öğrenci İzin Gösterme";
        }

        private void izinDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciIzinDuzenle());
            lblBaslik.Text = "Öğrenci İzin Düzenleme";
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciOdemeAl());
            lblBaslik.Text = "Ödeme Alma";
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelEkle());
            lblBaslik.Text = "Personel Ekleme";
        }

        private void personelGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelDuzenle());
            lblBaslik.Text = "Personel Güncelleme";

        }

        private void personelListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelListesi());
            lblBaslik.Text = "Personel Listeleme";
        }

        private void izinVerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelIzinVer());
        }

        private void personelŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelSifreİslemleri());
            lblBaslik.Text = "Personel Şifre İşlemleri";
        }


    

        private void gelirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGelirEkle());
            lblBaslik.Text = "Gelir Ekleme";
        }

        private void gelirDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGelirDuzenle());
            lblBaslik.Text = "Gelir Düzenleme";
        }

        private void gelirListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGelirListesi());
            lblBaslik.Text = "Gelir Listeleme";
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGiderEkle());
            lblBaslik.Text = "Gider Ekleme";
        }

        private void giderGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGiderDuzenle());
            lblBaslik.Text = "Gider Düzenleme";
        }

        private void giderListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGiderlerListesi());
            lblBaslik.Text = "Gider Listeleme";
        }

        private void yöneticiŞifreGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmYoneticiSifreİslemleri());
            lblBaslik.Text = "Yönetici  Şifre İşlemleri";
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfilDuzenle_Click(object sender, EventArgs e)
        {
            loadform(new FrmProfilDuzenleAdmin());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void izinDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelIzinDuzenle());
        }

        private void lblSayi_Click(object sender, EventArgs e)
        {

        }
    }
    
}
