namespace Yurt.YoneticiIslemleri
{
    partial class FrmPersonelEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.CmbDep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.gbPersonelEkle = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskMaas = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYemekhane = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGuvenlik = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblKatGorevlisi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbPersonelEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(184, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(273, 123);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(382, 34);
            this.TxtAd.TabIndex = 2;
            this.TxtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(273, 54);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(382, 34);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTc_MaskInputRejected);
            this.MskTc.Click += new System.EventHandler(this.MskTc_Click);
            // 
            // CmbDep
            // 
            this.CmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDep.FormattingEnabled = true;
            this.CmbDep.Items.AddRange(new object[] {
            "Yemekhane",
            "Kat Görevlisi",
            "Güvenlik"});
            this.CmbDep.Location = new System.Drawing.Point(273, 192);
            this.CmbDep.Name = "CmbDep";
            this.CmbDep.Size = new System.Drawing.Size(382, 37);
            this.CmbDep.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departman:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(410, 418);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(172, 38);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(181, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres:";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdres.Location = new System.Drawing.Point(292, 178);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(382, 206);
            this.TxtAdres.TabIndex = 8;
            this.TxtAdres.Text = "";
            // 
            // gbPersonelEkle
            // 
            this.gbPersonelEkle.Controls.Add(this.label11);
            this.gbPersonelEkle.Controls.Add(this.mskMaas);
            this.gbPersonelEkle.Controls.Add(this.label8);
            this.gbPersonelEkle.Controls.Add(this.mskDogum);
            this.gbPersonelEkle.Controls.Add(this.label4);
            this.gbPersonelEkle.Controls.Add(this.label1);
            this.gbPersonelEkle.Controls.Add(this.TxtAd);
            this.gbPersonelEkle.Controls.Add(this.MskTc);
            this.gbPersonelEkle.Controls.Add(this.CmbDep);
            this.gbPersonelEkle.Controls.Add(this.label2);
            this.gbPersonelEkle.Controls.Add(this.label3);
            this.gbPersonelEkle.Location = new System.Drawing.Point(12, 26);
            this.gbPersonelEkle.Name = "gbPersonelEkle";
            this.gbPersonelEkle.Size = new System.Drawing.Size(719, 462);
            this.gbPersonelEkle.TabIndex = 12;
            this.gbPersonelEkle.TabStop = false;
            this.gbPersonelEkle.Text = "Personel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // mskMaas
            // 
            this.mskMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskMaas.Location = new System.Drawing.Point(273, 330);
            this.mskMaas.Mask = "00000000000";
            this.mskMaas.Name = "mskMaas";
            this.mskMaas.Size = new System.Drawing.Size(382, 34);
            this.mskMaas.TabIndex = 5;
            this.mskMaas.ValidatingType = typeof(int);
            this.mskMaas.Click += new System.EventHandler(this.mskMaas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(157, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Maaş:";
            // 
            // mskDogum
            // 
            this.mskDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(273, 261);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(382, 34);
            this.mskDogum.TabIndex = 4;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            this.mskDogum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDogum_MaskInputRejected);
            this.mskDogum.Click += new System.EventHandler(this.mskDogum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTel);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAdres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(754, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 462);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İletişim Bilgileri";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(292, 111);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(382, 34);
            this.mskTel.TabIndex = 7;
            this.mskTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTel_MaskInputRejected);
            this.mskTel.Click += new System.EventHandler(this.mskTel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(186, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(292, 44);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(382, 34);
            this.txtMail.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Yemekhane Görevli Sayısı";
            // 
            // lblYemekhane
            // 
            this.lblYemekhane.AutoSize = true;
            this.lblYemekhane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYemekhane.ForeColor = System.Drawing.Color.Black;
            this.lblYemekhane.Location = new System.Drawing.Point(116, 75);
            this.lblYemekhane.Name = "lblYemekhane";
            this.lblYemekhane.Size = new System.Drawing.Size(23, 25);
            this.lblYemekhane.TabIndex = 15;
            this.lblYemekhane.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Güvenlik Görevli Sayısı";
            // 
            // lblGuvenlik
            // 
            this.lblGuvenlik.AutoSize = true;
            this.lblGuvenlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenlik.ForeColor = System.Drawing.Color.Black;
            this.lblGuvenlik.Location = new System.Drawing.Point(137, 75);
            this.lblGuvenlik.Name = "lblGuvenlik";
            this.lblGuvenlik.Size = new System.Drawing.Size(23, 25);
            this.lblGuvenlik.TabIndex = 17;
            this.lblGuvenlik.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(63, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Kat görevli Sayısı";
            // 
            // lblKatGorevlisi
            // 
            this.lblKatGorevlisi.AutoSize = true;
            this.lblKatGorevlisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKatGorevlisi.ForeColor = System.Drawing.Color.Black;
            this.lblKatGorevlisi.Location = new System.Drawing.Point(140, 75);
            this.lblKatGorevlisi.Name = "lblKatGorevlisi";
            this.lblKatGorevlisi.Size = new System.Drawing.Size(23, 25);
            this.lblKatGorevlisi.TabIndex = 19;
            this.lblKatGorevlisi.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.lblYemekhane);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.LawnGreen;
            this.groupBox2.Location = new System.Drawing.Point(74, 552);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 130);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YEMEKHANE";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblKatGorevlisi);
            this.groupBox3.ForeColor = System.Drawing.Color.LawnGreen;
            this.groupBox3.Location = new System.Drawing.Point(802, 552);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 130);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KAT GÖREVLİSİ";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblGuvenlik);
            this.groupBox4.ForeColor = System.Drawing.Color.LawnGreen;
            this.groupBox4.Location = new System.Drawing.Point(438, 552);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 130);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GÜVENLİK";
            // 
            // FrmPersonelEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 864);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPersonelEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelEkle";
            this.Text = "FrmPersonelEkle";
            this.Load += new System.EventHandler(this.FrmPersonelEkle_Load);
            this.gbPersonelEkle.ResumeLayout(false);
            this.gbPersonelEkle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.ComboBox CmbDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.GroupBox gbPersonelEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskDogum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskMaas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYemekhane;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGuvenlik;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblKatGorevlisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}