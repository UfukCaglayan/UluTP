namespace KingsTP
{
    partial class frmSatis
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
            this.rbTekYon = new System.Windows.Forms.RadioButton();
            this.rbGidisDonus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbKalanKoltuk = new System.Windows.Forms.Label();
            this.lbVaris = new System.Windows.Forms.Label();
            this.lbKalkis = new System.Windows.Forms.Label();
            this.pnlSeferler = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rbTekYon
            // 
            this.rbTekYon.AutoSize = true;
            this.rbTekYon.Location = new System.Drawing.Point(491, 39);
            this.rbTekYon.Name = "rbTekYon";
            this.rbTekYon.Size = new System.Drawing.Size(82, 21);
            this.rbTekYon.TabIndex = 0;
            this.rbTekYon.TabStop = true;
            this.rbTekYon.Text = "Tek Yön";
            this.rbTekYon.UseVisualStyleBackColor = true;
            // 
            // rbGidisDonus
            // 
            this.rbGidisDonus.AutoSize = true;
            this.rbGidisDonus.Location = new System.Drawing.Point(612, 39);
            this.rbGidisDonus.Name = "rbGidisDonus";
            this.rbGidisDonus.Size = new System.Drawing.Size(106, 21);
            this.rbGidisDonus.TabIndex = 1;
            this.rbGidisDonus.TabStop = true;
            this.rbGidisDonus.Text = "Gidiş Dönüş";
            this.rbGidisDonus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereden";
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.DisplayMember = "TerminalAdi";
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Items.AddRange(new object[] {
            "Seçiniz",
            "1+1",
            "2+1",
            "3+1"});
            this.cmbKalkis.Location = new System.Drawing.Point(560, 75);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(176, 24);
            this.cmbKalkis.TabIndex = 10;
            this.cmbKalkis.ValueMember = "ID";
            // 
            // cmbVaris
            // 
            this.cmbVaris.DisplayMember = "TerminalAdi";
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            "Seçiniz",
            "1+1",
            "2+1",
            "3+1"});
            this.cmbVaris.Location = new System.Drawing.Point(560, 109);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(176, 24);
            this.cmbVaris.TabIndex = 12;
            this.cmbVaris.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nereye";
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(560, 141);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(176, 22);
            this.dtTarih.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gidiş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dönüş Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(560, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(468, 201);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(268, 23);
            this.btnListele.TabIndex = 20;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Location = new System.Drawing.Point(928, 283);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(38, 17);
            this.lbFiyat.TabIndex = 27;
            this.lbFiyat.Text = "Fiyat";
            // 
            // lbKalanKoltuk
            // 
            this.lbKalanKoltuk.AutoSize = true;
            this.lbKalanKoltuk.Location = new System.Drawing.Point(686, 283);
            this.lbKalanKoltuk.Name = "lbKalanKoltuk";
            this.lbKalanKoltuk.Size = new System.Drawing.Size(87, 17);
            this.lbKalanKoltuk.TabIndex = 26;
            this.lbKalanKoltuk.Text = "Kalan Koltuk";
            // 
            // lbVaris
            // 
            this.lbVaris.AutoSize = true;
            this.lbVaris.Location = new System.Drawing.Point(449, 283);
            this.lbVaris.Name = "lbVaris";
            this.lbVaris.Size = new System.Drawing.Size(40, 17);
            this.lbVaris.TabIndex = 24;
            this.lbVaris.Text = "Varış";
            // 
            // lbKalkis
            // 
            this.lbKalkis.AutoSize = true;
            this.lbKalkis.Location = new System.Drawing.Point(191, 283);
            this.lbKalkis.Name = "lbKalkis";
            this.lbKalkis.Size = new System.Drawing.Size(45, 17);
            this.lbKalkis.TabIndex = 22;
            this.lbKalkis.Text = "Kalkış";
            // 
            // pnlSeferler
            // 
            this.pnlSeferler.Location = new System.Drawing.Point(133, 339);
            this.pnlSeferler.Name = "pnlSeferler";
            this.pnlSeferler.Size = new System.Drawing.Size(1184, 674);
            this.pnlSeferler.TabIndex = 28;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlSeferler);
            this.Controls.Add(this.lbFiyat);
            this.Controls.Add(this.lbKalanKoltuk);
            this.Controls.Add(this.lbVaris);
            this.Controls.Add(this.lbKalkis);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cmbVaris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKalkis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbGidisDonus);
            this.Controls.Add(this.rbTekYon);
            this.Name = "frmSatis";
            this.Text = "Satış İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTekYon;
        private System.Windows.Forms.RadioButton rbGidisDonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKalkis;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbKalanKoltuk;
        private System.Windows.Forms.Label lbVaris;
        private System.Windows.Forms.Label lbKalkis;
        private System.Windows.Forms.Panel pnlSeferler;
    }
}