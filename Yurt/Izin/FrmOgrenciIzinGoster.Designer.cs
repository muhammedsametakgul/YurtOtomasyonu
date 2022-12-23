namespace Yurt
{
    partial class FrmOgrenciIzinGoster
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
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.rbGecmis = new System.Windows.Forms.RadioButton();
            this.lblAktif = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtAra
            // 
            this.TxtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.Location = new System.Drawing.Point(941, 315);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(281, 34);
            this.TxtAra.TabIndex = 1;
            this.TxtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(936, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Veya Ada Göre Arama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Location = new System.Drawing.Point(29, 96);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(90, 20);
            this.rbAktif.TabIndex = 4;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "Aktif İzinler";
            this.rbAktif.UseVisualStyleBackColor = true;
            this.rbAktif.CheckedChanged += new System.EventHandler(this.rbAktif_CheckedChanged);
            // 
            // rbGecmis
            // 
            this.rbGecmis.AutoSize = true;
            this.rbGecmis.Location = new System.Drawing.Point(29, 33);
            this.rbGecmis.Name = "rbGecmis";
            this.rbGecmis.Size = new System.Drawing.Size(111, 20);
            this.rbGecmis.TabIndex = 5;
            this.rbGecmis.TabStop = true;
            this.rbGecmis.Text = "Geçmiş İzinler";
            this.rbGecmis.UseVisualStyleBackColor = true;
            this.rbGecmis.CheckedChanged += new System.EventHandler(this.rbGecmis_CheckedChanged);
            // 
            // lblAktif
            // 
            this.lblAktif.AutoSize = true;
            this.lblAktif.Location = new System.Drawing.Point(1132, 434);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(44, 16);
            this.lblAktif.TabIndex = 6;
            this.lblAktif.Text = "label2";
            this.lblAktif.Visible = false;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(1135, 507);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(17, 16);
            this.lblTc.TabIndex = 7;
            this.lblTc.Text = "tc";
            this.lblTc.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHepsi);
            this.groupBox1.Controls.Add(this.rbAktif);
            this.groupBox1.Controls.Add(this.rbGecmis);
            this.groupBox1.Location = new System.Drawing.Point(941, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih";
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Location = new System.Drawing.Point(29, 146);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(117, 20);
            this.rbHepsi.TabIndex = 6;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsini Göster";
            this.rbHepsi.UseVisualStyleBackColor = true;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(906, 470);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(10, 10);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // FrmOgrenciIzinGoster
            // 
            this.AcceptButton = this.btnListele;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 663);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblAktif);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOgrenciIzinGoster";
            this.Text = "FrmIzinGoster";
            this.Load += new System.EventHandler(this.FrmOgrenciIzinGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbGecmis;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.Label lblAktif;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.Button btnListele;
    }
}