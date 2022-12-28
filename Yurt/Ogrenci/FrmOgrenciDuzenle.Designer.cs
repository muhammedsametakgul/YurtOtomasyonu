namespace Yurt
{
    partial class FrmOgrenciDuzenle
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
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOda = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.cmbYasadigi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbYakin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVeliAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDogdugu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbOda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(1225, 143);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(156, 51);
            this.BtnSil.TabIndex = 37;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(1225, 30);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(156, 51);
            this.BtnGuncelle.TabIndex = 39;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 541);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 311);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "1";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOda);
            this.groupBox3.Controls.Add(this.txtAdres);
            this.groupBox3.Controls.Add(this.cmbYasadigi);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtMail);
            this.groupBox3.Controls.Add(this.MskTel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(600, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 506);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // lblOda
            // 
            this.lblOda.AutoSize = true;
            this.lblOda.Location = new System.Drawing.Point(120, 449);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(51, 16);
            this.lblOda.TabIndex = 44;
            this.lblOda.Text = "label11";
            this.lblOda.Visible = false;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(152, 98);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(395, 201);
            this.txtAdres.TabIndex = 43;
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
            this.cmbYasadigi.Location = new System.Drawing.Point(152, 50);
            this.cmbYasadigi.Name = "cmbYasadigi";
            this.cmbYasadigi.Size = new System.Drawing.Size(395, 24);
            this.cmbYasadigi.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(15, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Yaşadığı İl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(67, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mail:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(152, 326);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(395, 22);
            this.TxtMail.TabIndex = 13;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(152, 378);
            this.MskTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(395, 22);
            this.MskTel.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefon:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbYakin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtVeliAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.MskVeliTel);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 197);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veli Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(80, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Yakınlık:";
            // 
            // cmbYakin
            // 
            this.cmbYakin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYakin.FormattingEnabled = true;
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
            this.cmbYakin.Location = new System.Drawing.Point(187, 94);
            this.cmbYakin.Name = "cmbYakin";
            this.cmbYakin.Size = new System.Drawing.Size(344, 24);
            this.cmbYakin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ad:";
            // 
            // txtVeliAd
            // 
            this.txtVeliAd.Location = new System.Drawing.Point(187, 38);
            this.txtVeliAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtVeliAd.Name = "txtVeliAd";
            this.txtVeliAd.Size = new System.Drawing.Size(344, 22);
            this.txtVeliAd.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-4, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefon Numarası:";
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.Location = new System.Drawing.Point(187, 152);
            this.MskVeliTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(344, 22);
            this.MskVeliTel.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDogdugu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MskTc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBolum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CmbOda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.MskDogum);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 303);
            this.groupBox1.TabIndex = 42;
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
            this.cmbDogdugu.Location = new System.Drawing.Point(198, 208);
            this.cmbDogdugu.Name = "cmbDogdugu";
            this.cmbDogdugu.Size = new System.Drawing.Size(344, 24);
            this.cmbDogdugu.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(63, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Öğrenci TC:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(198, 30);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(344, 22);
            this.MskTc.TabIndex = 25;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(69, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Doğduğu İl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad Soyad:";
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(198, 165);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(344, 22);
            this.txtBolum.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(96, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Oda No:";
            // 
            // CmbOda
            // 
            this.CmbOda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOda.FormattingEnabled = true;
            this.CmbOda.Location = new System.Drawing.Point(198, 257);
            this.CmbOda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CmbOda.Name = "CmbOda";
            this.CmbOda.Size = new System.Drawing.Size(344, 24);
            this.CmbOda.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(106, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bölüm:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(198, 75);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(344, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // MskDogum
            // 
            this.MskDogum.Location = new System.Drawing.Point(198, 121);
            this.MskDogum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(344, 22);
            this.MskDogum.TabIndex = 2;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(46, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Doğum Tarihi:";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(1225, 326);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(209, 34);
            this.txtArama.TabIndex = 45;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1280, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 46;
            this.label16.Text = "Ad İle Arama:";
            // 
            // FrmOgrenciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 897);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOgrenciDuzenle";
            this.Text = "FrmOgrenciDuzenle";
            this.Load += new System.EventHandler(this.FrmOgrenciDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbYakin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeliAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbOda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.ComboBox cmbDogdugu;
        private System.Windows.Forms.ComboBox cmbYasadigi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblOda;
    }
}