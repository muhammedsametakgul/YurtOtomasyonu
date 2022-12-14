namespace Yurt
{
    partial class FrmOgrenciIzinDuzenle
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
            this.DateBit = new System.Windows.Forms.DateTimePicker();
            this.DateBas = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSebep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblIzin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateBit
            // 
            this.DateBit.Location = new System.Drawing.Point(182, 114);
            this.DateBit.Name = "DateBit";
            this.DateBit.Size = new System.Drawing.Size(200, 22);
            this.DateBit.TabIndex = 21;
            // 
            // DateBas
            // 
            this.DateBas.Location = new System.Drawing.Point(182, 51);
            this.DateBas.Name = "DateBas";
            this.DateBas.Size = new System.Drawing.Size(200, 22);
            this.DateBas.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(71, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bitiş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Başlangıç:";
            // 
            // TxtSebep
            // 
            this.TxtSebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSebep.Location = new System.Drawing.Point(182, 172);
            this.TxtSebep.Name = "TxtSebep";
            this.TxtSebep.Size = new System.Drawing.Size(200, 34);
            this.TxtSebep.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-3, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "İzin Sebebi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 531);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(168, 347);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(214, 45);
            this.btnDuzenle.TabIndex = 25;
            this.btnDuzenle.Text = "button1";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(93, 471);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 16);
            this.lblid.TabIndex = 26;
            this.lblid.Text = "id";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(264, 471);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(23, 16);
            this.lblTc.TabIndex = 27;
            this.lblTc.Text = "Tc";
            // 
            // lblIzin
            // 
            this.lblIzin.AutoSize = true;
            this.lblIzin.Location = new System.Drawing.Point(38, 333);
            this.lblIzin.Name = "lblIzin";
            this.lblIzin.Size = new System.Drawing.Size(44, 16);
            this.lblIzin.TabIndex = 28;
            this.lblIzin.Text = "label1";
            // 
            // FrmOgrenciIzinDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 594);
            this.Controls.Add(this.lblIzin);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtSebep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBit);
            this.Controls.Add(this.DateBas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOgrenciIzinDuzenle";
            this.Text = "FrmIzinDuzenle";
            this.Load += new System.EventHandler(this.FrmIzinDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateBit;
        private System.Windows.Forms.DateTimePicker DateBas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSebep;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblIzin;
    }
}