namespace KingsTP
{
    partial class ucGecmisRezerve
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
            this.lbTCKimlikNo = new System.Windows.Forms.Label();
            this.lbAdSoyad = new System.Windows.Forms.Label();
            this.lbCinsiyet = new System.Windows.Forms.Label();
            this.lbKoltukNo = new System.Windows.Forms.Label();
            this.lbRezerveID = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTCKimlikNo
            // 
            this.lbTCKimlikNo.AutoSize = true;
            this.lbTCKimlikNo.Location = new System.Drawing.Point(44, 29);
            this.lbTCKimlikNo.Name = "lbTCKimlikNo";
            this.lbTCKimlikNo.Size = new System.Drawing.Size(88, 17);
            this.lbTCKimlikNo.TabIndex = 0;
            this.lbTCKimlikNo.Text = "TC Kimlik No";
            // 
            // lbAdSoyad
            // 
            this.lbAdSoyad.AutoSize = true;
            this.lbAdSoyad.Location = new System.Drawing.Point(203, 29);
            this.lbAdSoyad.Name = "lbAdSoyad";
            this.lbAdSoyad.Size = new System.Drawing.Size(69, 17);
            this.lbAdSoyad.TabIndex = 1;
            this.lbAdSoyad.Text = "Ad Soyad";
            // 
            // lbCinsiyet
            // 
            this.lbCinsiyet.AutoSize = true;
            this.lbCinsiyet.Location = new System.Drawing.Point(364, 29);
            this.lbCinsiyet.Name = "lbCinsiyet";
            this.lbCinsiyet.Size = new System.Drawing.Size(57, 17);
            this.lbCinsiyet.TabIndex = 2;
            this.lbCinsiyet.Text = "Cinsiyet";
            // 
            // lbKoltukNo
            // 
            this.lbKoltukNo.AutoSize = true;
            this.lbKoltukNo.Location = new System.Drawing.Point(541, 29);
            this.lbKoltukNo.Name = "lbKoltukNo";
            this.lbKoltukNo.Size = new System.Drawing.Size(69, 17);
            this.lbKoltukNo.TabIndex = 3;
            this.lbKoltukNo.Text = "Koltuk No";
            // 
            // lbRezerveID
            // 
            this.lbRezerveID.AutoSize = true;
            this.lbRezerveID.Location = new System.Drawing.Point(3, 29);
            this.lbRezerveID.Name = "lbRezerveID";
            this.lbRezerveID.Size = new System.Drawing.Size(0, 17);
            this.lbRezerveID.TabIndex = 4;
            this.lbRezerveID.Visible = false;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(655, 23);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 23);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // ucGecmisRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lbRezerveID);
            this.Controls.Add(this.lbKoltukNo);
            this.Controls.Add(this.lbCinsiyet);
            this.Controls.Add(this.lbAdSoyad);
            this.Controls.Add(this.lbTCKimlikNo);
            this.Name = "ucGecmisRezerve";
            this.Size = new System.Drawing.Size(930, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTCKimlikNo;
        private System.Windows.Forms.Label lbAdSoyad;
        private System.Windows.Forms.Label lbCinsiyet;
        private System.Windows.Forms.Label lbKoltukNo;
        private System.Windows.Forms.Label lbRezerveID;
        private System.Windows.Forms.Button btnIptal;
    }
}
