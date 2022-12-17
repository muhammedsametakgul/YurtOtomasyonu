namespace Yurt
{
    partial class FrmPersonelIzinVer
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSebep = new System.Windows.Forms.TextBox();
            this.dtBas = new System.Windows.Forms.DateTimePicker();
            this.dtBit = new System.Windows.Forms.DateTimePicker();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSebep = new System.Windows.Forms.Label();
            this.lblBas = new System.Windows.Forms.Label();
            this.lblBit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(174, 103);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(330, 34);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(174, 32);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(330, 34);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // txtSebep
            // 
            this.txtSebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSebep.Location = new System.Drawing.Point(174, 174);
            this.txtSebep.Multiline = true;
            this.txtSebep.Name = "txtSebep";
            this.txtSebep.Size = new System.Drawing.Size(330, 140);
            this.txtSebep.TabIndex = 4;
            // 
            // dtBas
            // 
            this.dtBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBas.Location = new System.Drawing.Point(174, 335);
            this.dtBas.Name = "dtBas";
            this.dtBas.Size = new System.Drawing.Size(330, 34);
            this.dtBas.TabIndex = 5;
            // 
            // dtBit
            // 
            this.dtBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBit.Location = new System.Drawing.Point(174, 406);
            this.dtBit.Name = "dtBit";
            this.dtBit.Size = new System.Drawing.Size(330, 34);
            this.dtBit.TabIndex = 6;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(96, 37);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(52, 29);
            this.lblTc.TabIndex = 7;
            this.lblTc.Text = "TC:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(24, 110);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(124, 29);
            this.lblAdSoyad.TabIndex = 8;
            this.lblAdSoyad.Text = "Ad-Soyad:";
            // 
            // lblSebep
            // 
            this.lblSebep.AutoSize = true;
            this.lblSebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSebep.Location = new System.Drawing.Point(57, 183);
            this.lblSebep.Name = "lblSebep";
            this.lblSebep.Size = new System.Drawing.Size(91, 29);
            this.lblSebep.TabIndex = 11;
            this.lblSebep.Text = "Sebep:";
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBas.Location = new System.Drawing.Point(24, 346);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(124, 29);
            this.lblBas.TabIndex = 12;
            this.lblBas.Text = "Başlangıç:";
            // 
            // lblBit
            // 
            this.lblBit.AutoSize = true;
            this.lblBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBit.Location = new System.Drawing.Point(83, 419);
            this.lblBit.Name = "lblBit";
            this.lblBit.Size = new System.Drawing.Size(65, 29);
            this.lblBit.TabIndex = 13;
            this.lblBit.Text = "Bitiş:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.lblBit);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.lblBas);
            this.groupBox1.Controls.Add(this.mskTc);
            this.groupBox1.Controls.Add(this.lblSebep);
            this.groupBox1.Controls.Add(this.txtSebep);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.dtBas);
            this.groupBox1.Controls.Add(this.dtBit);
            this.groupBox1.Location = new System.Drawing.Point(49, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 579);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel İzin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(361, 536);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(174, 472);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 31);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmPersonelIzinVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 665);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelIzinVer";
            this.Text = "Personel İzin";
            this.Load += new System.EventHandler(this.FrmPersonelIzinVer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSebep;
        private System.Windows.Forms.DateTimePicker dtBas;
        private System.Windows.Forms.DateTimePicker dtBit;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSebep;
        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.Label lblBit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}