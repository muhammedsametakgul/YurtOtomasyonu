﻿namespace Yurt
{
    partial class FrmOgrenciDuzenle
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
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbOda = new System.Windows.Forms.ComboBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(228, 368);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(152, 22);
            this.TxtSifre.TabIndex = 38;
            this.TxtSifre.Visible = false;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(639, 624);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(363, 51);
            this.BtnSil.TabIndex = 37;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Oda No:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefon Numarası:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mail:";
            this.label9.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Şifre:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Bölüm:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Öğrenci TC:";
            this.label6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Doğum Tarihi:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Öğrenci Soyad:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Öğrenci Ad:";
            this.label1.Visible = false;
            // 
            // CmbOda
            // 
            this.CmbOda.FormattingEnabled = true;
            this.CmbOda.Location = new System.Drawing.Point(228, 564);
            this.CmbOda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CmbOda.Name = "CmbOda";
            this.CmbOda.Size = new System.Drawing.Size(152, 24);
            this.CmbOda.TabIndex = 27;
            this.CmbOda.Visible = false;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(228, 498);
            this.MskTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(152, 22);
            this.MskTel.TabIndex = 26;
            this.MskTel.Visible = false;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(228, 432);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(152, 22);
            this.TxtMail.TabIndex = 25;
            this.TxtMail.Visible = false;
            // 
            // CmbBolum
            // 
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(228, 300);
            this.CmbBolum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(152, 24);
            this.CmbBolum.TabIndex = 24;
            this.CmbBolum.Visible = false;
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(228, 234);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(152, 22);
            this.MskTc.TabIndex = 23;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.Visible = false;
            // 
            // MskDogum
            // 
            this.MskDogum.Location = new System.Drawing.Point(228, 168);
            this.MskDogum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(152, 22);
            this.MskDogum.TabIndex = 22;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            this.MskDogum.Visible = false;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(228, 102);
            this.TxtSoyad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(152, 22);
            this.TxtSoyad.TabIndex = 21;
            this.TxtSoyad.Visible = false;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(228, 36);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(152, 22);
            this.TxtAd.TabIndex = 20;
            this.TxtAd.Visible = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(639, 624);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(363, 51);
            this.BtnGuncelle.TabIndex = 39;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 553);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "lblid";
            this.label10.Visible = false;
            // 
            // FrmOgrenciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 752);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbOda);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Name = "FrmOgrenciDuzenle";
            this.Text = "FrmOgrenciDuzenle";
            this.Load += new System.EventHandler(this.FrmOgrenciDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbOda;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
    }
}