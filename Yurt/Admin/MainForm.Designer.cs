namespace Yurt.Admin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ogrenci_ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİzinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGüncelleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİzinİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinVerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izinGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelŞifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderGüncelleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListesiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiŞifreGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirDüzenleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirListesiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1055);
            this.panel1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(43, 520);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(152, 35);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Merhaba";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1680, 53);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.gelirİşlemleriToolStripMenuItem,
            this.giderİşlemleriToolStripMenuItem,
            this.yöneticiİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1680, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ogrenci_ekle,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem,
            this.öğrenciİzinToolStripMenuItem,
            this.ödemeAlToolStripMenuItem});
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // menu_ogrenci_ekle
            // 
            this.menu_ogrenci_ekle.Name = "menu_ogrenci_ekle";
            this.menu_ogrenci_ekle.Size = new System.Drawing.Size(235, 26);
            this.menu_ogrenci_ekle.Text = "Öğrenci Ekle";
            this.menu_ogrenci_ekle.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.bToolStripMenuItem.Text = "Öğrenci Sil";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.cToolStripMenuItem.Text = "Öğrenci Güncelle";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.dToolStripMenuItem.Text = "Öğrenci Listesi Göster";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // öğrenciİzinToolStripMenuItem
            // 
            this.öğrenciİzinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izinVerToolStripMenuItem,
            this.izinleriGösterToolStripMenuItem,
            this.izinDüzenleToolStripMenuItem});
            this.öğrenciİzinToolStripMenuItem.Name = "öğrenciİzinToolStripMenuItem";
            this.öğrenciİzinToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.öğrenciİzinToolStripMenuItem.Text = "Öğrenci İzin İşlemleri";
            // 
            // izinVerToolStripMenuItem
            // 
            this.izinVerToolStripMenuItem.Name = "izinVerToolStripMenuItem";
            this.izinVerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izinVerToolStripMenuItem.Text = "İzin Ver";
            this.izinVerToolStripMenuItem.Click += new System.EventHandler(this.izinVerToolStripMenuItem_Click);
            // 
            // izinleriGösterToolStripMenuItem
            // 
            this.izinleriGösterToolStripMenuItem.Name = "izinleriGösterToolStripMenuItem";
            this.izinleriGösterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izinleriGösterToolStripMenuItem.Text = "İzinleri Göster";
            this.izinleriGösterToolStripMenuItem.Click += new System.EventHandler(this.izinleriGösterToolStripMenuItem_Click);
            // 
            // izinDüzenleToolStripMenuItem
            // 
            this.izinDüzenleToolStripMenuItem.Name = "izinDüzenleToolStripMenuItem";
            this.izinDüzenleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izinDüzenleToolStripMenuItem.Text = "İzin Düzenle";
            this.izinDüzenleToolStripMenuItem.Click += new System.EventHandler(this.izinDüzenleToolStripMenuItem_Click);
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            this.ödemeAlToolStripMenuItem.Click += new System.EventHandler(this.ödemeAlToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelGüncelleSilToolStripMenuItem,
            this.personelListesiGösterToolStripMenuItem,
            this.personelİzinİşlemleriToolStripMenuItem,
            this.personelŞifreİşlemleriToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelGüncelleSilToolStripMenuItem
            // 
            this.personelGüncelleSilToolStripMenuItem.Name = "personelGüncelleSilToolStripMenuItem";
            this.personelGüncelleSilToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.personelGüncelleSilToolStripMenuItem.Text = "Personel Güncelle/Sil";
            this.personelGüncelleSilToolStripMenuItem.Click += new System.EventHandler(this.personelGüncelleSilToolStripMenuItem_Click);
            // 
            // personelListesiGösterToolStripMenuItem
            // 
            this.personelListesiGösterToolStripMenuItem.Name = "personelListesiGösterToolStripMenuItem";
            this.personelListesiGösterToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.personelListesiGösterToolStripMenuItem.Text = "Personel Listesi Göster";
            this.personelListesiGösterToolStripMenuItem.Click += new System.EventHandler(this.personelListesiGösterToolStripMenuItem_Click);
            // 
            // personelİzinİşlemleriToolStripMenuItem
            // 
            this.personelİzinİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izinVerToolStripMenuItem1,
            this.izinGösterToolStripMenuItem});
            this.personelİzinİşlemleriToolStripMenuItem.Name = "personelİzinİşlemleriToolStripMenuItem";
            this.personelİzinİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.personelİzinİşlemleriToolStripMenuItem.Text = "Personel İzin İşlemleri";
            // 
            // izinVerToolStripMenuItem1
            // 
            this.izinVerToolStripMenuItem1.Name = "izinVerToolStripMenuItem1";
            this.izinVerToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.izinVerToolStripMenuItem1.Text = "İzin Ver";
            this.izinVerToolStripMenuItem1.Click += new System.EventHandler(this.izinVerToolStripMenuItem1_Click);
            // 
            // izinGösterToolStripMenuItem
            // 
            this.izinGösterToolStripMenuItem.Name = "izinGösterToolStripMenuItem";
            this.izinGösterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izinGösterToolStripMenuItem.Text = "İzinleri Listele";
            this.izinGösterToolStripMenuItem.Click += new System.EventHandler(this.izinGösterToolStripMenuItem_Click);
            // 
            // personelŞifreİşlemleriToolStripMenuItem
            // 
            this.personelŞifreİşlemleriToolStripMenuItem.Name = "personelŞifreİşlemleriToolStripMenuItem";
            this.personelŞifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.personelŞifreİşlemleriToolStripMenuItem.Text = "Personel Şifre Güncelleme";
            this.personelŞifreİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelŞifreİşlemleriToolStripMenuItem_Click);
            // 
            // giderİşlemleriToolStripMenuItem
            // 
            this.giderİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderGüncelleSilToolStripMenuItem,
            this.giderListesiGösterToolStripMenuItem});
            this.giderİşlemleriToolStripMenuItem.Name = "giderİşlemleriToolStripMenuItem";
            this.giderİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.giderİşlemleriToolStripMenuItem.Text = "Gider İşlemleri";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            this.giderEkleToolStripMenuItem.Click += new System.EventHandler(this.giderEkleToolStripMenuItem_Click);
            // 
            // giderGüncelleSilToolStripMenuItem
            // 
            this.giderGüncelleSilToolStripMenuItem.Name = "giderGüncelleSilToolStripMenuItem";
            this.giderGüncelleSilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giderGüncelleSilToolStripMenuItem.Text = "Gider Güncelle/Sil";
            this.giderGüncelleSilToolStripMenuItem.Click += new System.EventHandler(this.giderGüncelleSilToolStripMenuItem_Click);
            // 
            // giderListesiGösterToolStripMenuItem
            // 
            this.giderListesiGösterToolStripMenuItem.Name = "giderListesiGösterToolStripMenuItem";
            this.giderListesiGösterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giderListesiGösterToolStripMenuItem.Text = "Gider Listesi Göster";
            this.giderListesiGösterToolStripMenuItem.Click += new System.EventHandler(this.giderListesiGösterToolStripMenuItem_Click);
            // 
            // yöneticiİşlemleriToolStripMenuItem
            // 
            this.yöneticiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiŞifreGüncellemeToolStripMenuItem});
            this.yöneticiİşlemleriToolStripMenuItem.Name = "yöneticiİşlemleriToolStripMenuItem";
            this.yöneticiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.yöneticiİşlemleriToolStripMenuItem.Text = "Yönetici İşlemleri";
            // 
            // yöneticiŞifreGüncellemeToolStripMenuItem
            // 
            this.yöneticiŞifreGüncellemeToolStripMenuItem.Name = "yöneticiŞifreGüncellemeToolStripMenuItem";
            this.yöneticiŞifreGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.yöneticiŞifreGüncellemeToolStripMenuItem.Text = "Yönetici Şifre Güncelleme";
            this.yöneticiŞifreGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.yöneticiŞifreGüncellemeToolStripMenuItem_Click);
            // 
            // gelirİşlemleriToolStripMenuItem
            // 
            this.gelirİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirEkleToolStripMenuItem,
            this.gelirDüzenleSilToolStripMenuItem,
            this.gelirListesiGösterToolStripMenuItem});
            this.gelirİşlemleriToolStripMenuItem.Name = "gelirİşlemleriToolStripMenuItem";
            this.gelirİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.gelirİşlemleriToolStripMenuItem.Text = "Gelir İşlemleri";
            // 
            // gelirEkleToolStripMenuItem
            // 
            this.gelirEkleToolStripMenuItem.Name = "gelirEkleToolStripMenuItem";
            this.gelirEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gelirEkleToolStripMenuItem.Text = "Gelir Ekle";
            this.gelirEkleToolStripMenuItem.Click += new System.EventHandler(this.gelirEkleToolStripMenuItem_Click);
            // 
            // gelirDüzenleSilToolStripMenuItem
            // 
            this.gelirDüzenleSilToolStripMenuItem.Name = "gelirDüzenleSilToolStripMenuItem";
            this.gelirDüzenleSilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gelirDüzenleSilToolStripMenuItem.Text = "Gelir Düzenle/Sil";
            this.gelirDüzenleSilToolStripMenuItem.Click += new System.EventHandler(this.gelirDüzenleSilToolStripMenuItem_Click);
            // 
            // gelirListesiGösterToolStripMenuItem
            // 
            this.gelirListesiGösterToolStripMenuItem.Name = "gelirListesiGösterToolStripMenuItem";
            this.gelirListesiGösterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gelirListesiGösterToolStripMenuItem.Text = "Gelir Listesi Göster";
            this.gelirListesiGösterToolStripMenuItem.Click += new System.EventHandler(this.gelirListesiGösterToolStripMenuItem_Click);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.lblBaslik);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(240, 53);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1680, 46);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(240, 99);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1680, 956);
            this.mainpanel.TabIndex = 3;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(17, 7);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(253, 36);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "HOŞGELDİNİZ...";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(125, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 28);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_ogrenci_ekle;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİzinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGüncelleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİzinİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinVerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izinGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelŞifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderGüncelleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListesiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiŞifreGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirDüzenleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirListesiGösterToolStripMenuItem;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel mainpanel;
        public System.Windows.Forms.Label lblName;
    }
}