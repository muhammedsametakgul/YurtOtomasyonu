using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.Ogrenci;
using Yurt.Personel;
using Yurt.YoneticiIslemleri;
using System.Data.SqlClient;

namespace Yurt.Müdür
{
    public partial class FrmMudurAnaSayfa : Form
    {
        public FrmMudurAnaSayfa()
        {
            InitializeComponent();
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
        private void menu_ogrenci_ekle_Click(object sender, EventArgs e)
        {
           
            loadform(new FrmOgrenciEkle());
            lblBaslik.Text = "Öğrenci Ekleme";
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            loadform(new FrmOgrenciDuzenle());
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

        private void öğrenciİzinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izinVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            loadform(new FrmOgrenciIzinEkle());
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
            lblBaslik.Text = "Personel İzin Verme";
        }

        private void izinGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelIzinListesi());
            lblBaslik.Text = "Personel İzin Listesi";
        }

        private void izinDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelIzinDuzenle());
            lblBaslik.Text = "Personel İzin Düzenle";
        }

        private void personelŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmPersonelSifreİslemleri ());
            lblBaslik.Text = "Personel Şifre İşlemleri";
        }

        private void gelirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Gelir.FrmGelirEkle() );
            lblBaslik.Text = "Gelir Ekleme";
        }

        private void gelirDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Gelir.FrmGelirDuzenle());
            lblBaslik.Text = "Gelir Düzenleme";
        }

        private void gelirListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGelirListesi());
            lblBaslik.Text = "Gelir Listesi";
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGiderEkle());
            lblBaslik.Text = "Gider Ekleme";
        }

        private void giderGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGiderDuzenle());
            lblBaslik.Text = "Gider  Düzenleme";
        }

        private void giderListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmGiderlerListesi());
            lblBaslik.Text = "Gider Listesi";
        }

        private void yöneticiŞifreGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmYoneticiSifreİslemleri());
            lblBaslik.Text = "Yönetici Şifre İşlemleri";
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciOdemeAl());
            lblBaslik.Text = "Ödeme Alma";
        }

        private void FrmMudurAnaSayfa_Load(object sender, EventArgs e)
        {
             WindowState = FormWindowState.Maximized;
            SqlCommand komut = new SqlCommand("Select Count(*) From Ogrenci",sql.Baglan());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblSayi.Text = dr[0].ToString();
            }
           
        }

        private void FrmMudurAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmAdminIslemleri());
            lblBaslik.Text = "Yönetici Ekle";
        }

        private void yöneticiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmAdminIslemleri());
            lblBaslik.Text = "Yönetici Düzenle";
        }

        private void yöneticiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmYoneticiListesi());
            lblBaslik.Text = "Yönetici Listesi";
        }

        private void FrmMudurAnaSayfa_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           FrmMudurGiris frm = new FrmMudurGiris();
            frm.Show();
            this.Hide();
        }

        private void gelirİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciÖdemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOgrenciOdemeAl());
        }

        private void odaListesiGörmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmOdaListesi());
            lblBaslik.Text = "Oda Listesi";
        }

        private void btnHesapMakina_Click(object sender, EventArgs e)
        {

        }

        private void btnSikayetGoruntule_Click(object sender, EventArgs e)
        {
            loadform(new Sikayetler.FrmSikayet());
            lblBaslik.Text = "Yurt Şikayet/Öneri/Haberleşme";
        }
    }
}
