namespace KingsTP
{
    partial class ucRezerve
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbKoltukNo = new System.Windows.Forms.Label();
            this.txTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbKoltukNo
            // 
            this.lbKoltukNo.AutoSize = true;
            this.lbKoltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKoltukNo.Location = new System.Drawing.Point(21, 15);
            this.lbKoltukNo.Name = "lbKoltukNo";
            this.lbKoltukNo.Size = new System.Drawing.Size(97, 25);
            this.lbKoltukNo.TabIndex = 0;
            this.lbKoltukNo.Text = "Koltuk No";
            // 
            // txTCKimlikNo
            // 
            this.txTCKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txTCKimlikNo.Location = new System.Drawing.Point(187, 12);
            this.txTCKimlikNo.MaxLength = 11;
            this.txTCKimlikNo.Name = "txTCKimlikNo";
            this.txTCKimlikNo.Size = new System.Drawing.Size(128, 28);
            this.txTCKimlikNo.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(411, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(128, 28);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(628, 12);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(128, 28);
            this.txtSoyad.TabIndex = 6;
            // 
            // ucRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txTCKimlikNo);
            this.Controls.Add(this.lbKoltukNo);
            this.Name = "ucRezerve";
            this.Size = new System.Drawing.Size(810, 55);
            this.Load += new System.EventHandler(this.ucRezerve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKoltukNo;
        private System.Windows.Forms.TextBox txTCKimlikNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}
