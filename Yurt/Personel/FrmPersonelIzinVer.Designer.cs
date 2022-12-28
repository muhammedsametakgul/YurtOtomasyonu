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
            this.rbPersonel = new System.Windows.Forms.RadioButton();
            this.rbMemur = new System.Windows.Forms.RadioButton();
            this.dgvGoster = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(175, 157);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(330, 34);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // mskTc
            // 
            this.mskTc.Enabled = false;
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(175, 86);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(330, 34);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // txtSebep
            // 
            this.txtSebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSebep.Location = new System.Drawing.Point(175, 228);
            this.txtSebep.Multiline = true;
            this.txtSebep.Name = "txtSebep";
            this.txtSebep.Size = new System.Drawing.Size(330, 140);
            this.txtSebep.TabIndex = 4;
            // 
            // dtBas
            // 
            this.dtBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBas.Location = new System.Drawing.Point(175, 400);
            this.dtBas.Name = "dtBas";
            this.dtBas.Size = new System.Drawing.Size(330, 34);
            this.dtBas.TabIndex = 5;
            // 
            // dtBit
            // 
            this.dtBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBit.Location = new System.Drawing.Point(175, 473);
            this.dtBit.Name = "dtBit";
            this.dtBit.Size = new System.Drawing.Size(330, 34);
            this.dtBit.TabIndex = 6;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(97, 91);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(52, 29);
            this.lblTc.TabIndex = 7;
            this.lblTc.Text = "TC:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(25, 162);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(124, 29);
            this.lblAdSoyad.TabIndex = 8;
            this.lblAdSoyad.Text = "Ad-Soyad:";
            // 
            // lblSebep
            // 
            this.lblSebep.AutoSize = true;
            this.lblSebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSebep.Location = new System.Drawing.Point(58, 237);
            this.lblSebep.Name = "lblSebep";
            this.lblSebep.Size = new System.Drawing.Size(91, 29);
            this.lblSebep.TabIndex = 11;
            this.lblSebep.Text = "Sebep:";
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBas.Location = new System.Drawing.Point(25, 405);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(124, 29);
            this.lblBas.TabIndex = 12;
            this.lblBas.Text = "Başlangıç:";
            // 
            // lblBit
            // 
            this.lblBit.AutoSize = true;
            this.lblBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBit.Location = new System.Drawing.Point(84, 478);
            this.lblBit.Name = "lblBit";
            this.lblBit.Size = new System.Drawing.Size(65, 29);
            this.lblBit.TabIndex = 13;
            this.lblBit.Text = "Bitiş:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPersonel);
            this.groupBox1.Controls.Add(this.rbMemur);
            this.groupBox1.Controls.Add(this.dgvGoster);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbPersonel
            // 
            this.rbPersonel.AutoSize = true;
            this.rbPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPersonel.Location = new System.Drawing.Point(347, 36);
            this.rbPersonel.Name = "rbPersonel";
            this.rbPersonel.Size = new System.Drawing.Size(102, 26);
            this.rbPersonel.TabIndex = 17;
            this.rbPersonel.TabStop = true;
            this.rbPersonel.Text = "Personel";
            this.rbPersonel.UseVisualStyleBackColor = true;
            this.rbPersonel.CheckedChanged += new System.EventHandler(this.rbPersonel_CheckedChanged);
            // 
            // rbMemur
            // 
            this.rbMemur.AutoSize = true;
            this.rbMemur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMemur.Location = new System.Drawing.Point(175, 36);
            this.rbMemur.Name = "rbMemur";
            this.rbMemur.Size = new System.Drawing.Size(85, 26);
            this.rbMemur.TabIndex = 16;
            this.rbMemur.TabStop = true;
            this.rbMemur.Text = "Memur";
            this.rbMemur.UseVisualStyleBackColor = true;
            this.rbMemur.CheckedChanged += new System.EventHandler(this.rbMemur_CheckedChanged);
            // 
            // dgvGoster
            // 
            this.dgvGoster.AllowUserToAddRows = false;
            this.dgvGoster.AllowUserToDeleteRows = false;
            this.dgvGoster.AllowUserToResizeColumns = false;
            this.dgvGoster.AllowUserToResizeRows = false;
            this.dgvGoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGoster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGoster.BackgroundColor = System.Drawing.Color.White;
            this.dgvGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoster.Location = new System.Drawing.Point(648, 21);
            this.dgvGoster.Name = "dgvGoster";
            this.dgvGoster.ReadOnly = true;
            this.dgvGoster.RowHeadersWidth = 51;
            this.dgvGoster.RowTemplate.Height = 24;
            this.dgvGoster.Size = new System.Drawing.Size(415, 536);
            this.dgvGoster.TabIndex = 15;
            this.dgvGoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(255, 526);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvGoster;
        private System.Windows.Forms.RadioButton rbPersonel;
        private System.Windows.Forms.RadioButton rbMemur;
    }
}