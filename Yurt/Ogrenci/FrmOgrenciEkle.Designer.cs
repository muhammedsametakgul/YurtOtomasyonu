﻿namespace Yurt
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDogdugu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbYakin = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVeliAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbYasadigi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtYurtUcreti = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(205, 54);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(344, 30);
            this.TxtAd.TabIndex = 0;
            // 
            // MskDogum
            // 
            this.MskDogum.Location = new System.Drawing.Point(205, 101);
            this.MskDogum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(344, 30);
            this.MskDogum.TabIndex = 1;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            this.MskDogum.Click += new System.EventHandler(this.MskDogum_Click_1);
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(205, 148);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(344, 30);
            this.MskTc.TabIndex = 2;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.Click += new System.EventHandler(this.MskTc_Click_1);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(152, 345);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(395, 30);
            this.TxtMail.TabIndex = 12;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(152, 397);
            this.MskTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(395, 30);
            this.MskTel.TabIndex = 13;
            this.MskTel.Click += new System.EventHandler(this.MskTel_Click_1);
            // 
            // CmbOda
            // 
            this.CmbOda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOda.FormattingEnabled = true;
            this.CmbOda.Location = new System.Drawing.Point(205, 289);
            this.CmbOda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CmbOda.Name = "CmbOda";
            this.CmbOda.Size = new System.Drawing.Size(344, 33);
            this.CmbOda.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(105, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bölüm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(62, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Öğrenci TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Oda No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(27, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(54, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mail:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(658, 582);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(131, 41);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(152, 110);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(395, 196);
            this.rchAdres.TabIndex = 11;
            this.rchAdres.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Veli Telefon:";
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.Location = new System.Drawing.Point(204, 212);
            this.MskVeliTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(344, 30);
            this.MskVeliTel.TabIndex = 9;
            this.MskVeliTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskVeliTel_MaskInputRejected);
            this.MskVeliTel.Click += new System.EventHandler(this.MskVeliTel_Click_1);
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(205, 195);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(344, 30);
            this.txtBolum.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbDogdugu);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBolum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CmbOda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MskDogum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MskTc);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 342);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // cmbDogdugu
            // 
            this.cmbDogdugu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogdugu.FormattingEnabled = true;
            this.cmbDogdugu.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbDogdugu.Location = new System.Drawing.Point(204, 241);
            this.cmbDogdugu.Name = "cmbDogdugu";
            this.cmbDogdugu.Size = new System.Drawing.Size(344, 33);
            this.cmbDogdugu.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(68, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Doğduğu İl:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbYakin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtVeliAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.MskVeliTel);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 297);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veli Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(103, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Yakınlık:";
            // 
            // cmbYakin
            // 
            this.cmbYakin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYakin.FormattingEnabled = true;
            this.cmbYakin.ItemHeight = 25;
            this.cmbYakin.Items.AddRange(new object[] {
            "Baba",
            "Anne",
            "Abla",
            "Abi",
            "Teyze",
            "Dayı",
            "Amca",
            "Hala",
            "Dede",
            "Anneanne",
            "Babaanne"});
            this.cmbYakin.Location = new System.Drawing.Point(204, 137);
            this.cmbYakin.Name = "cmbYakin";
            this.cmbYakin.Size = new System.Drawing.Size(344, 33);
            this.cmbYakin.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(88, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ad Soyad:";
            // 
            // txtVeliAd
            // 
            this.txtVeliAd.Location = new System.Drawing.Point(204, 65);
            this.txtVeliAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtVeliAd.Name = "txtVeliAd";
            this.txtVeliAd.Size = new System.Drawing.Size(344, 30);
            this.txtVeliAd.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbYasadigi);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rchAdres);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtMail);
            this.groupBox3.Controls.Add(this.MskTel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(600, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 483);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // cmbYasadigi
            // 
            this.cmbYasadigi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYasadigi.FormattingEnabled = true;
            this.cmbYasadigi.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbYasadigi.Location = new System.Drawing.Point(152, 41);
            this.cmbYasadigi.Name = "cmbYasadigi";
            this.cmbYasadigi.Size = new System.Drawing.Size(395, 33);
            this.cmbYasadigi.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(27, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Yaşadığı İl:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(945, 582);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(125, 41);
            this.btnTemizle.TabIndex = 27;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtYurtUcreti
            // 
            this.txtYurtUcreti.Enabled = false;
            this.txtYurtUcreti.Location = new System.Drawing.Point(53, 667);
            this.txtYurtUcreti.Name = "txtYurtUcreti";
            this.txtYurtUcreti.Size = new System.Drawing.Size(400, 30);
            this.txtYurtUcreti.TabIndex = 28;
            this.txtYurtUcreti.Visible = false;
            // 
            // FrmOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 729);
            this.Controls.Add(this.txtYurtUcreti);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgrenciEkle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.MaskedTextBox MskTc;
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
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbYakin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVeliAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtYurtUcreti;
        private System.Windows.Forms.ComboBox cmbDogdugu;
        private System.Windows.Forms.ComboBox cmbYasadigi;
    }
}