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
            this.label5 = new System.Windows.Forms.Label();
            this.lbVarisTerminal = new System.Windows.Forms.Label();
            this.lbKalkisSaat = new System.Windows.Forms.Label();
            this.lbKalkisTerminal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Location = new System.Drawing.Point(806, 53);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(38, 17);
            this.lbFiyat.TabIndex = 33;
            this.lbFiyat.Text = "Fiyat";
            // 
            // lbKalanKoltuk
            // 
            this.lbKalanKoltuk.AutoSize = true;
            this.lbKalanKoltuk.Location = new System.Drawing.Point(564, 53);
            this.lbKalanKoltuk.Name = "lbKalanKoltuk";
            this.lbKalanKoltuk.Size = new System.Drawing.Size(87, 17);
            this.lbKalanKoltuk.TabIndex = 32;
            this.lbKalanKoltuk.Text = "Kalan Koltuk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Varış Saat";
            // 
            // lbVarisTerminal
            // 
            this.lbVarisTerminal.AutoSize = true;
            this.lbVarisTerminal.Location = new System.Drawing.Point(328, 35);
            this.lbVarisTerminal.Name = "lbVarisTerminal";
            this.lbVarisTerminal.Size = new System.Drawing.Size(99, 17);
            this.lbVarisTerminal.TabIndex = 30;
            this.lbVarisTerminal.Text = "Varış Terminal";
            // 
            // lbKalkisSaat
            // 
            this.lbKalkisSaat.AutoSize = true;
            this.lbKalkisSaat.Location = new System.Drawing.Point(71, 66);
            this.lbKalkisSaat.Name = "lbKalkisSaat";
            this.lbKalkisSaat.Size = new System.Drawing.Size(78, 17);
            this.lbKalkisSaat.TabIndex = 29;
            this.lbKalkisSaat.Text = "Kalkış Saat";
            // 
            // lbKalkisTerminal
            // 
            this.lbKalkisTerminal.AutoSize = true;
            this.lbKalkisTerminal.Location = new System.Drawing.Point(71, 35);
            this.lbKalkisTerminal.Name = "lbKalkisTerminal";
            this.lbKalkisTerminal.Size = new System.Drawing.Size(104, 17);
            this.lbKalkisTerminal.TabIndex = 28;
            this.lbKalkisTerminal.Text = "Kalkış Terminal";
            // 
            // ucSefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbFiyat);
            this.Controls.Add(this.lbKalanKoltuk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbVarisTerminal);
            this.Controls.Add(this.lbKalkisSaat);
            this.Controls.Add(this.lbKalkisTerminal);
            this.Name = "ucSefer";
            this.Size = new System.Drawing.Size(960, 115);
            this.Load += new System.EventHandler(this.ucSefer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbKalanKoltuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbVarisTerminal;
        private System.Windows.Forms.Label lbKalkisSaat;
        private System.Windows.Forms.Label lbKalkisTerminal;
    }
}
