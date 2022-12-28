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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxSifreGoster = new System.Windows.Forms.CheckBox();
            this.pbSifre = new System.Windows.Forms.PictureBox();
            this.pbTc = new System.Windows.Forms.PictureBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // checkboxSifreGoster
            // 
            this.checkboxSifreGoster.AutoSize = true;
            this.checkboxSifreGoster.Location = new System.Drawing.Point(116, 213);
            this.checkboxSifreGoster.Name = "checkboxSifreGoster";
            this.checkboxSifreGoster.Size = new System.Drawing.Size(109, 20);
            this.checkboxSifreGoster.TabIndex = 30;
            this.checkboxSifreGoster.Text = "Şifreyi Göster";
            this.checkboxSifreGoster.UseVisualStyleBackColor = true;
            this.checkboxSifreGoster.CheckedChanged += new System.EventHandler(this.checkboxSifreGoster_CheckedChanged_1);
            // 
            // pbSifre
            // 
            this.pbSifre.Image = ((System.Drawing.Image)(resources.GetObject("pbSifre.Image")));
            this.pbSifre.Location = new System.Drawing.Point(44, 151);
            this.pbSifre.Name = "pbSifre";
            this.pbSifre.Size = new System.Drawing.Size(45, 45);
            this.pbSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSifre.TabIndex = 29;
            this.pbSifre.TabStop = false;
            // 
            // pbTc
            // 
            this.pbTc.Image = ((System.Drawing.Image)(resources.GetObject("pbTc.Image")));
            this.pbTc.Location = new System.Drawing.Point(44, 74);
            this.pbTc.Name = "pbTc";
            this.pbTc.Size = new System.Drawing.Size(45, 45);
            this.pbTc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTc.TabIndex = 28;
            this.pbTc.TabStop = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Black;
            this.btnGirisYap.FlatAppearance.BorderSize = 15;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(459, 213);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(110, 41);
            this.btnGirisYap.TabIndex = 27;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.ForeColor = System.Drawing.Color.Black;
            this.TxtSifre.Location = new System.Drawing.Point(116, 155);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(453, 41);
            this.TxtSifre.TabIndex = 26;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(116, 75);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(453, 41);
            this.mskTc.TabIndex = 34;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(113, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 16);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMudurGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkboxSifreGoster);
            this.Controls.Add(this.pbSifre);
            this.Controls.Add(this.pbTc);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMudurGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜDÜR GİRİŞ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMudurGiris_FormClosed);
            this.Load += new System.EventHandler(this.FrmMudurGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxSifreGoster;
        private System.Windows.Forms.PictureBox pbSifre;
        private System.Windows.Forms.PictureBox pbTc;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}