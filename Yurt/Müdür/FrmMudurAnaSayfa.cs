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
            lblBaslik.Text = "Öğrenci Ekleme";
            loadform(new FrmOgrenciEkle());
           
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci Silme";
            loadform(new FrmOgrenciDuzenle());
            
            
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci Düzenleme";
            loadform(new FrmOgrenciDuzenle());
        
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci Listesi";
            loadform(new FrmOgrenciListesi());
           
        }

        private void öğrenciİzinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izinVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci İzin Verme";
            loadform(new FrmOgrenciIzinEkle());
       
           
        }

        private void izinleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci İzin Gösterme";
            loadform(new FrmOgrenciIzinGoster());
         
        }

        private void izinDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci İzin Düzenleme";
            loadform(new FrmOgrenciIzinDuzenle());
         
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel Ekleme";
            loadform(new FrmPersonelEkle());
           
        }

        private void personelGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel Güncelleme";
            loadform(new FrmPersonelDuzenle());
          
        }

        private void personelListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel Listeleme";
            loadform(new FrmPersonelListesi());
           
        }

        private void izinVerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel İzin Verme";
            loadform(new FrmPersonelIzinVer());
           
        }

        private void izinGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel İzin Listesi";
            loadform(new FrmPersonelIzinListesi());
        
        }

        private void izinDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel İzin Düzenle";
            loadform(new FrmPersonelIzinDuzenle());
      
        }

       
       

        private void gelirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Gelir Ekleme";
            loadform(new Gelir.FrmGelirEkle() );
          
        }

        private void gelirDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Gelir Güncelleme";
            loadform(new Gelir.FrmGelirDuzenle());
           
        }

        private void gelirListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Gelir Listesi";
            loadform(new FrmGelirListesi());
           
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Gider Ekleme";
           
            loadform(new FrmGiderEkle());
           
        }

        private void giderGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Gider  Düzenleme";
            loadform(new FrmGiderDuzenle());
        
        }

        private void giderListesiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Gider Listesi";
            loadform(new FrmGiderlerListesi());
            
        }

        private void yöneticiŞifreGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiSifreGuncelle frm = new FrmYoneticiSifreGuncelle();
            frm.ShowDialog();
           
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Ödeme Alma";
            loadform(new FrmOgrenciOdemeAl());
            
        }
        public static string tcAna;
        private void FrmMudurAnaSayfa_Load(object sender, EventArgs e)
        {
             WindowState = FormWindowState.Maximized;
            btnSikayetGoruntule.Focus();
            loadform(new GeciciFormlar.FrmGeciciAnaSayfa());
            tcAna = lblTCC.Text;

           
        }

        private void FrmMudurAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Memur Ekle";
            loadform(new FrmAdminIslemleri());
           
        }

        private void yöneticiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Memur Düzenle";
            loadform(new FrmAdminİslemleriGuncelleme());
            
        }

        private void yöneticiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Memur Listesi";
            loadform(new FrmYoneticiListesi());
            
        }

        private void FrmMudurAnaSayfa_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           AnaGiris frm = new AnaGiris();
            frm.Show();
            this.Hide();
        }

        private void gelirİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciÖdemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci Ödeme Alma";
            loadform(new FrmOgrenciOdemeAl());
        }

        private void odaListesiGörmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Oda Listesi";
            loadform(new FrmOdaListesi());
          
        }

        private void btnHesapMakina_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
            int sayac = 0;
        private void btnSikayetGoruntule_Click(object sender, EventArgs e)
        {
            sayac++;
            if(sayac %2 == 0)
            {
                lblBaslik.Text = "HOŞGELDİNİZ";
                mainpanel.Controls.Clear();
            }
            else
            {

                lblBaslik.Text = "Yurt Şikayet/Öneri/Haberleşme";
                loadform(new Sikayetler.FrmMudurSikayet());
            }
           

          
        }

        private void memurPersonelMaaşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Maaş İşlemleri";
            loadform(new FrmMaasİslemleri());
           
        }

        private void yurtÜcretiBelirlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Yurt Ücreti Belirleme";
            loadform(new Gelir.FrmYurtUcreti());
           
          


        }

        private void yöneticiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izinVerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci İzin Ekleme";
            loadform(new FrmOgrenciIzinEkle());
            
        }

        private void izinDüzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci İzin Düzenleme";
            loadform(new FrmOgrenciIzinDuzenle());
         
        }

        private void izinListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Öğrenci İzin Listeleme";
            loadform(new FrmOgrenciIzinGoster());
          
        }

        private void izinVerToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Memur/Personel İzin Verme";
            loadform(new FrmPersonelIzinVer());
           
        }

        private void izinDüzenleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Memur/Personel İzin Düzenle";
            loadform(new FrmPersonelIzinDuzenle());
           
        }

        private void izinListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Memur/Personel İzin Listesi";
            loadform(new FrmPersonelIzinListesi());
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void öğrenciİşlemleriToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            öğrenciİzinİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void öğrenciİşlemleriToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            öğrenciİzinİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void öğrenciİşlemleriToolStripMenuItem_DropDownOpened_1(object sender, EventArgs e)
        {
            öğrenciİşlemleriToolStripMenuItem.ForeColor= Color.Black;
         


        }

        private void öğrenciİşlemleriToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            öğrenciİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void personelİşlemleriToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            personelİşlemleriToolStripMenuItem.ForeColor = Color.Black;
           
        }

        private void personelİşlemleriToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            personelİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void yöneticiİşlemleriToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            yöneticiİşlemleriToolStripMenuItem.ForeColor=Color.Black;
        }

        private void yöneticiİşlemleriToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            yöneticiİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void gelirİşlemleriToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            gelirİşlemleriToolStripMenuItem.ForeColor
                = Color.Black;
        }

        private void gelirİşlemleriToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            gelirİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void giderİşlemleriToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            giderİşlemleriToolStripMenuItem.ForeColor=Color.Black;
        }

        private void giderİşlemleriToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            giderİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void izinİşlemleriToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            izinİşlemleriToolStripMenuItem.ForeColor = Color.Black;
        }

        private void izinİşlemleriToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            izinİşlemleriToolStripMenuItem.ForeColor=Color.Black;
        }

        private void FrmMudurAnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("a");
            }
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Hakkımızda";
            loadform(new GeciciFormlar.FrmHakkimizda());
        }

        private void btnProfilDuzenle_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Profili Düzenle";
            loadform(new FrmProfilDuzenle());
        }
    }
    }

