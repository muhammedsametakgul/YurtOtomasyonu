﻿namespace Yurt.YoneticiIslemleri
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
            this.mskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mskMaas = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbPersonelEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(292, 100);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(382, 38);
            this.TxtAd.TabIndex = 2;
            this.TxtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(292, 25);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(382, 38);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.Click += new System.EventHandler(this.MskTc_Click);
            // 
            // CmbDep
            // 
            this.CmbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDep.FormattingEnabled = true;
            this.CmbDep.Items.AddRange(new object[] {
            "Yemekhane",
            "Kat Görevlisi",
            "Güvenlik"});
            this.CmbDep.Location = new System.Drawing.Point(292, 175);
            this.CmbDep.Name = "CmbDep";
            this.CmbDep.Size = new System.Drawing.Size(382, 39);
            this.CmbDep.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departman:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(148, 431);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres:";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(141, 158);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(382, 206);
            this.TxtAdres.TabIndex = 6;
            this.TxtAdres.Text = "";
            // 
            // gbPersonelEkle
            // 
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
            this.gbPersonelEkle.Size = new System.Drawing.Size(719, 374);
            this.gbPersonelEkle.TabIndex = 12;
            this.gbPersonelEkle.TabStop = false;
            this.gbPersonelEkle.Text = "Personel";
            // 
            // mskDogum
            // 
            this.mskDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(292, 251);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(382, 38);
            this.mskDogum.TabIndex = 8;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            this.mskDogum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDogum_MaskInputRejected);
            this.mskDogum.Click += new System.EventHandler(this.mskDogum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAdres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(737, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 374);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İletişim Bilgileri";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(141, 93);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(382, 38);
            this.mskTel.TabIndex = 14;
            this.mskTel.Click += new System.EventHandler(this.mskTel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(141, 28);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(382, 38);
            this.txtMail.TabIndex = 12;
            // 
            // mskMaas
            // 
            this.mskMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskMaas.Location = new System.Drawing.Point(292, 310);
            this.mskMaas.Mask = "00000000000";
            this.mskMaas.Name = "mskMaas";
            this.mskMaas.Size = new System.Drawing.Size(382, 38);
            this.mskMaas.TabIndex = 10;
            this.mskMaas.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(157, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Maaş:";
            // 
            // FrmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 775);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gbPersonelEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelEkle";
            this.Text = "FrmPersonelEkle";
            this.Load += new System.EventHandler(this.FrmPersonelEkle_Load);
            this.gbPersonelEkle.ResumeLayout(false);
            this.gbPersonelEkle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}