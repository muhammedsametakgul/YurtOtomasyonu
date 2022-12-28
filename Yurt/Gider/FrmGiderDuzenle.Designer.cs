namespace Yurt
{
    partial class FrmGiderDuzenle
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
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.MskDiger = new System.Windows.Forms.MaskedTextBox();
            this.MskSu = new System.Windows.Forms.MaskedTextBox();
            this.MskPersonel = new System.Windows.Forms.MaskedTextBox();
            this.MskGida = new System.Windows.Forms.MaskedTextBox();
            this.MskInternet = new System.Windows.Forms.MaskedTextBox();
            this.MskDogalgaz = new System.Windows.Forms.MaskedTextBox();
            this.MskElektrik = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GiderDuzenleGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblUyari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GiderDuzenleGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(92, 423);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(153, 46);
            this.BtnGuncelle.TabIndex = 29;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // MskDiger
            // 
            this.MskDiger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDiger.Location = new System.Drawing.Point(186, 362);
            this.MskDiger.Mask = "00000000";
            this.MskDiger.Name = "MskDiger";
            this.MskDiger.Size = new System.Drawing.Size(267, 34);
            this.MskDiger.TabIndex = 8;
            // 
            // MskSu
            // 
            this.MskSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskSu.Location = new System.Drawing.Point(186, 313);
            this.MskSu.Mask = "00000000";
            this.MskSu.Name = "MskSu";
            this.MskSu.Size = new System.Drawing.Size(267, 34);
            this.MskSu.TabIndex = 7;
            // 
            // MskPersonel
            // 
            this.MskPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskPersonel.Location = new System.Drawing.Point(186, 264);
            this.MskPersonel.Mask = "00000000";
            this.MskPersonel.Name = "MskPersonel";
            this.MskPersonel.Size = new System.Drawing.Size(267, 34);
            this.MskPersonel.TabIndex = 6;
            // 
            // MskGida
            // 
            this.MskGida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskGida.Location = new System.Drawing.Point(186, 215);
            this.MskGida.Mask = "00000000";
            this.MskGida.Name = "MskGida";
            this.MskGida.Size = new System.Drawing.Size(267, 34);
            this.MskGida.TabIndex = 5;
            // 
            // MskInternet
            // 
            this.MskInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskInternet.Location = new System.Drawing.Point(186, 166);
            this.MskInternet.Mask = "00000000";
            this.MskInternet.Name = "MskInternet";
            this.MskInternet.Size = new System.Drawing.Size(267, 34);
            this.MskInternet.TabIndex = 4;
            // 
            // MskDogalgaz
            // 
            this.MskDogalgaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogalgaz.Location = new System.Drawing.Point(186, 117);
            this.MskDogalgaz.Mask = "00000000";
            this.MskDogalgaz.Name = "MskDogalgaz";
            this.MskDogalgaz.Size = new System.Drawing.Size(267, 34);
            this.MskDogalgaz.TabIndex = 3;
            this.MskDogalgaz.ValidatingType = typeof(int);
            // 
            // MskElektrik
            // 
            this.MskElektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskElektrik.Location = new System.Drawing.Point(186, 68);
            this.MskElektrik.Mask = "00000000";
            this.MskElektrik.Name = "MskElektrik";
            this.MskElektrik.Size = new System.Drawing.Size(267, 34);
            this.MskElektrik.TabIndex = 2;
            this.MskElektrik.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(59, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label7.Size = new System.Drawing.Size(78, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Diğer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(48, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "Su:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label6.Size = new System.Drawing.Size(116, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "Personel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(99, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "İnternet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(70, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gıda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(121, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "Doğalgaz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Elektrik:";
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
            this.dataGridView1.Location = new System.Drawing.Point(505, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 475);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(5, 375);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 32;
            this.lblid.Text = "label8";
            this.lblid.Visible = false;
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTarih.Location = new System.Drawing.Point(186, 19);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(267, 34);
            this.MskTarih.TabIndex = 1;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(62, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label8.Size = new System.Drawing.Size(75, 39);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tarih:";
            // 
            // GiderDuzenleGroupBox
            // 
            this.GiderDuzenleGroupBox.BackColor = System.Drawing.Color.White;
            this.GiderDuzenleGroupBox.Controls.Add(this.label8);
            this.GiderDuzenleGroupBox.Controls.Add(this.btnSil);
            this.GiderDuzenleGroupBox.Controls.Add(this.lblid);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskTarih);
            this.GiderDuzenleGroupBox.Controls.Add(this.label1);
            this.GiderDuzenleGroupBox.Controls.Add(this.BtnGuncelle);
            this.GiderDuzenleGroupBox.Controls.Add(this.label2);
            this.GiderDuzenleGroupBox.Controls.Add(this.label4);
            this.GiderDuzenleGroupBox.Controls.Add(this.label3);
            this.GiderDuzenleGroupBox.Controls.Add(this.label6);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskDiger);
            this.GiderDuzenleGroupBox.Controls.Add(this.label5);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskSu);
            this.GiderDuzenleGroupBox.Controls.Add(this.label7);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskPersonel);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskElektrik);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskGida);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskDogalgaz);
            this.GiderDuzenleGroupBox.Controls.Add(this.MskInternet);
            this.GiderDuzenleGroupBox.Location = new System.Drawing.Point(7, 26);
            this.GiderDuzenleGroupBox.Name = "GiderDuzenleGroupBox";
            this.GiderDuzenleGroupBox.Size = new System.Drawing.Size(492, 475);
            this.GiderDuzenleGroupBox.TabIndex = 34;
            this.GiderDuzenleGroupBox.TabStop = false;
            this.GiderDuzenleGroupBox.Text = "Giderler";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(300, 423);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(153, 46);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTc);
            this.groupBox1.Controls.Add(this.btnDogrula);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Location = new System.Drawing.Point(20, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 205);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doğrulama";
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(182, 66);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(297, 30);
            this.mskTc.TabIndex = 37;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // btnDogrula
            // 
            this.btnDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDogrula.Location = new System.Drawing.Point(319, 152);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(129, 47);
            this.btnDogrula.TabIndex = 36;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(87, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Şifre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(39, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(182, 113);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(297, 30);
            this.txtSifre.TabIndex = 1;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(15, 519);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(577, 29);
            this.lblUyari.TabIndex = 36;
            this.lblUyari.Text = "Silme İşlemi Yapabilmek İçin Doğrulama Yapınız";
            // 
            // FrmGiderDuzenle
            // 
            this.AcceptButton = this.BtnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1477, 799);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GiderDuzenleGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiderDuzenle";
            this.Text = "FrmGiderDuzenle";
            this.Load += new System.EventHandler(this.FrmGiderDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GiderDuzenleGroupBox.ResumeLayout(false);
            this.GiderDuzenleGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.MaskedTextBox MskDiger;
        private System.Windows.Forms.MaskedTextBox MskSu;
        private System.Windows.Forms.MaskedTextBox MskPersonel;
        private System.Windows.Forms.MaskedTextBox MskGida;
        private System.Windows.Forms.MaskedTextBox MskInternet;
        private System.Windows.Forms.MaskedTextBox MskDogalgaz;
        private System.Windows.Forms.MaskedTextBox MskElektrik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GiderDuzenleGroupBox;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.MaskedTextBox mskTc;
    }
}