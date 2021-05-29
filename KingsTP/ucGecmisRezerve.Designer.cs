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
            this.lbVaris = new System.Windows.Forms.Label();
            this.lbKalkis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTCKimlikNo
            // 
            this.lbTCKimlikNo.AutoSize = true;
            this.lbTCKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTCKimlikNo.Location = new System.Drawing.Point(336, 29);
            this.lbTCKimlikNo.Name = "lbTCKimlikNo";
            this.lbTCKimlikNo.Size = new System.Drawing.Size(119, 24);
            this.lbTCKimlikNo.TabIndex = 0;
            this.lbTCKimlikNo.Text = "TC Kimlik No";
            // 
            // lbAdSoyad
            // 
            this.lbAdSoyad.AutoSize = true;
            this.lbAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAdSoyad.Location = new System.Drawing.Point(510, 29);
            this.lbAdSoyad.Name = "lbAdSoyad";
            this.lbAdSoyad.Size = new System.Drawing.Size(92, 24);
            this.lbAdSoyad.TabIndex = 1;
            this.lbAdSoyad.Text = "Ad Soyad";
            // 
            // lbCinsiyet
            // 
            this.lbCinsiyet.AutoSize = true;
            this.lbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCinsiyet.Location = new System.Drawing.Point(664, 29);
            this.lbCinsiyet.Name = "lbCinsiyet";
            this.lbCinsiyet.Size = new System.Drawing.Size(75, 24);
            this.lbCinsiyet.TabIndex = 2;
            this.lbCinsiyet.Text = "Cinsiyet";
            // 
            // lbKoltukNo
            // 
            this.lbKoltukNo.AutoSize = true;
            this.lbKoltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKoltukNo.Location = new System.Drawing.Point(835, 29);
            this.lbKoltukNo.Name = "lbKoltukNo";
            this.lbKoltukNo.Size = new System.Drawing.Size(91, 24);
            this.lbKoltukNo.TabIndex = 3;
            this.lbKoltukNo.Text = "Koltuk No";
            // 
            // lbRezerveID
            // 
            this.lbRezerveID.AutoSize = true;
            this.lbRezerveID.Location = new System.Drawing.Point(3, 34);
            this.lbRezerveID.Name = "lbRezerveID";
            this.lbRezerveID.Size = new System.Drawing.Size(0, 17);
            this.lbRezerveID.TabIndex = 4;
            this.lbRezerveID.Visible = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(984, 24);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(122, 32);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lbVaris
            // 
            this.lbVaris.AutoSize = true;
            this.lbVaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbVaris.Location = new System.Drawing.Point(188, 29);
            this.lbVaris.Name = "lbVaris";
            this.lbVaris.Size = new System.Drawing.Size(52, 24);
            this.lbVaris.TabIndex = 7;
            this.lbVaris.Text = "Varış";
            // 
            // lbKalkis
            // 
            this.lbKalkis.AutoSize = true;
            this.lbKalkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKalkis.Location = new System.Drawing.Point(44, 29);
            this.lbKalkis.Name = "lbKalkis";
            this.lbKalkis.Size = new System.Drawing.Size(58, 24);
            this.lbKalkis.TabIndex = 6;
            this.lbKalkis.Text = "Kalkış";
            // 
            // ucGecmisRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbVaris);
            this.Controls.Add(this.lbKalkis);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lbRezerveID);
            this.Controls.Add(this.lbKoltukNo);
            this.Controls.Add(this.lbCinsiyet);
            this.Controls.Add(this.lbAdSoyad);
            this.Controls.Add(this.lbTCKimlikNo);
            this.Name = "ucGecmisRezerve";
            this.Size = new System.Drawing.Size(1170, 75);
            this.Load += new System.EventHandler(this.ucGecmisRezerve_Load);
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
        private System.Windows.Forms.Label lbVaris;
        private System.Windows.Forms.Label lbKalkis;
    }
}
