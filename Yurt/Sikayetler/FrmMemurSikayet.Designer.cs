namespace Yurt.Sikayetler
{
    partial class FrmMemurSikayet
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
            this.cbHepsiOkundu = new System.Windows.Forms.CheckBox();
            this.cbOkundu = new System.Windows.Forms.CheckBox();
            this.lblid = new System.Windows.Forms.Label();
            this.rbOkunmayanlar = new System.Windows.Forms.RadioButton();
            this.rbOkunanlar = new System.Windows.Forms.RadioButton();
            this.rbGelen = new System.Windows.Forms.RadioButton();
            this.rbGonderilen = new System.Windows.Forms.RadioButton();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKimden = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rchMetin = new System.Windows.Forms.RichTextBox();
            this.cmbKime = new System.Windows.Forms.ComboBox();
            this.rbMemur = new System.Windows.Forms.RadioButton();
            this.rbMudur = new System.Windows.Forms.RadioButton();
            this.lblAd = new System.Windows.Forms.Label();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHepsiOkundu
            // 
            this.cbHepsiOkundu.AutoSize = true;
            this.cbHepsiOkundu.Location = new System.Drawing.Point(771, 55);
            this.cbHepsiOkundu.Name = "cbHepsiOkundu";
            this.cbHepsiOkundu.Size = new System.Drawing.Size(214, 20);
            this.cbHepsiOkundu.TabIndex = 37;
            this.cbHepsiOkundu.Text = "Hepsini Okundu Olarak İşaretle";
            this.cbHepsiOkundu.UseVisualStyleBackColor = true;
            this.cbHepsiOkundu.CheckedChanged += new System.EventHandler(this.cbHepsiOkundu_CheckedChanged);
            // 
            // cbOkundu
            // 
            this.cbOkundu.AutoSize = true;
            this.cbOkundu.Location = new System.Drawing.Point(554, 55);
            this.cbOkundu.Name = "cbOkundu";
            this.cbOkundu.Size = new System.Drawing.Size(165, 20);
            this.cbOkundu.TabIndex = 36;
            this.cbOkundu.Text = "Okundu Olarak İşaretle";
            this.cbOkundu.UseVisualStyleBackColor = true;
            this.cbOkundu.CheckedChanged += new System.EventHandler(this.cbOkundu_CheckedChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(60, 448);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 35;
            this.lblid.Text = "label4";
            this.lblid.Visible = false;
            // 
            // rbOkunmayanlar
            // 
            this.rbOkunmayanlar.AutoSize = true;
            this.rbOkunmayanlar.Location = new System.Drawing.Point(1155, 588);
            this.rbOkunmayanlar.Name = "rbOkunmayanlar";
            this.rbOkunmayanlar.Size = new System.Drawing.Size(115, 20);
            this.rbOkunmayanlar.TabIndex = 34;
            this.rbOkunmayanlar.Text = "Okunmayanlar";
            this.rbOkunmayanlar.UseVisualStyleBackColor = true;
            this.rbOkunmayanlar.CheckedChanged += new System.EventHandler(this.rbOkunmayanlar_CheckedChanged);
            // 
            // rbOkunanlar
            // 
            this.rbOkunanlar.AutoSize = true;
            this.rbOkunanlar.Location = new System.Drawing.Point(1030, 588);
            this.rbOkunanlar.Name = "rbOkunanlar";
            this.rbOkunanlar.Size = new System.Drawing.Size(74, 20);
            this.rbOkunanlar.TabIndex = 33;
            this.rbOkunanlar.Text = "Okundu";
            this.rbOkunanlar.UseVisualStyleBackColor = true;
            this.rbOkunanlar.CheckedChanged += new System.EventHandler(this.rbOkunanlar_CheckedChanged);
            // 
            // rbGelen
            // 
            this.rbGelen.AutoSize = true;
            this.rbGelen.Location = new System.Drawing.Point(915, 588);
            this.rbGelen.Name = "rbGelen";
            this.rbGelen.Size = new System.Drawing.Size(64, 20);
            this.rbGelen.TabIndex = 32;
            this.rbGelen.Text = "Gelen";
            this.rbGelen.UseVisualStyleBackColor = true;
            this.rbGelen.CheckedChanged += new System.EventHandler(this.rbGelen_CheckedChanged);
            // 
            // rbGonderilen
            // 
            this.rbGonderilen.AutoSize = true;
            this.rbGonderilen.Location = new System.Drawing.Point(770, 588);
            this.rbGonderilen.Name = "rbGonderilen";
            this.rbGonderilen.Size = new System.Drawing.Size(94, 20);
            this.rbGonderilen.TabIndex = 31;
            this.rbGonderilen.Text = "Gönderilen";
            this.rbGonderilen.UseVisualStyleBackColor = true;
            this.rbGonderilen.CheckedChanged += new System.EventHandler(this.rbGonderilen_CheckedChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(434, 588);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 28);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(281, 588);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 28);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(113, 588);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 28);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Şikayet Metni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kimden:";
            // 
            // txtKimden
            // 
            this.txtKimden.Enabled = false;
            this.txtKimden.Location = new System.Drawing.Point(199, 55);
            this.txtKimden.Name = "txtKimden";
            this.txtKimden.Size = new System.Drawing.Size(266, 22);
            this.txtKimden.TabIndex = 24;
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
            this.dataGridView1.Location = new System.Drawing.Point(554, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 458);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rchMetin
            // 
            this.rchMetin.Location = new System.Drawing.Point(167, 233);
            this.rchMetin.Name = "rchMetin";
            this.rchMetin.Size = new System.Drawing.Size(368, 325);
            this.rchMetin.TabIndex = 22;
            this.rchMetin.Text = "";
            // 
            // cmbKime
            // 
            this.cmbKime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKime.FormattingEnabled = true;
            this.cmbKime.Location = new System.Drawing.Point(199, 148);
            this.cmbKime.Name = "cmbKime";
            this.cmbKime.Size = new System.Drawing.Size(266, 24);
            this.cmbKime.TabIndex = 21;
            // 
            // rbMemur
            // 
            this.rbMemur.AutoSize = true;
            this.rbMemur.Location = new System.Drawing.Point(342, 103);
            this.rbMemur.Name = "rbMemur";
            this.rbMemur.Size = new System.Drawing.Size(69, 20);
            this.rbMemur.TabIndex = 20;
            this.rbMemur.Text = "Memur";
            this.rbMemur.UseVisualStyleBackColor = true;
            this.rbMemur.CheckedChanged += new System.EventHandler(this.rbMemur_CheckedChanged);
            // 
            // rbMudur
            // 
            this.rbMudur.AutoSize = true;
            this.rbMudur.Location = new System.Drawing.Point(230, 103);
            this.rbMudur.Name = "rbMudur";
            this.rbMudur.Size = new System.Drawing.Size(65, 20);
            this.rbMudur.TabIndex = 19;
            this.rbMudur.Text = "Müdür";
            this.rbMudur.UseVisualStyleBackColor = true;
            this.rbMudur.CheckedChanged += new System.EventHandler(this.rbMudur_CheckedChanged);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(615, 668);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(44, 16);
            this.lblAd.TabIndex = 38;
            this.lblAd.Text = "label4";
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Location = new System.Drawing.Point(655, 592);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(64, 20);
            this.rbHepsi.TabIndex = 39;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // FrmMemurSikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1717, 716);
            this.Controls.Add(this.rbHepsi);
            this.Controls.Add(this.lblAd);
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
            this.Controls.Add(this.rbMemur);
            this.Controls.Add(this.rbMudur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMemurSikayet";
            this.Text = "FrmMemurSikayet";
            this.Load += new System.EventHandler(this.FrmMemurSikayet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHepsiOkundu;
        private System.Windows.Forms.CheckBox cbOkundu;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.RadioButton rbOkunmayanlar;
        private System.Windows.Forms.RadioButton rbOkunanlar;
        private System.Windows.Forms.RadioButton rbGelen;
        private System.Windows.Forms.RadioButton rbGonderilen;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKimden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchMetin;
        private System.Windows.Forms.ComboBox cmbKime;
        private System.Windows.Forms.RadioButton rbMemur;
        private System.Windows.Forms.RadioButton rbMudur;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.RadioButton rbHepsi;
    }
}