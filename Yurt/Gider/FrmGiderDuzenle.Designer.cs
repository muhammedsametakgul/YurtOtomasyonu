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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(205, 513);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(259, 46);
            this.BtnGuncelle.TabIndex = 29;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // MskDiger
            // 
            this.MskDiger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDiger.Location = new System.Drawing.Point(204, 442);
            this.MskDiger.Mask = "00000000";
            this.MskDiger.Name = "MskDiger";
            this.MskDiger.Size = new System.Drawing.Size(267, 34);
            this.MskDiger.TabIndex = 28;
            // 
            // MskSu
            // 
            this.MskSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskSu.Location = new System.Drawing.Point(204, 393);
            this.MskSu.Mask = "00000000";
            this.MskSu.Name = "MskSu";
            this.MskSu.Size = new System.Drawing.Size(267, 34);
            this.MskSu.TabIndex = 27;
            // 
            // MskPersonel
            // 
            this.MskPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskPersonel.Location = new System.Drawing.Point(204, 344);
            this.MskPersonel.Mask = "00000000";
            this.MskPersonel.Name = "MskPersonel";
            this.MskPersonel.Size = new System.Drawing.Size(267, 34);
            this.MskPersonel.TabIndex = 26;
            // 
            // MskGida
            // 
            this.MskGida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskGida.Location = new System.Drawing.Point(204, 295);
            this.MskGida.Mask = "00000000";
            this.MskGida.Name = "MskGida";
            this.MskGida.Size = new System.Drawing.Size(267, 34);
            this.MskGida.TabIndex = 25;
            // 
            // MskInternet
            // 
            this.MskInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskInternet.Location = new System.Drawing.Point(204, 246);
            this.MskInternet.Mask = "00000000";
            this.MskInternet.Name = "MskInternet";
            this.MskInternet.Size = new System.Drawing.Size(267, 34);
            this.MskInternet.TabIndex = 24;
            // 
            // MskDogalgaz
            // 
            this.MskDogalgaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogalgaz.Location = new System.Drawing.Point(204, 197);
            this.MskDogalgaz.Mask = "00000000";
            this.MskDogalgaz.Name = "MskDogalgaz";
            this.MskDogalgaz.Size = new System.Drawing.Size(267, 34);
            this.MskDogalgaz.TabIndex = 23;
            this.MskDogalgaz.ValidatingType = typeof(int);
            // 
            // MskElektrik
            // 
            this.MskElektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskElektrik.Location = new System.Drawing.Point(204, 148);
            this.MskElektrik.Mask = "00000000";
            this.MskElektrik.Name = "MskElektrik";
            this.MskElektrik.Size = new System.Drawing.Size(267, 34);
            this.MskElektrik.TabIndex = 22;
            this.MskElektrik.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 437);
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
            this.label5.Location = new System.Drawing.Point(92, 388);
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
            this.label6.Location = new System.Drawing.Point(24, 339);
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
            this.label3.Location = new System.Drawing.Point(41, 241);
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
            this.label4.Location = new System.Drawing.Point(70, 290);
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
            this.label2.Location = new System.Drawing.Point(19, 192);
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
            this.label1.Location = new System.Drawing.Point(41, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Elektrik:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(565, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 475);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(562, 26);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 32;
            this.lblid.Text = "label8";
            this.lblid.Visible = false;
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTarih.Location = new System.Drawing.Point(204, 89);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(267, 34);
            this.MskTarih.TabIndex = 34;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(41, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label8.Size = new System.Drawing.Size(75, 39);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tarih:";
            // 
            // FrmGiderDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 572);
            this.Controls.Add(this.MskTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.MskDiger);
            this.Controls.Add(this.MskSu);
            this.Controls.Add(this.MskPersonel);
            this.Controls.Add(this.MskGida);
            this.Controls.Add(this.MskInternet);
            this.Controls.Add(this.MskDogalgaz);
            this.Controls.Add(this.MskElektrik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGiderDuzenle";
            this.Text = "FrmGiderDuzenle";
            this.Load += new System.EventHandler(this.FrmGiderDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}