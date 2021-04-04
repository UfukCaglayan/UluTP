namespace KingsTP
{
    partial class frmRezerveBilgi
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
            this.pnlSeferler = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlSeferler
            // 
            this.pnlSeferler.Location = new System.Drawing.Point(72, 328);
            this.pnlSeferler.Name = "pnlSeferler";
            this.pnlSeferler.Size = new System.Drawing.Size(1184, 674);
            this.pnlSeferler.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // frmRezerveBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSeferler);
            this.Name = "frmRezerveBilgi";
            this.Text = "Satış Bilgi";
            this.Load += new System.EventHandler(this.frmRezerveBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeferler;
        private System.Windows.Forms.Label label1;
    }
}