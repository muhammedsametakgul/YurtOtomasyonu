namespace Yurt.Gelir
{
    partial class FrmGelirEkle
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
            this.lblOdeyen = new System.Windows.Forms.Label();
            this.lblOdenenMıktar = new System.Windows.Forms.Label();
            this.lblOdemeTarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdeyen = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.lblFirma = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.rbFirma = new System.Windows.Forms.RadioButton();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.mskOdenenMiktar = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdeyen
            // 
            this.lblOdeyen.AutoSize = true;
            this.lblOdeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeyen.Location = new System.Drawing.Point(86, 45);
            this.lblOdeyen.Name = "lblOdeyen";
            this.lblOdeyen.Size = new System.Drawing.Size(111, 29);
            this.lblOdeyen.TabIndex = 0;
            this.lblOdeyen.Text = "Ödeyen:";
            // 
            // lblOdenenMıktar
            // 
            this.lblOdenenMıktar.AutoSize = true;
            this.lblOdenenMıktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenMıktar.Location = new System.Drawing.Point(6, 118);
            this.lblOdenenMıktar.Name = "lblOdenenMıktar";
            this.lblOdenenMıktar.Size = new System.Drawing.Size(191, 29);
            this.lblOdenenMıktar.TabIndex = 1;
            this.lblOdenenMıktar.Text = "Ödenen Miktar:";
            // 
            // lblOdemeTarih
            // 
            this.lblOdemeTarih.AutoSize = true;
            this.lblOdemeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTarih.Location = new System.Drawing.Point(116, 191);
            this.lblOdemeTarih.Name = "lblOdemeTarih";
            this.lblOdemeTarih.Size = new System.Drawing.Size(81, 29);
            this.lblOdemeTarih.TabIndex = 2;
            this.lblOdemeTarih.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon:";
            // 
            // txtOdeyen
            // 
            this.txtOdeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdeyen.Location = new System.Drawing.Point(217, 41);
            this.txtOdeyen.Name = "txtOdeyen";
            this.txtOdeyen.Size = new System.Drawing.Size(343, 30);
            this.txtOdeyen.TabIndex = 1;
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(217, 264);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(343, 34);
            this.mskTel.TabIndex = 3;
            this.mskTel.Click += new System.EventHandler(this.mskTel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(217, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 34);
            this.txtEmail.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(312, 489);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 42);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFirma
            // 
            this.txtFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirma.Location = new System.Drawing.Point(217, 438);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(343, 30);
            this.txtFirma.TabIndex = 5;
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirma.Location = new System.Drawing.Point(65, 439);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(132, 29);
            this.lblFirma.TabIndex = 12;
            this.lblFirma.Text = "Firma Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(197, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 14;
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBireysel.Location = new System.Drawing.Point(217, 391);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(91, 24);
            this.rbBireysel.TabIndex = 15;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel";
            this.rbBireysel.UseVisualStyleBackColor = true;
            this.rbBireysel.CheckedChanged += new System.EventHandler(this.rbBireysel_CheckedChanged);
            // 
            // rbFirma
            // 
            this.rbFirma.AutoSize = true;
            this.rbFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFirma.Location = new System.Drawing.Point(459, 391);
            this.rbFirma.Name = "rbFirma";
            this.rbFirma.Size = new System.Drawing.Size(101, 24);
            this.rbFirma.TabIndex = 16;
            this.rbFirma.TabStop = true;
            this.rbFirma.Text = "Kurumsal";
            this.rbFirma.UseVisualStyleBackColor = true;
            this.rbFirma.CheckedChanged += new System.EventHandler(this.rbFirma_CheckedChanged);
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(217, 191);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(343, 30);
            this.dtTarih.TabIndex = 17;
            // 
            // mskOdenenMiktar
            // 
            this.mskOdenenMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOdenenMiktar.Location = new System.Drawing.Point(217, 125);
            this.mskOdenenMiktar.Mask = "000000000";
            this.mskOdenenMiktar.Name = "mskOdenenMiktar";
            this.mskOdenenMiktar.Size = new System.Drawing.Size(343, 30);
            this.mskOdenenMiktar.TabIndex = 2;
            this.mskOdenenMiktar.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOdeyen);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.mskOdenenMiktar);
            this.groupBox1.Controls.Add(this.lblOdenenMıktar);
            this.groupBox1.Controls.Add(this.dtTarih);
            this.groupBox1.Controls.Add(this.lblOdemeTarih);
            this.groupBox1.Controls.Add(this.rbFirma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbBireysel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOdeyen);
            this.groupBox1.Controls.Add(this.txtFirma);
            this.groupBox1.Controls.Add(this.mskTel);
            this.groupBox1.Controls.Add(this.lblFirma);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 576);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            // 
            // FrmGelirEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 646);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGelirEkle";
            this.Text = "FrmGelirEkle";
            this.Load += new System.EventHandler(this.FrmGelirEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOdeyen;
        private System.Windows.Forms.Label lblOdenenMıktar;
        private System.Windows.Forms.Label lblOdemeTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdeyen;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.RadioButton rbFirma;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.MaskedTextBox mskOdenenMiktar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}