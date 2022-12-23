namespace Yurt
{
    partial class AnaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiris));
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnMudurGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(291, 251);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(301, 64);
            this.btnAdminGiris.TabIndex = 2;
            this.btnAdminGiris.Text = "Memur Girişi";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMudurGiris
            // 
            this.btnMudurGiris.Location = new System.Drawing.Point(291, 104);
            this.btnMudurGiris.Name = "btnMudurGiris";
            this.btnMudurGiris.Size = new System.Drawing.Size(301, 64);
            this.btnMudurGiris.TabIndex = 3;
            this.btnMudurGiris.Text = "Müdür Girişi";
            this.btnMudurGiris.UseVisualStyleBackColor = true;
            this.btnMudurGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 592);
            this.Controls.Add(this.btnMudurGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA GİRİŞ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaGiris_FormClosed);
            this.Load += new System.EventHandler(this.AnaGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnMudurGiris;
    }
}

