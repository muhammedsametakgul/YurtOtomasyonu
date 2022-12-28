namespace Yurt.Gelir
{
    partial class FrmYurtUcreti
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
            this.mskUcret = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.btnBelirle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskUcret
            // 
            this.mskUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskUcret.Location = new System.Drawing.Point(207, 40);
            this.mskUcret.Mask = "00000000";
            this.mskUcret.Name = "mskUcret";
            this.mskUcret.Size = new System.Drawing.Size(209, 34);
            this.mskUcret.TabIndex = 0;
            this.mskUcret.ValidatingType = typeof(int);
            this.mskUcret.Click += new System.EventHandler(this.mskUcret_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(572, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 579);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(6, 43);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(186, 29);
            this.lblUcret.TabIndex = 2;
            this.lblUcret.Text = "Yeni Yurt Ücreti:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(207, 104);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(209, 34);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(121, 104);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(69, 29);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(138, 40);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(52, 29);
            this.lblKullanici.TabIndex = 6;
            this.lblKullanici.Text = "TC:";
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(263, 166);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(105, 31);
            this.btnDogrula.TabIndex = 7;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // btnBelirle
            // 
            this.btnBelirle.Location = new System.Drawing.Point(274, 102);
            this.btnBelirle.Name = "btnBelirle";
            this.btnBelirle.Size = new System.Drawing.Size(105, 31);
            this.btnBelirle.TabIndex = 9;
            this.btnBelirle.Text = "Belirle";
            this.btnBelirle.UseVisualStyleBackColor = true;
            this.btnBelirle.Click += new System.EventHandler(this.btnBelirle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTc);
            this.groupBox1.Controls.Add(this.btnBelirle);
            this.groupBox1.Controls.Add(this.mskUcret);
            this.groupBox1.Controls.Add(this.btnDogrula);
            this.groupBox1.Controls.Add(this.lblUcret);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.lblKullanici);
            this.groupBox1.Controls.Add(this.lblSifre);
            this.groupBox1.Location = new System.Drawing.Point(27, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 222);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doğrulama";
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(207, 40);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(209, 34);
            this.mskTc.TabIndex = 12;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(231, 585);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(44, 16);
            this.lblAd.TabIndex = 10;
            this.lblAd.Text = "label4";
            this.lblAd.Visible = false;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.Location = new System.Drawing.Point(22, 25);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(369, 25);
            this.lblUyari.TabIndex = 11;
            this.lblUyari.Text = "İşlem Yapabilmek İçin Doğrulama Yapınız";
            // 
            // FrmYurtUcreti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1483, 754);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYurtUcreti";
            this.Text = "FrmYurtUcreti";
            this.Load += new System.EventHandler(this.FrmYurtUcreti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskUcret;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Button btnBelirle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.MaskedTextBox mskTc;
    }
}