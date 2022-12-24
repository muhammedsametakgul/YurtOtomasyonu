namespace Yurt
{
    partial class FrmGiderlerListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTarihAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAylik = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPersonelMaas = new System.Windows.Forms.RadioButton();
            this.rbMemurMaas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtTarihAra
            // 
            this.txtTarihAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarihAra.Location = new System.Drawing.Point(597, 537);
            this.txtTarihAra.Name = "txtTarihAra";
            this.txtTarihAra.Size = new System.Drawing.Size(296, 38);
            this.txtTarihAra.TabIndex = 1;
            this.txtTarihAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(608, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarihe Göre Arama:";
            // 
            // rbAylik
            // 
            this.rbAylik.AutoSize = true;
            this.rbAylik.Location = new System.Drawing.Point(19, 21);
            this.rbAylik.Name = "rbAylik";
            this.rbAylik.Size = new System.Drawing.Size(108, 20);
            this.rbAylik.TabIndex = 3;
            this.rbAylik.TabStop = true;
            this.rbAylik.Text = "Aylık Giderler";
            this.rbAylik.UseVisualStyleBackColor = true;
            this.rbAylik.CheckedChanged += new System.EventHandler(this.rbAylik_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMemurMaas);
            this.groupBox1.Controls.Add(this.rbPersonelMaas);
            this.groupBox1.Controls.Add(this.rbAylik);
            this.groupBox1.Location = new System.Drawing.Point(46, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbPersonelMaas
            // 
            this.rbPersonelMaas.AutoSize = true;
            this.rbPersonelMaas.Location = new System.Drawing.Point(19, 62);
            this.rbPersonelMaas.Name = "rbPersonelMaas";
            this.rbPersonelMaas.Size = new System.Drawing.Size(137, 20);
            this.rbPersonelMaas.TabIndex = 4;
            this.rbPersonelMaas.TabStop = true;
            this.rbPersonelMaas.Text = "Personel Maaşları";
            this.rbPersonelMaas.UseVisualStyleBackColor = true;
            this.rbPersonelMaas.CheckedChanged += new System.EventHandler(this.rbPersonelMaas_CheckedChanged);
            // 
            // rbMemurMaas
            // 
            this.rbMemurMaas.AutoSize = true;
            this.rbMemurMaas.Location = new System.Drawing.Point(19, 103);
            this.rbMemurMaas.Name = "rbMemurMaas";
            this.rbMemurMaas.Size = new System.Drawing.Size(106, 20);
            this.rbMemurMaas.TabIndex = 5;
            this.rbMemurMaas.TabStop = true;
            this.rbMemurMaas.Text = "Memur Maaş";
            this.rbMemurMaas.UseVisualStyleBackColor = true;
            this.rbMemurMaas.CheckedChanged += new System.EventHandler(this.rbMemurMaas_CheckedChanged);
            // 
            // FrmGiderlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1335, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarihAra);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiderlerListesi";
            this.Text = "FrmGiderlerListesi";
            this.Load += new System.EventHandler(this.FrmGiderlerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTarihAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAylik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMemurMaas;
        private System.Windows.Forms.RadioButton rbPersonelMaas;
    }
}