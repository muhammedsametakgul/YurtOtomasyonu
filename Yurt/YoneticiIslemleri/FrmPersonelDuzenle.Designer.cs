namespace Yurt.YoneticiIslemleri
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
            this.lblid = new System.Windows.Forms.Label();
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
            this.btnGuncelle.Location = new System.Drawing.Point(664, 485);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Departman:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ad-Soyad:";
            // 
            // CmbDep
            // 
            this.CmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDep.FormattingEnabled = true;
            this.CmbDep.Items.AddRange(new object[] {
            "Yemekhane",
            "Kat Görevlisi",
            "Güvenlik"});
            this.CmbDep.Location = new System.Drawing.Point(230, 162);
            this.CmbDep.Name = "CmbDep";
            this.CmbDep.Size = new System.Drawing.Size(353, 33);
            this.CmbDep.TabIndex = 3;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(230, 33);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(353, 30);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(230, 99);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(353, 30);
            this.TxtAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "TC Kimlik No:";
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(626, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.txtAra.Location = new System.Drawing.Point(1090, 495);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 38);
            this.txtAra.TabIndex = 19;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(978, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ara:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(962, 651);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(99, 32);
            this.lblid.TabIndex = 21;
            this.lblid.Text = "labelid";
            this.lblid.Visible = false;
            this.lblid.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(664, 557);
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(87, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Telefon:";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdres.Location = new System.Drawing.Point(230, 430);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(353, 206);
            this.TxtAdres.TabIndex = 6;
            this.TxtAdres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(107, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Adres:";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(230, 297);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(353, 30);
            this.mskTel.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(125, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(230, 364);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(353, 30);
            this.txtMail.TabIndex = 27;
            // 
            // mskDogum
            // 
            this.mskDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(230, 231);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(353, 30);
            this.mskDogum.TabIndex = 29;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
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
            this.Controls.Add(this.lblid);
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
        private System.Windows.Forms.Label lblid;
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