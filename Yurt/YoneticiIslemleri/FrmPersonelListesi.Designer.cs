namespace Yurt.YoneticiIslemleri
{
    partial class FrmPersonelListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtAdAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonelEkle = new System.Windows.Forms.GroupBox();
            this.mskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.CmbDep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbIletisim = new System.Windows.Forms.GroupBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPersonelEkle.SuspendLayout();
            this.gbIletisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 448);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtAdAra
            // 
            this.TxtAdAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdAra.Location = new System.Drawing.Point(115, 538);
            this.TxtAdAra.Name = "TxtAdAra";
            this.TxtAdAra.Size = new System.Drawing.Size(333, 38);
            this.TxtAdAra.TabIndex = 1;
            this.TxtAdAra.TextChanged += new System.EventHandler(this.TxtAdAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad ile Arama";
            // 
            // gbPersonelEkle
            // 
            this.gbPersonelEkle.Controls.Add(this.mskDogum);
            this.gbPersonelEkle.Controls.Add(this.label4);
            this.gbPersonelEkle.Controls.Add(this.label2);
            this.gbPersonelEkle.Controls.Add(this.TxtAd);
            this.gbPersonelEkle.Controls.Add(this.MskTc);
            this.gbPersonelEkle.Controls.Add(this.CmbDep);
            this.gbPersonelEkle.Controls.Add(this.label3);
            this.gbPersonelEkle.Controls.Add(this.label5);
            this.gbPersonelEkle.Location = new System.Drawing.Point(608, 12);
            this.gbPersonelEkle.Name = "gbPersonelEkle";
            this.gbPersonelEkle.Size = new System.Drawing.Size(597, 386);
            this.gbPersonelEkle.TabIndex = 13;
            this.gbPersonelEkle.TabStop = false;
            this.gbPersonelEkle.Text = "Personel";
            // 
            // mskDogum
            // 
            this.mskDogum.Enabled = false;
            this.mskDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(200, 250);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(382, 30);
            this.mskDogum.TabIndex = 8;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC:";
            // 
            // TxtAd
            // 
            this.TxtAd.Enabled = false;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(200, 102);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(382, 30);
            this.TxtAd.TabIndex = 2;
            // 
            // MskTc
            // 
            this.MskTc.Enabled = false;
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(200, 30);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(382, 30);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.Click += new System.EventHandler(this.MskTc_Click);
            // 
            // CmbDep
            // 
            this.CmbDep.Enabled = false;
            this.CmbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDep.FormattingEnabled = true;
            this.CmbDep.Items.AddRange(new object[] {
            "Yemekhane",
            "Kat Görevlisi",
            "Güvenlik"});
            this.CmbDep.Location = new System.Drawing.Point(200, 172);
            this.CmbDep.Name = "CmbDep";
            this.CmbDep.Size = new System.Drawing.Size(382, 33);
            this.CmbDep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad-Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Departman:";
            // 
            // gbIletisim
            // 
            this.gbIletisim.Controls.Add(this.mskTel);
            this.gbIletisim.Controls.Add(this.label7);
            this.gbIletisim.Controls.Add(this.txtMail);
            this.gbIletisim.Controls.Add(this.label6);
            this.gbIletisim.Controls.Add(this.TxtAdres);
            this.gbIletisim.Controls.Add(this.label8);
            this.gbIletisim.Location = new System.Drawing.Point(608, 404);
            this.gbIletisim.Name = "gbIletisim";
            this.gbIletisim.Size = new System.Drawing.Size(597, 386);
            this.gbIletisim.TabIndex = 14;
            this.gbIletisim.TabStop = false;
            this.gbIletisim.Text = "İletişim Bilgileri";
            // 
            // mskTel
            // 
            this.mskTel.Enabled = false;
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(141, 93);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(382, 30);
            this.mskTel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(141, 28);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(382, 30);
            this.txtMail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Enabled = false;
            this.TxtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdres.Location = new System.Drawing.Point(141, 158);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(382, 206);
            this.TxtAdres.TabIndex = 6;
            this.TxtAdres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Adres:";
            // 
            // FrmPersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1855, 921);
            this.Controls.Add(this.gbIletisim);
            this.Controls.Add(this.gbPersonelEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAdAra);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmPersonelListesi";
            this.Text = "FrmPersonelListesi";
            this.Load += new System.EventHandler(this.FrmPersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPersonelEkle.ResumeLayout(false);
            this.gbPersonelEkle.PerformLayout();
            this.gbIletisim.ResumeLayout(false);
            this.gbIletisim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAdAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonelEkle;
        private System.Windows.Forms.MaskedTextBox mskDogum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.ComboBox CmbDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbIletisim;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.Label label8;
    }
}