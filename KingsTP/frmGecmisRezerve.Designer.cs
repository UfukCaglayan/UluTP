namespace KingsTP
{
    partial class frmGecmisRezerve
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
            this.pnlGecmis = new System.Windows.Forms.Panel();
            this.lbMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGecmis
            // 
            this.pnlGecmis.Location = new System.Drawing.Point(72, 61);
            this.pnlGecmis.Name = "pnlGecmis";
            this.pnlGecmis.Size = new System.Drawing.Size(1184, 941);
            this.pnlGecmis.TabIndex = 29;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMain.ForeColor = System.Drawing.Color.Blue;
            this.lbMain.Location = new System.Drawing.Point(69, 19);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(84, 17);
            this.lbMain.TabIndex = 30;
            this.lbMain.Text = "ANA SAYFA";
            this.lbMain.Click += new System.EventHandler(this.lbMain_Click);
            // 
            // frmGecmisRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pnlGecmis);
            this.Name = "frmGecmisRezerve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Bilgi";
            this.Load += new System.EventHandler(this.frmRezerveBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGecmis;
        private System.Windows.Forms.Label lbMain;
    }
}