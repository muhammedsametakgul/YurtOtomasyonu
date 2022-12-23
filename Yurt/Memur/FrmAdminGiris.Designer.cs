namespace Yurt
{
    partial class FrmAdminGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblBaslik2 = new System.Windows.Forms.Label();
            this.lblBaslik1 = new System.Windows.Forms.Label();
            this.pbTc = new System.Windows.Forms.PictureBox();
            this.pbSifre = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkboxSifreGoster = new System.Windows.Forms.CheckBox();
            this.panelBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Teal;
            this.btnGirisYap.FlatAppearance.BorderSize = 15;
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(468, 423);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(142, 33);
            this.btnGirisYap.TabIndex = 9;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click_1);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(468, 326);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(222, 41);
            this.TxtSifre.TabIndex = 8;
            this.TxtSifre.Text = "mehmet123";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.BackColor = System.Drawing.Color.White;
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAd.Location = new System.Drawing.Point(468, 231);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(222, 41);
            this.TxtKullaniciAd.TabIndex = 7;
            this.TxtKullaniciAd.Text = "12121212123";
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.Teal;
            this.panelBaslik.Controls.Add(this.lblSaat);
            this.panelBaslik.Controls.Add(this.lblBaslik2);
            this.panelBaslik.Controls.Add(this.lblBaslik1);
            this.panelBaslik.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBaslik.Location = new System.Drawing.Point(0, 0);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(233, 643);
            this.panelBaslik.TabIndex = 10;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(47, 571);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(95, 36);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "label1";
            // 
            // lblBaslik2
            // 
            this.lblBaslik2.AutoSize = true;
            this.lblBaslik2.Font = new System.Drawing.Font("Corbel", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik2.Location = new System.Drawing.Point(3, 169);
            this.lblBaslik2.Name = "lblBaslik2";
            this.lblBaslik2.Size = new System.Drawing.Size(222, 40);
            this.lblBaslik2.TabIndex = 1;
            this.lblBaslik2.Text = "HOŞGELDİNİZ";
            // 
            // lblBaslik1
            // 
            this.lblBaslik1.AutoSize = true;
            this.lblBaslik1.Font = new System.Drawing.Font("Corbel", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik1.Location = new System.Drawing.Point(46, 116);
            this.lblBaslik1.Name = "lblBaslik1";
            this.lblBaslik1.Size = new System.Drawing.Size(135, 40);
            this.lblBaslik1.TabIndex = 0;
            this.lblBaslik1.Text = "EVİNİZE";
            // 
            // pbTc
            // 
            this.pbTc.Image = ((System.Drawing.Image)(resources.GetObject("pbTc.Image")));
            this.pbTc.Location = new System.Drawing.Point(396, 231);
            this.pbTc.Name = "pbTc";
            this.pbTc.Size = new System.Drawing.Size(45, 45);
            this.pbTc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTc.TabIndex = 11;
            this.pbTc.TabStop = false;
            // 
            // pbSifre
            // 
            this.pbSifre.Image = ((System.Drawing.Image)(resources.GetObject("pbSifre.Image")));
            this.pbSifre.Location = new System.Drawing.Point(396, 322);
            this.pbSifre.Name = "pbSifre";
            this.pbSifre.Size = new System.Drawing.Size(45, 45);
            this.pbSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSifre.TabIndex = 12;
            this.pbSifre.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkboxSifreGoster
            // 
            this.checkboxSifreGoster.AutoSize = true;
            this.checkboxSifreGoster.Location = new System.Drawing.Point(733, 335);
            this.checkboxSifreGoster.Name = "checkboxSifreGoster";
            this.checkboxSifreGoster.Size = new System.Drawing.Size(109, 20);
            this.checkboxSifreGoster.TabIndex = 14;
            this.checkboxSifreGoster.Text = "Şifreyi Göster";
            this.checkboxSifreGoster.UseVisualStyleBackColor = true;
            this.checkboxSifreGoster.CheckedChanged += new System.EventHandler(this.checkboxSifreGoster_CheckedChanged);
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 643);
            this.Controls.Add(this.checkboxSifreGoster);
            this.Controls.Add(this.pbSifre);
            this.Controls.Add(this.pbTc);
            this.Controls.Add(this.panelBaslik);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminGiris_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdminGiris_Load);
            this.panelBaslik.ResumeLayout(false);
            this.panelBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Label lblBaslik2;
        private System.Windows.Forms.Label lblBaslik1;
        private System.Windows.Forms.PictureBox pbTc;
        private System.Windows.Forms.PictureBox pbSifre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
        public System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.CheckBox checkboxSifreGoster;
        //private System.Windows.Forms.PictureBox pictureBox3;
    }
}