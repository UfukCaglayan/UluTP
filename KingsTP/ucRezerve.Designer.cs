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
            this.label2 = new System.Windows.Forms.Label();
            this.txTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKoltukNo
            // 
            this.lbKoltukNo.AutoSize = true;
            this.lbKoltukNo.Location = new System.Drawing.Point(21, 25);
            this.lbKoltukNo.Name = "lbKoltukNo";
            this.lbKoltukNo.Size = new System.Drawing.Size(69, 17);
            this.lbKoltukNo.TabIndex = 0;
            this.lbKoltukNo.Text = "Koltuk No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No";
            // 
            // txTCKimlikNo
            // 
            this.txTCKimlikNo.Location = new System.Drawing.Point(109, 35);
            this.txTCKimlikNo.Name = "txTCKimlikNo";
            this.txTCKimlikNo.Size = new System.Drawing.Size(100, 22);
            this.txTCKimlikNo.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(257, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(413, 35);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad";
            // 
            // ucRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txTCKimlikNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKoltukNo);
            this.Name = "ucRezerve";
            this.Size = new System.Drawing.Size(930, 75);
            this.Load += new System.EventHandler(this.ucRezerve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKoltukNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTCKimlikNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
    }
}
