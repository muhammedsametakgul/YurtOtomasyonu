namespace Yurt
{
    partial class FrmOgrenciIzinEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSebep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MskOgrenciTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.DateBas = new System.Windows.Forms.DateTimePicker();
            this.DateBit = new System.Windows.Forms.DateTimePicker();
            this.btnIzinVer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad-Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Enabled = false;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(225, 101);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(222, 34);
            this.TxtAd.TabIndex = 2;
            // 
            // MskTc
            // 
            this.MskTc.Enabled = false;
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(225, 32);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(222, 34);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.Click += new System.EventHandler(this.MskTc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(131, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC:";
            // 
            // TxtSebep
            // 
            this.TxtSebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSebep.Location = new System.Drawing.Point(225, 170);
            this.TxtSebep.Name = "TxtSebep";
            this.TxtSebep.Size = new System.Drawing.Size(222, 34);
            this.TxtSebep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "İzin Sebebi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(59, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Başlangıç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(118, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bitiş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(-11, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Öğrenci Telefon:";
            // 
            // MskOgrenciTel
            // 
            this.MskOgrenciTel.Enabled = false;
            this.MskOgrenciTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrenciTel.Location = new System.Drawing.Point(225, 353);
            this.MskOgrenciTel.Mask = "(999) 000-0000";
            this.MskOgrenciTel.Name = "MskOgrenciTel";
            this.MskOgrenciTel.Size = new System.Drawing.Size(222, 34);
            this.MskOgrenciTel.TabIndex = 6;
            this.MskOgrenciTel.Click += new System.EventHandler(this.MskOgrenciTel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Veli Telefon:";
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTel.Location = new System.Drawing.Point(225, 422);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(222, 34);
            this.MskVeliTel.TabIndex = 7;
            this.MskVeliTel.Click += new System.EventHandler(this.MskVeliTel_Click);
            // 
            // DateBas
            // 
            this.DateBas.Location = new System.Drawing.Point(225, 239);
            this.DateBas.Name = "DateBas";
            this.DateBas.Size = new System.Drawing.Size(200, 22);
            this.DateBas.TabIndex = 4;
            // 
            // DateBit
            // 
            this.DateBit.Location = new System.Drawing.Point(225, 296);
            this.DateBit.Name = "DateBit";
            this.DateBit.Size = new System.Drawing.Size(200, 22);
            this.DateBit.TabIndex = 5;
            // 
            // btnIzinVer
            // 
            this.btnIzinVer.Location = new System.Drawing.Point(225, 546);
            this.btnIzinVer.Name = "btnIzinVer";
            this.btnIzinVer.Size = new System.Drawing.Size(151, 49);
            this.btnIzinVer.TabIndex = 19;
            this.btnIzinVer.Text = "İzin Ver";
            this.btnIzinVer.UseVisualStyleBackColor = true;
            this.btnIzinVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(524, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 448);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "label8";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(717, 549);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(346, 34);
            this.txtAra.TabIndex = 23;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(778, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "İsme Göre Arama";
            // 
            // FrmOgrenciIzinEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 724);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzinVer);
            this.Controls.Add(this.DateBit);
            this.Controls.Add(this.DateBas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MskVeliTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskOgrenciTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSebep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOgrenciIzinEkle";
            this.Text = "OgrenciIzinEkle";
            this.Load += new System.EventHandler(this.OgrenciIzinEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSebep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskOgrenciTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.DateTimePicker DateBas;
        private System.Windows.Forms.DateTimePicker DateBit;
        private System.Windows.Forms.Button btnIzinVer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label9;
    }
}