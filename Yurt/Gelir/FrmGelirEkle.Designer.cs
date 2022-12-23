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
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.lblFirma = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.rbFirma = new System.Windows.Forms.RadioButton();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblOdeyen
            // 
            this.lblOdeyen.AutoSize = true;
            this.lblOdeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeyen.Location = new System.Drawing.Point(108, 75);
            this.lblOdeyen.Name = "lblOdeyen";
            this.lblOdeyen.Size = new System.Drawing.Size(104, 29);
            this.lblOdeyen.TabIndex = 0;
            this.lblOdeyen.Text = "Ödeyen:";
            // 
            // lblOdenenMıktar
            // 
            this.lblOdenenMıktar.AutoSize = true;
            this.lblOdenenMıktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenMıktar.Location = new System.Drawing.Point(35, 161);
            this.lblOdenenMıktar.Name = "lblOdenenMıktar";
            this.lblOdenenMıktar.Size = new System.Drawing.Size(177, 29);
            this.lblOdenenMıktar.TabIndex = 1;
            this.lblOdenenMıktar.Text = "Ödenen Miktar:";
            // 
            // lblOdemeTarih
            // 
            this.lblOdemeTarih.AutoSize = true;
            this.lblOdemeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTarih.Location = new System.Drawing.Point(137, 247);
            this.lblOdemeTarih.Name = "lblOdemeTarih";
            this.lblOdemeTarih.Size = new System.Drawing.Size(75, 29);
            this.lblOdemeTarih.TabIndex = 2;
            this.lblOdemeTarih.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon:";
            // 
            // txtOdeyen
            // 
            this.txtOdeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdeyen.Location = new System.Drawing.Point(276, 75);
            this.txtOdeyen.Name = "txtOdeyen";
            this.txtOdeyen.Size = new System.Drawing.Size(343, 30);
            this.txtOdeyen.TabIndex = 1;
            // 
            // txtOdenen
            // 
            this.txtOdenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenen.Location = new System.Drawing.Point(276, 160);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(343, 30);
            this.txtOdenen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(657, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "TL";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(276, 328);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(343, 34);
            this.mskTel.TabIndex = 4;
            this.mskTel.Click += new System.EventHandler(this.mskTel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(276, 414);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(276, 581);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(240, 42);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFirma
            // 
            this.txtFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirma.Location = new System.Drawing.Point(276, 518);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(343, 30);
            this.txtFirma.TabIndex = 6;
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirma.Location = new System.Drawing.Point(108, 518);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(122, 29);
            this.lblFirma.TabIndex = 12;
            this.lblFirma.Text = "Firma Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(198, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 14;
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(276, 472);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(77, 20);
            this.rbBireysel.TabIndex = 15;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel";
            this.rbBireysel.UseVisualStyleBackColor = true;
            this.rbBireysel.CheckedChanged += new System.EventHandler(this.rbBireysel_CheckedChanged);
            // 
            // rbFirma
            // 
            this.rbFirma.AutoSize = true;
            this.rbFirma.Location = new System.Drawing.Point(473, 472);
            this.rbFirma.Name = "rbFirma";
            this.rbFirma.Size = new System.Drawing.Size(83, 20);
            this.rbFirma.TabIndex = 16;
            this.rbFirma.TabStop = true;
            this.rbFirma.Text = "Kurumsal";
            this.rbFirma.UseVisualStyleBackColor = true;
            this.rbFirma.CheckedChanged += new System.EventHandler(this.rbFirma_CheckedChanged);
            // 
            // mskTarih
            // 
            this.mskTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTarih.Location = new System.Drawing.Point(276, 247);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(343, 34);
            this.mskTarih.TabIndex = 3;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            this.mskTarih.Click += new System.EventHandler(this.mskTarih_Click);
            // 
            // FrmGelirEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 646);
            this.Controls.Add(this.mskTarih);
            this.Controls.Add(this.rbFirma);
            this.Controls.Add(this.rbBireysel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.txtOdeyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOdemeTarih);
            this.Controls.Add(this.lblOdenenMıktar);
            this.Controls.Add(this.lblOdeyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGelirEkle";
            this.Text = "FrmGelirEkle";
            this.Load += new System.EventHandler(this.FrmGelirEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdeyen;
        private System.Windows.Forms.Label lblOdenenMıktar;
        private System.Windows.Forms.Label lblOdemeTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdeyen;
        private System.Windows.Forms.TextBox txtOdenen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.RadioButton rbFirma;
        private System.Windows.Forms.MaskedTextBox mskTarih;
    }
}