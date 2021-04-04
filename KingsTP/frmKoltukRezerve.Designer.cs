namespace KingsTP
{
    partial class frmKoltukRezerve
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
            this.pnlCinsiyet = new System.Windows.Forms.Panel();
            this.btnKadin = new System.Windows.Forms.Button();
            this.btnErkek = new System.Windows.Forms.Button();
            this.pnlBilgiler = new System.Windows.Forms.Panel();
            this.btnRezerve = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.pnlCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCinsiyet
            // 
            this.pnlCinsiyet.Controls.Add(this.btnKadin);
            this.pnlCinsiyet.Controls.Add(this.btnErkek);
            this.pnlCinsiyet.Location = new System.Drawing.Point(21, 12);
            this.pnlCinsiyet.Name = "pnlCinsiyet";
            this.pnlCinsiyet.Size = new System.Drawing.Size(178, 68);
            this.pnlCinsiyet.TabIndex = 0;
            // 
            // btnKadin
            // 
            this.btnKadin.Location = new System.Drawing.Point(97, 12);
            this.btnKadin.Name = "btnKadin";
            this.btnKadin.Size = new System.Drawing.Size(60, 40);
            this.btnKadin.TabIndex = 1;
            this.btnKadin.Text = "K";
            this.btnKadin.UseVisualStyleBackColor = true;
            this.btnKadin.Click += new System.EventHandler(this.btnSecim_Click);
            // 
            // btnErkek
            // 
            this.btnErkek.Location = new System.Drawing.Point(19, 12);
            this.btnErkek.Name = "btnErkek";
            this.btnErkek.Size = new System.Drawing.Size(60, 40);
            this.btnErkek.TabIndex = 0;
            this.btnErkek.Text = "E";
            this.btnErkek.UseVisualStyleBackColor = true;
            this.btnErkek.Click += new System.EventHandler(this.btnSecim_Click);
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.Location = new System.Drawing.Point(206, 452);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(1501, 554);
            this.pnlBilgiler.TabIndex = 2;
            // 
            // btnRezerve
            // 
            this.btnRezerve.Location = new System.Drawing.Point(206, 396);
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.Size = new System.Drawing.Size(134, 35);
            this.btnRezerve.TabIndex = 3;
            this.btnRezerve.Text = "Rezerve Et";
            this.btnRezerve.UseVisualStyleBackColor = true;
            this.btnRezerve.Click += new System.EventHandler(this.btnRezerve_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(1573, 396);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(134, 35);
            this.btnOdeme.TabIndex = 4;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // frmKoltukRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.btnRezerve);
            this.Controls.Add(this.pnlBilgiler);
            this.Controls.Add(this.pnlCinsiyet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKoltukRezerve";
            this.Text = "Koltuk Rezerve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKoltukRezerve_Load);
            this.pnlCinsiyet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCinsiyet;
        private System.Windows.Forms.Button btnKadin;
        private System.Windows.Forms.Button btnErkek;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.Button btnRezerve;
        private System.Windows.Forms.Button btnOdeme;
    }
}