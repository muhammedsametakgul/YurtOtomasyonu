namespace Yurt.Ogrenci
{
    partial class FrmOdaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdaListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOda = new System.Windows.Forms.Label();
            this.btnGeriGel = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gbKisisel = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYasadigiIl = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.mskDogum = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.lblBosOdaSyisi = new System.Windows.Forms.Label();
            this.lbl145 = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.gbKisisel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(506, 625);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(816, 67);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 28);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(812, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Oda Numarasına Göre Arama:";
            // 
            // lblOda
            // 
            this.lblOda.AutoSize = true;
            this.lblOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOda.Location = new System.Drawing.Point(1191, 9);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(60, 22);
            this.lblOda.TabIndex = 18;
            this.lblOda.Text = "odano";
            this.lblOda.Visible = false;
            // 
            // btnGeriGel
            // 
            this.btnGeriGel.BackColor = System.Drawing.Color.White;
            this.btnGeriGel.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriGel.Image")));
            this.btnGeriGel.Location = new System.Drawing.Point(6, 45);
            this.btnGeriGel.Name = "btnGeriGel";
            this.btnGeriGel.Size = new System.Drawing.Size(33, 31);
            this.btnGeriGel.TabIndex = 19;
            this.btnGeriGel.UseVisualStyleBackColor = false;
            this.btnGeriGel.Click += new System.EventHandler(this.btnGeriGel_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(57, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(506, 225);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.btnGeriGel);
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(12, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(633, 676);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Liste";
            // 
            // gbKisisel
            // 
            this.gbKisisel.Controls.Add(this.label8);
            this.gbKisisel.Controls.Add(this.label7);
            this.gbKisisel.Controls.Add(this.label6);
            this.gbKisisel.Controls.Add(this.label5);
            this.gbKisisel.Controls.Add(this.label4);
            this.gbKisisel.Controls.Add(this.label3);
            this.gbKisisel.Controls.Add(this.label2);
            this.gbKisisel.Controls.Add(this.txtYasadigiIl);
            this.gbKisisel.Controls.Add(this.txtBolum);
            this.gbKisisel.Controls.Add(this.mskDogum);
            this.gbKisisel.Controls.Add(this.mskTel);
            this.gbKisisel.Controls.Add(this.txtMail);
            this.gbKisisel.Controls.Add(this.mskTc);
            this.gbKisisel.Controls.Add(this.txtAdSoyad);
            this.gbKisisel.Location = new System.Drawing.Point(656, 208);
            this.gbKisisel.Name = "gbKisisel";
            this.gbKisisel.Size = new System.Drawing.Size(762, 480);
            this.gbKisisel.TabIndex = 22;
            this.gbKisisel.TabStop = false;
            this.gbKisisel.Text = "Kişisel Bilgiler";
            this.gbKisisel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(30, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yaşadığı Yer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(92, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bölüm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(79, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(112, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(127, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // txtYasadigiIl
            // 
            this.txtYasadigiIl.Enabled = false;
            this.txtYasadigiIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYasadigiIl.Location = new System.Drawing.Point(261, 404);
            this.txtYasadigiIl.Name = "txtYasadigiIl";
            this.txtYasadigiIl.Size = new System.Drawing.Size(381, 30);
            this.txtYasadigiIl.TabIndex = 6;
            // 
            // txtBolum
            // 
            this.txtBolum.Enabled = false;
            this.txtBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolum.Location = new System.Drawing.Point(261, 344);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(381, 30);
            this.txtBolum.TabIndex = 5;
            // 
            // mskDogum
            // 
            this.mskDogum.Enabled = false;
            this.mskDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(261, 284);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(381, 30);
            this.mskDogum.TabIndex = 4;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // mskTel
            // 
            this.mskTel.Enabled = false;
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(261, 224);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(381, 30);
            this.mskTel.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(261, 166);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(381, 30);
            this.txtMail.TabIndex = 2;
            // 
            // mskTc
            // 
            this.mskTc.Enabled = false;
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(261, 106);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(381, 30);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(261, 46);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(381, 30);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(1227, 66);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(24, 22);
            this.lblTc.TabIndex = 23;
            this.lblTc.Text = "tc";
            this.lblTc.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(679, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Oda Sayısı:";
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaSayisi.Location = new System.Drawing.Point(693, 162);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(82, 25);
            this.lblOdaSayisi.TabIndex = 25;
            this.lblOdaSayisi.Text = "label10";
            // 
            // lblBosOdaSyisi
            // 
            this.lblBosOdaSyisi.AutoSize = true;
            this.lblBosOdaSyisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBosOdaSyisi.Location = new System.Drawing.Point(1111, 162);
            this.lblBosOdaSyisi.Name = "lblBosOdaSyisi";
            this.lblBosOdaSyisi.Size = new System.Drawing.Size(82, 25);
            this.lblBosOdaSyisi.TabIndex = 27;
            this.lblBosOdaSyisi.Text = "label11";
            // 
            // lbl145
            // 
            this.lbl145.AutoSize = true;
            this.lbl145.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl145.Location = new System.Drawing.Point(1068, 112);
            this.lbl145.Name = "lbl145";
            this.lbl145.Size = new System.Drawing.Size(161, 25);
            this.lbl145.TabIndex = 26;
            this.lbl145.Text = "Boş Oda Sayısı";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.Location = new System.Drawing.Point(13, 42);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(439, 25);
            this.lblUyari.TabIndex = 28;
            this.lblUyari.Text = "Odada Kalan Kişileri Görmek İçin Bir Oda Seçiniz";
            // 
            // FrmOdaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1477, 825);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.lblBosOdaSyisi);
            this.Controls.Add(this.lbl145);
            this.Controls.Add(this.lblOdaSayisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.gbKisisel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblOda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOdaListesi";
            this.Text = "FrmOdaListesi";
            this.Load += new System.EventHandler(this.FrmOdaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.gbKisisel.ResumeLayout(false);
            this.gbKisisel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOda;
        private System.Windows.Forms.Button btnGeriGel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox gbKisisel;
        private System.Windows.Forms.TextBox txtYasadigiIl;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.MaskedTextBox mskDogum;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.Label lblBosOdaSyisi;
        private System.Windows.Forms.Label lbl145;
        private System.Windows.Forms.Label lblUyari;
    }
}