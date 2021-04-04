namespace KingsTP
{
    partial class ucSefer
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
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbKalanKoltuk = new System.Windows.Forms.Label();
            this.lbHareket = new System.Windows.Forms.Label();
            this.lbVarisTerminal = new System.Windows.Forms.Label();
            this.lbKalkisSaat = new System.Windows.Forms.Label();
            this.lbKalkisTerminal = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.lbSeferID = new System.Windows.Forms.Label();
            this.lbKoltukTuru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Location = new System.Drawing.Point(798, 34);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(38, 17);
            this.lbFiyat.TabIndex = 33;
            this.lbFiyat.Text = "Fiyat";
            // 
            // lbKalanKoltuk
            // 
            this.lbKalanKoltuk.AutoSize = true;
            this.lbKalanKoltuk.Location = new System.Drawing.Point(495, 34);
            this.lbKalanKoltuk.Name = "lbKalanKoltuk";
            this.lbKalanKoltuk.Size = new System.Drawing.Size(87, 17);
            this.lbKalanKoltuk.TabIndex = 32;
            this.lbKalanKoltuk.Text = "Kalan Koltuk";
            // 
            // lbHareket
            // 
            this.lbHareket.AutoSize = true;
            this.lbHareket.Location = new System.Drawing.Point(320, 47);
            this.lbHareket.Name = "lbHareket";
            this.lbHareket.Size = new System.Drawing.Size(73, 17);
            this.lbHareket.TabIndex = 31;
            this.lbHareket.Text = "Varış Saat";
            // 
            // lbVarisTerminal
            // 
            this.lbVarisTerminal.AutoSize = true;
            this.lbVarisTerminal.Location = new System.Drawing.Point(320, 16);
            this.lbVarisTerminal.Name = "lbVarisTerminal";
            this.lbVarisTerminal.Size = new System.Drawing.Size(99, 17);
            this.lbVarisTerminal.TabIndex = 30;
            this.lbVarisTerminal.Text = "Varış Terminal";
            // 
            // lbKalkisSaat
            // 
            this.lbKalkisSaat.AutoSize = true;
            this.lbKalkisSaat.Location = new System.Drawing.Point(63, 47);
            this.lbKalkisSaat.Name = "lbKalkisSaat";
            this.lbKalkisSaat.Size = new System.Drawing.Size(78, 17);
            this.lbKalkisSaat.TabIndex = 29;
            this.lbKalkisSaat.Text = "Kalkış Saat";
            // 
            // lbKalkisTerminal
            // 
            this.lbKalkisTerminal.AutoSize = true;
            this.lbKalkisTerminal.Location = new System.Drawing.Point(63, 16);
            this.lbKalkisTerminal.Name = "lbKalkisTerminal";
            this.lbKalkisTerminal.Size = new System.Drawing.Size(104, 17);
            this.lbKalkisTerminal.TabIndex = 28;
            this.lbKalkisTerminal.Text = "Kalkış Terminal";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(928, 34);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(106, 23);
            this.btnSatinAl.TabIndex = 34;
            this.btnSatinAl.Text = "SATIN AL";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // lbSeferID
            // 
            this.lbSeferID.AutoSize = true;
            this.lbSeferID.Location = new System.Drawing.Point(4, 16);
            this.lbSeferID.Name = "lbSeferID";
            this.lbSeferID.Size = new System.Drawing.Size(0, 17);
            this.lbSeferID.TabIndex = 35;
            this.lbSeferID.Visible = false;
            // 
            // lbKoltukTuru
            // 
            this.lbKoltukTuru.AutoSize = true;
            this.lbKoltukTuru.Location = new System.Drawing.Point(632, 34);
            this.lbKoltukTuru.Name = "lbKoltukTuru";
            this.lbKoltukTuru.Size = new System.Drawing.Size(81, 17);
            this.lbKoltukTuru.TabIndex = 36;
            this.lbKoltukTuru.Text = "Koltuk Türü";
            // 
            // ucSefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbKoltukTuru);
            this.Controls.Add(this.lbSeferID);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.lbFiyat);
            this.Controls.Add(this.lbKalanKoltuk);
            this.Controls.Add(this.lbHareket);
            this.Controls.Add(this.lbVarisTerminal);
            this.Controls.Add(this.lbKalkisSaat);
            this.Controls.Add(this.lbKalkisTerminal);
            this.Name = "ucSefer";
            this.Size = new System.Drawing.Size(1060, 77);
            this.Load += new System.EventHandler(this.ucSefer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbKalanKoltuk;
        private System.Windows.Forms.Label lbHareket;
        private System.Windows.Forms.Label lbVarisTerminal;
        private System.Windows.Forms.Label lbKalkisSaat;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label lbSeferID;
        private System.Windows.Forms.Label lbKoltukTuru;
        public System.Windows.Forms.Label lbKalkisTerminal;
    }
}
