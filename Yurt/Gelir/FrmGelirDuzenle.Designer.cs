namespace Yurt.Gelir
{
    partial class FrmGelirDuzenle
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
            this.rbFirma = new System.Windows.Forms.RadioButton();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.lblFirma = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.txtOdeyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOdemeTarih = new System.Windows.Forms.Label();
            this.lblOdenenMıktar = new System.Windows.Forms.Label();
            this.lblOdeyen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOdeyenKisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFirma
            // 
            this.rbFirma.AutoSize = true;
            this.rbFirma.Location = new System.Drawing.Point(448, 465);
            this.rbFirma.Name = "rbFirma";
            this.rbFirma.Size = new System.Drawing.Size(83, 20);
            this.rbFirma.TabIndex = 33;
            this.rbFirma.TabStop = true;
            this.rbFirma.Text = "Kurumsal";
            this.rbFirma.UseVisualStyleBackColor = true;
            this.rbFirma.CheckedChanged += new System.EventHandler(this.rbFirma_CheckedChanged);
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(251, 465);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(77, 20);
            this.rbBireysel.TabIndex = 32;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel";
            this.rbBireysel.UseVisualStyleBackColor = true;
            this.rbBireysel.CheckedChanged += new System.EventHandler(this.rbBireysel_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(173, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 31;
            // 
            // txtFirma
            // 
            this.txtFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirma.Location = new System.Drawing.Point(251, 511);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(343, 30);
            this.txtFirma.TabIndex = 6;
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirma.Location = new System.Drawing.Point(83, 511);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(122, 29);
            this.lblFirma.TabIndex = 29;
            this.lblFirma.Text = "Firma Adı:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(251, 574);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(240, 42);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(251, 407);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(251, 321);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(343, 34);
            this.mskTel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(600, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 35);
            this.label3.TabIndex = 25;
            this.label3.Text = "TL";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(251, 235);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(343, 34);
            this.dtTarih.TabIndex = 3;
            // 
            // txtOdenen
            // 
            this.txtOdenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenen.Location = new System.Drawing.Point(251, 153);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(343, 30);
            this.txtOdenen.TabIndex = 2;
            // 
            // txtOdeyen
            // 
            this.txtOdeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdeyen.Location = new System.Drawing.Point(307, -49);
            this.txtOdeyen.Name = "txtOdeyen";
            this.txtOdeyen.Size = new System.Drawing.Size(343, 30);
            this.txtOdeyen.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefon:";
            // 
            // lblOdemeTarih
            // 
            this.lblOdemeTarih.AutoSize = true;
            this.lblOdemeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTarih.Location = new System.Drawing.Point(112, 240);
            this.lblOdemeTarih.Name = "lblOdemeTarih";
            this.lblOdemeTarih.Size = new System.Drawing.Size(75, 29);
            this.lblOdemeTarih.TabIndex = 19;
            this.lblOdemeTarih.Text = "Tarih:";
            // 
            // lblOdenenMıktar
            // 
            this.lblOdenenMıktar.AutoSize = true;
            this.lblOdenenMıktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenMıktar.Location = new System.Drawing.Point(10, 154);
            this.lblOdenenMıktar.Name = "lblOdenenMıktar";
            this.lblOdenenMıktar.Size = new System.Drawing.Size(177, 29);
            this.lblOdenenMıktar.TabIndex = 18;
            this.lblOdenenMıktar.Text = "Ödenen Miktar:";
            // 
            // lblOdeyen
            // 
            this.lblOdeyen.AutoSize = true;
            this.lblOdeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeyen.Location = new System.Drawing.Point(139, -49);
            this.lblOdeyen.Name = "lblOdeyen";
            this.lblOdeyen.Size = new System.Drawing.Size(104, 29);
            this.lblOdeyen.TabIndex = 17;
            this.lblOdeyen.Text = "Ödeyen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 554);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtOdeyenKisi
            // 
            this.txtOdeyenKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdeyenKisi.Location = new System.Drawing.Point(251, 89);
            this.txtOdeyenKisi.Name = "txtOdeyenKisi";
            this.txtOdeyenKisi.Size = new System.Drawing.Size(343, 30);
            this.txtOdeyenKisi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ödeyen:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(387, 28);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(104, 29);
            this.lblid.TabIndex = 37;
            this.lblid.Text = "Ödeyen:";
            // 
            // FrmGelirDuzenle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 688);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtOdeyenKisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbFirma);
            this.Controls.Add(this.rbBireysel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.txtOdeyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOdemeTarih);
            this.Controls.Add(this.lblOdenenMıktar);
            this.Controls.Add(this.lblOdeyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGelirDuzenle";
            this.Text = "FrmGelirDuzenle";
            this.Load += new System.EventHandler(this.FrmGelirDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFirma;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtOdenen;
        private System.Windows.Forms.TextBox txtOdeyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOdemeTarih;
        private System.Windows.Forms.Label lblOdenenMıktar;
        private System.Windows.Forms.Label lblOdeyen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOdeyenKisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblid;
    }
}