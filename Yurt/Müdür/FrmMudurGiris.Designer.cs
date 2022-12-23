namespace Yurt.Müdür
{
    partial class FrmMudurGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMudurGiris));
            this.checkboxSifreGoster = new System.Windows.Forms.CheckBox();
            this.pbSifre = new System.Windows.Forms.PictureBox();
            this.pbTc = new System.Windows.Forms.PictureBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTc)).BeginInit();
            this.SuspendLayout();
            // 
            // checkboxSifreGoster
            // 
            this.checkboxSifreGoster.AutoSize = true;
            this.checkboxSifreGoster.Location = new System.Drawing.Point(624, 268);
            this.checkboxSifreGoster.Name = "checkboxSifreGoster";
            this.checkboxSifreGoster.Size = new System.Drawing.Size(109, 20);
            this.checkboxSifreGoster.TabIndex = 20;
            this.checkboxSifreGoster.Text = "Şifreyi Göster";
            this.checkboxSifreGoster.UseVisualStyleBackColor = true;
            this.checkboxSifreGoster.CheckedChanged += new System.EventHandler(this.checkboxSifreGoster_CheckedChanged);
            // 
            // pbSifre
            // 
            this.pbSifre.Image = ((System.Drawing.Image)(resources.GetObject("pbSifre.Image")));
            this.pbSifre.Location = new System.Drawing.Point(287, 255);
            this.pbSifre.Name = "pbSifre";
            this.pbSifre.Size = new System.Drawing.Size(45, 45);
            this.pbSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSifre.TabIndex = 19;
            this.pbSifre.TabStop = false;
            // 
            // pbTc
            // 
            this.pbTc.Image = ((System.Drawing.Image)(resources.GetObject("pbTc.Image")));
            this.pbTc.Location = new System.Drawing.Point(287, 164);
            this.pbTc.Name = "pbTc";
            this.pbTc.Size = new System.Drawing.Size(45, 45);
            this.pbTc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTc.TabIndex = 18;
            this.pbTc.TabStop = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Teal;
            this.btnGirisYap.FlatAppearance.BorderSize = 15;
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(359, 356);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(142, 33);
            this.btnGirisYap.TabIndex = 17;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click_1);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(359, 259);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(222, 41);
            this.TxtSifre.TabIndex = 16;
            this.TxtSifre.Text = "admin123";
            this.TxtSifre.UseSystemPasswordChar = true;
            this.TxtSifre.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.BackColor = System.Drawing.Color.White;
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAd.Location = new System.Drawing.Point(359, 164);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(222, 41);
            this.TxtKullaniciAd.TabIndex = 15;
            this.TxtKullaniciAd.Text = "admin123";
            // 
            // FrmMudurGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 535);
            this.Controls.Add(this.checkboxSifreGoster);
            this.Controls.Add(this.pbSifre);
            this.Controls.Add(this.pbTc);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMudurGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMudurGiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMudurGiris_FormClosed);
            this.Load += new System.EventHandler(this.FrmMudurGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxSifreGoster;
        private System.Windows.Forms.PictureBox pbSifre;
        private System.Windows.Forms.PictureBox pbTc;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox TxtSifre;
        public System.Windows.Forms.TextBox TxtKullaniciAd;
    }
}