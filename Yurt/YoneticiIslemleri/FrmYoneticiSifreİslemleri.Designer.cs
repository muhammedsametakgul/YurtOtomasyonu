namespace Yurt
{
    partial class FrmYoneticiSifreİslemleri
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
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(150, 37);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(186, 38);
            this.MskTC.TabIndex = 0;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC:";
            // 
            // btnDogrula
            // 
            this.btnDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDogrula.Location = new System.Drawing.Point(150, 166);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(160, 43);
            this.btnDogrula.TabIndex = 2;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmYoneticiSifreİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 325);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Name = "FrmYoneticiSifreİslemleri";
            this.Text = "FrmYoneticiSifreİslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDogrula;
    }
}