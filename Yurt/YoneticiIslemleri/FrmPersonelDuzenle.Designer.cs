﻿namespace Yurt.YoneticiIslemleri
{
    partial class FrmPersonelDuzenle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbDep = new System.Windows.Forms.ComboBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(71, 681);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 38);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Departman:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ad-Soyad:";
            // 
            // CmbDep
            // 
            this.CmbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDep.FormattingEnabled = true;
            this.CmbDep.Items.AddRange(new object[] {
            "Yemekhane",
            "Kat Görevlisi",
            "Güvenlik"});
            this.CmbDep.Location = new System.Drawing.Point(230, 166);
            this.CmbDep.Name = "CmbDep";
            this.CmbDep.Size = new System.Drawing.Size(285, 37);
            this.CmbDep.TabIndex = 3;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(230, 34);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(187, 34);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.Click += new System.EventHandler(this.MskTc_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(230, 100);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(353, 34);
            this.TxtAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "TC:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(589, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 431);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(1152, 498);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 38);
            this.txtAra.TabIndex = 19;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1040, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ara:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(962, 651);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "labelid";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(454, 681);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(172, 38);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(75, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Telefon:";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdres.Location = new System.Drawing.Point(230, 433);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(353, 206);
            this.TxtAdres.TabIndex = 6;
            this.TxtAdres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(97, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "Adres:";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(230, 301);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(285, 34);
            this.mskTel.TabIndex = 26;
            this.mskTel.Click += new System.EventHandler(this.mskTel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(118, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(230, 367);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(248, 34);
            this.txtMail.TabIndex = 27;
            // 
            // mskDogum
            // 
            this.mskDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(230, 237);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(187, 34);
            this.mskDogum.TabIndex = 29;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            this.mskDogum.Click += new System.EventHandler(this.mskDogum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // FrmPersonelDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1822, 797);
            this.Controls.Add(this.mskDogum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbDep);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelDuzenle";
            this.Text = "FrmPersonelDuzenle";
            this.Load += new System.EventHandler(this.FrmPersonelDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbDep;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        public  System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskDogum;
        private System.Windows.Forms.Label label4;
    }
}