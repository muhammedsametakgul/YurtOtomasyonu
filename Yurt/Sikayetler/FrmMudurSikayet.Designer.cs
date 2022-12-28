namespace Yurt.Sikayetler
{
    partial class FrmMudurSikayet
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
            this.cmbKime = new System.Windows.Forms.ComboBox();
            this.rchMetin = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKimden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.rbGelen = new System.Windows.Forms.RadioButton();
            this.rbGonderilen = new System.Windows.Forms.RadioButton();
            this.rbOkunmayanlar = new System.Windows.Forms.RadioButton();
            this.rbOkunanlar = new System.Windows.Forms.RadioButton();
            this.lblid = new System.Windows.Forms.Label();
            this.cbOkundu = new System.Windows.Forms.CheckBox();
            this.cbHepsiOkundu = new System.Windows.Forms.CheckBox();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKime
            // 
            this.cmbKime.FormattingEnabled = true;
            this.cmbKime.Location = new System.Drawing.Point(138, 131);
            this.cmbKime.Name = "cmbKime";
            this.cmbKime.Size = new System.Drawing.Size(266, 24);
            this.cmbKime.TabIndex = 2;
            // 
            // rchMetin
            // 
            this.rchMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchMetin.Location = new System.Drawing.Point(138, 213);
            this.rchMetin.Name = "rchMetin";
            this.rchMetin.Size = new System.Drawing.Size(368, 325);
            this.rchMetin.TabIndex = 3;
            this.rchMetin.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 458);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtKimden
            // 
            this.txtKimden.Enabled = false;
            this.txtKimden.Location = new System.Drawing.Point(138, 38);
            this.txtKimden.Name = "txtKimden";
            this.txtKimden.Size = new System.Drawing.Size(266, 22);
            this.txtKimden.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kimden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-4, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şikayet Metni:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(102, 571);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 28);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(270, 571);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 28);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(423, 571);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 28);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rbGelen
            // 
            this.rbGelen.AutoSize = true;
            this.rbGelen.Location = new System.Drawing.Point(908, 575);
            this.rbGelen.Name = "rbGelen";
            this.rbGelen.Size = new System.Drawing.Size(64, 20);
            this.rbGelen.TabIndex = 13;
            this.rbGelen.TabStop = true;
            this.rbGelen.Text = "Gelen";
            this.rbGelen.UseVisualStyleBackColor = true;
            this.rbGelen.CheckedChanged += new System.EventHandler(this.rbGelen_CheckedChanged);
            // 
            // rbGonderilen
            // 
            this.rbGonderilen.AutoSize = true;
            this.rbGonderilen.Location = new System.Drawing.Point(731, 575);
            this.rbGonderilen.Name = "rbGonderilen";
            this.rbGonderilen.Size = new System.Drawing.Size(94, 20);
            this.rbGonderilen.TabIndex = 12;
            this.rbGonderilen.TabStop = true;
            this.rbGonderilen.Text = "Gönderilen";
            this.rbGonderilen.UseVisualStyleBackColor = true;
            this.rbGonderilen.CheckedChanged += new System.EventHandler(this.rbGonderilen_CheckedChanged);
            // 
            // rbOkunmayanlar
            // 
            this.rbOkunmayanlar.AutoSize = true;
            this.rbOkunmayanlar.Location = new System.Drawing.Point(1212, 575);
            this.rbOkunmayanlar.Name = "rbOkunmayanlar";
            this.rbOkunmayanlar.Size = new System.Drawing.Size(115, 20);
            this.rbOkunmayanlar.TabIndex = 15;
            this.rbOkunmayanlar.TabStop = true;
            this.rbOkunmayanlar.Text = "Okunmayanlar";
            this.rbOkunmayanlar.UseVisualStyleBackColor = true;
            this.rbOkunmayanlar.CheckedChanged += new System.EventHandler(this.rbOkunmayanlar_CheckedChanged);
            // 
            // rbOkunanlar
            // 
            this.rbOkunanlar.AutoSize = true;
            this.rbOkunanlar.Location = new System.Drawing.Point(1055, 575);
            this.rbOkunanlar.Name = "rbOkunanlar";
            this.rbOkunanlar.Size = new System.Drawing.Size(74, 20);
            this.rbOkunanlar.TabIndex = 14;
            this.rbOkunanlar.TabStop = true;
            this.rbOkunanlar.Text = "Okundu";
            this.rbOkunanlar.UseVisualStyleBackColor = true;
            this.rbOkunanlar.CheckedChanged += new System.EventHandler(this.rbOkunanlar_CheckedChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(49, 431);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "label4";
            this.lblid.Visible = false;
            // 
            // cbOkundu
            // 
            this.cbOkundu.AutoSize = true;
            this.cbOkundu.Location = new System.Drawing.Point(543, 38);
            this.cbOkundu.Name = "cbOkundu";
            this.cbOkundu.Size = new System.Drawing.Size(165, 20);
            this.cbOkundu.TabIndex = 17;
            this.cbOkundu.Text = "Okundu Olarak İşaretle";
            this.cbOkundu.UseVisualStyleBackColor = true;
            this.cbOkundu.CheckedChanged += new System.EventHandler(this.cbOkundu_CheckedChanged);
            // 
            // cbHepsiOkundu
            // 
            this.cbHepsiOkundu.AutoSize = true;
            this.cbHepsiOkundu.Location = new System.Drawing.Point(760, 38);
            this.cbHepsiOkundu.Name = "cbHepsiOkundu";
            this.cbHepsiOkundu.Size = new System.Drawing.Size(214, 20);
            this.cbHepsiOkundu.TabIndex = 18;
            this.cbHepsiOkundu.Text = "Hepsini Okundu Olarak İşaretle";
            this.cbHepsiOkundu.UseVisualStyleBackColor = true;
            this.cbHepsiOkundu.CheckedChanged += new System.EventHandler(this.cbHepsiOkundu_CheckedChanged);
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Location = new System.Drawing.Point(584, 579);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(64, 20);
            this.rbHepsi.TabIndex = 19;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // FrmMudurSikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1623, 769);
            this.Controls.Add(this.rbHepsi);
            this.Controls.Add(this.cbHepsiOkundu);
            this.Controls.Add(this.cbOkundu);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.rbOkunmayanlar);
            this.Controls.Add(this.rbOkunanlar);
            this.Controls.Add(this.rbGelen);
            this.Controls.Add(this.rbGonderilen);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKimden);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rchMetin);
            this.Controls.Add(this.cmbKime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMudurSikayet";
            this.Text = "FrmSikayet";
            this.Load += new System.EventHandler(this.FrmSikayet_Load);
            this.Click += new System.EventHandler(this.FrmMudurSikayet_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKime;
        private System.Windows.Forms.RichTextBox rchMetin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKimden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RadioButton rbGelen;
        private System.Windows.Forms.RadioButton rbGonderilen;
        private System.Windows.Forms.RadioButton rbOkunmayanlar;
        private System.Windows.Forms.RadioButton rbOkunanlar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.CheckBox cbOkundu;
        private System.Windows.Forms.CheckBox cbHepsiOkundu;
        private System.Windows.Forms.RadioButton rbHepsi;
    }
}