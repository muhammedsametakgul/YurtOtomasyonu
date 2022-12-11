namespace Yurt
{
    partial class FrmOgrenciEkle
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
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.CmbOda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(243, 34);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(344, 30);
            this.TxtAd.TabIndex = 0;
            // 
            // MskDogum
            // 
            this.MskDogum.Location = new System.Drawing.Point(243, 81);
            this.MskDogum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(344, 30);
            this.MskDogum.TabIndex = 2;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(243, 147);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(344, 30);
            this.MskTc.TabIndex = 3;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // CmbBolum
            // 
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(243, 213);
            this.CmbBolum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(344, 33);
            this.CmbBolum.TabIndex = 4;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(243, 269);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(344, 30);
            this.TxtMail.TabIndex = 6;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(243, 319);
            this.MskTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(344, 30);
            this.MskTel.TabIndex = 7;
            this.MskTel.Click += new System.EventHandler(this.MskTel_Click);
            this.MskTel.EnabledChanged += new System.EventHandler(this.MskTel_EnabledChanged);
            // 
            // CmbOda
            // 
            this.CmbOda.FormattingEnabled = true;
            this.CmbOda.Location = new System.Drawing.Point(243, 419);
            this.CmbOda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CmbOda.Name = "CmbOda";
            this.CmbOda.Size = new System.Drawing.Size(344, 33);
            this.CmbOda.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bölüm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Öğrenci TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Oda No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefon Numarası:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mail:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(243, 485);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(344, 167);
            this.rchAdres.TabIndex = 19;
            this.rchAdres.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Veli Telefon Numarası:";
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.Location = new System.Drawing.Point(243, 368);
            this.MskVeliTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(344, 30);
            this.MskVeliTel.TabIndex = 21;
            // 
            // FrmOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 815);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskVeliTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbOda);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.TxtAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgrenciEkle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.ComboBox CmbOda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
    }
}