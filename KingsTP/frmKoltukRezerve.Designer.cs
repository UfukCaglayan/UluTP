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
            this.pnlRezerveUst = new System.Windows.Forms.Panel();
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbKalkis = new System.Windows.Forms.Label();
            this.lbVaris = new System.Windows.Forms.Label();
            this.lbKalanKoltuk = new System.Windows.Forms.Label();
            this.btnDonus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCinsiyet.SuspendLayout();
            this.pnlRezerveUst.SuspendLayout();
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
            this.pnlBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.pnlBilgiler.Location = new System.Drawing.Point(548, 482);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(810, 554);
            this.pnlBilgiler.TabIndex = 2;
            // 
            // btnRezerve
            // 
            this.btnRezerve.Location = new System.Drawing.Point(445, 396);
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
            this.btnOdeme.Size = new System.Drawing.Size(169, 35);
            this.btnOdeme.TabIndex = 4;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // pnlRezerveUst
            // 
            this.pnlRezerveUst.BackColor = System.Drawing.Color.White;
            this.pnlRezerveUst.Controls.Add(this.lbFiyat);
            this.pnlRezerveUst.Controls.Add(this.lbKalkis);
            this.pnlRezerveUst.Controls.Add(this.lbVaris);
            this.pnlRezerveUst.Controls.Add(this.lbKalanKoltuk);
            this.pnlRezerveUst.Location = new System.Drawing.Point(548, 438);
            this.pnlRezerveUst.Name = "pnlRezerveUst";
            this.pnlRezerveUst.Size = new System.Drawing.Size(810, 34);
            this.pnlRezerveUst.TabIndex = 34;
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbFiyat.Location = new System.Drawing.Point(620, 7);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(63, 24);
            this.lbFiyat.TabIndex = 27;
            this.lbFiyat.Text = "Soyad";
            // 
            // lbKalkis
            // 
            this.lbKalkis.AutoSize = true;
            this.lbKalkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKalkis.Location = new System.Drawing.Point(14, 7);
            this.lbKalkis.Name = "lbKalkis";
            this.lbKalkis.Size = new System.Drawing.Size(91, 24);
            this.lbKalkis.TabIndex = 22;
            this.lbKalkis.Text = "Koltuk No";
            // 
            // lbVaris
            // 
            this.lbVaris.AutoSize = true;
            this.lbVaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbVaris.Location = new System.Drawing.Point(184, 7);
            this.lbVaris.Name = "lbVaris";
            this.lbVaris.Size = new System.Drawing.Size(119, 24);
            this.lbVaris.TabIndex = 24;
            this.lbVaris.Text = "TC Kimlik No";
            // 
            // lbKalanKoltuk
            // 
            this.lbKalanKoltuk.AutoSize = true;
            this.lbKalanKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKalanKoltuk.Location = new System.Drawing.Point(409, 7);
            this.lbKalanKoltuk.Name = "lbKalanKoltuk";
            this.lbKalanKoltuk.Size = new System.Drawing.Size(34, 24);
            this.lbKalanKoltuk.TabIndex = 26;
            this.lbKalanKoltuk.Text = "Ad";
            // 
            // btnDonus
            // 
            this.btnDonus.Location = new System.Drawing.Point(1573, 445);
            this.btnDonus.Name = "btnDonus";
            this.btnDonus.Size = new System.Drawing.Size(169, 35);
            this.btnDonus.TabIndex = 35;
            this.btnDonus.Text = "Dönüş Yolculuğunu Seç";
            this.btnDonus.UseVisualStyleBackColor = true;
            this.btnDonus.Click += new System.EventHandler(this.btnDonus_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(214, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 304);
            this.panel1.TabIndex = 36;
            // 
            // frmKoltukRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::UluTP.Properties.Resources.bright_road;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDonus);
            this.Controls.Add(this.pnlRezerveUst);
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
            this.pnlRezerveUst.ResumeLayout(false);
            this.pnlRezerveUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCinsiyet;
        private System.Windows.Forms.Button btnKadin;
        private System.Windows.Forms.Button btnErkek;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.Button btnRezerve;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Panel pnlRezerveUst;
        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbKalkis;
        private System.Windows.Forms.Label lbVaris;
        private System.Windows.Forms.Label lbKalanKoltuk;
        private System.Windows.Forms.Button btnDonus;
        private System.Windows.Forms.Panel panel1;
    }
}