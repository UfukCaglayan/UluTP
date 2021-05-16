namespace KingsTP
{
    partial class frmMain
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
            this.dtGidisTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDonus = new System.Windows.Forms.Label();
            this.dtDonusTarih = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbKalanKoltuk = new System.Windows.Forms.Label();
            this.lbVaris = new System.Windows.Forms.Label();
            this.lbKalkis = new System.Windows.Forms.Label();
            this.pnlSeferler = new System.Windows.Forms.Panel();
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lbAdSoyad = new System.Windows.Forms.Label();
            this.lbGecmis = new System.Windows.Forms.Label();
            this.pnlBilgiler = new System.Windows.Forms.Panel();
            this.pnlSeferUst = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpGiris.SuspendLayout();
            this.pnlBilgiler.SuspendLayout();
            this.pnlSeferUst.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTekYon
            // 
            this.rbTekYon.AutoSize = true;
            this.rbTekYon.Location = new System.Drawing.Point(64, 36);
            this.rbTekYon.Name = "rbTekYon";
            this.rbTekYon.Size = new System.Drawing.Size(82, 21);
            this.rbTekYon.TabIndex = 0;
            this.rbTekYon.TabStop = true;
            this.rbTekYon.Text = "Tek Yön";
            this.rbTekYon.UseVisualStyleBackColor = true;
            this.rbTekYon.CheckedChanged += new System.EventHandler(this.rbTekYon_CheckedChanged);
            // 
            // rbGidisDonus
            // 
            this.rbGidisDonus.AutoSize = true;
            this.rbGidisDonus.Location = new System.Drawing.Point(185, 36);
            this.rbGidisDonus.Name = "rbGidisDonus";
            this.rbGidisDonus.Size = new System.Drawing.Size(106, 21);
            this.rbGidisDonus.TabIndex = 1;
            this.rbGidisDonus.TabStop = true;
            this.rbGidisDonus.Text = "Gidiş Dönüş";
            this.rbGidisDonus.UseVisualStyleBackColor = true;
            this.rbGidisDonus.CheckedChanged += new System.EventHandler(this.rbGidisDonus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 75);
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
            this.cmbKalkis.Location = new System.Drawing.Point(133, 72);
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
            this.cmbVaris.Location = new System.Drawing.Point(133, 106);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(176, 24);
            this.cmbVaris.TabIndex = 12;
            this.cmbVaris.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nereye";
            // 
            // dtGidisTarih
            // 
            this.dtGidisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGidisTarih.Location = new System.Drawing.Point(133, 138);
            this.dtGidisTarih.Name = "dtGidisTarih";
            this.dtGidisTarih.Size = new System.Drawing.Size(176, 22);
            this.dtGidisTarih.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gidiş Tarihi";
            // 
            // lbDonus
            // 
            this.lbDonus.AutoSize = true;
            this.lbDonus.Location = new System.Drawing.Point(38, 173);
            this.lbDonus.Name = "lbDonus";
            this.lbDonus.Size = new System.Drawing.Size(89, 17);
            this.lbDonus.TabIndex = 19;
            this.lbDonus.Text = "Dönüş Tarihi";
            // 
            // dtDonusTarih
            // 
            this.dtDonusTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDonusTarih.Location = new System.Drawing.Point(133, 168);
            this.dtDonusTarih.Name = "dtDonusTarih";
            this.dtDonusTarih.Size = new System.Drawing.Size(176, 22);
            this.dtDonusTarih.TabIndex = 18;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(41, 198);
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
            this.lbFiyat.Location = new System.Drawing.Point(799, 10);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(38, 17);
            this.lbFiyat.TabIndex = 27;
            this.lbFiyat.Text = "Fiyat";
            // 
            // lbKalanKoltuk
            // 
            this.lbKalanKoltuk.AutoSize = true;
            this.lbKalanKoltuk.Location = new System.Drawing.Point(502, 10);
            this.lbKalanKoltuk.Name = "lbKalanKoltuk";
            this.lbKalanKoltuk.Size = new System.Drawing.Size(87, 17);
            this.lbKalanKoltuk.TabIndex = 26;
            this.lbKalanKoltuk.Text = "Kalan Koltuk";
            // 
            // lbVaris
            // 
            this.lbVaris.AutoSize = true;
            this.lbVaris.Location = new System.Drawing.Point(320, 10);
            this.lbVaris.Name = "lbVaris";
            this.lbVaris.Size = new System.Drawing.Size(40, 17);
            this.lbVaris.TabIndex = 24;
            this.lbVaris.Text = "Varış";
            // 
            // lbKalkis
            // 
            this.lbKalkis.AutoSize = true;
            this.lbKalkis.Location = new System.Drawing.Point(62, 10);
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
            // grpGiris
            // 
            this.grpGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGiris.Controls.Add(this.btnGiris);
            this.grpGiris.Controls.Add(this.btnKayit);
            this.grpGiris.Location = new System.Drawing.Point(1676, -1);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(225, 141);
            this.grpGiris.TabIndex = 29;
            this.grpGiris.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(78, 38);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(78, 79);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // lbAdSoyad
            // 
            this.lbAdSoyad.AutoSize = true;
            this.lbAdSoyad.Location = new System.Drawing.Point(22, 25);
            this.lbAdSoyad.Name = "lbAdSoyad";
            this.lbAdSoyad.Size = new System.Drawing.Size(0, 17);
            this.lbAdSoyad.TabIndex = 30;
            // 
            // lbGecmis
            // 
            this.lbGecmis.AutoSize = true;
            this.lbGecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbGecmis.ForeColor = System.Drawing.Color.Blue;
            this.lbGecmis.Location = new System.Drawing.Point(22, 59);
            this.lbGecmis.Name = "lbGecmis";
            this.lbGecmis.Size = new System.Drawing.Size(0, 17);
            this.lbGecmis.TabIndex = 31;
            this.lbGecmis.Click += new System.EventHandler(this.lbGecmis_Click);
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.Controls.Add(this.lbAdSoyad);
            this.pnlBilgiler.Controls.Add(this.lbGecmis);
            this.pnlBilgiler.Location = new System.Drawing.Point(12, 12);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(296, 100);
            this.pnlBilgiler.TabIndex = 32;
            // 
            // pnlSeferUst
            // 
            this.pnlSeferUst.Controls.Add(this.lbFiyat);
            this.pnlSeferUst.Controls.Add(this.lbKalkis);
            this.pnlSeferUst.Controls.Add(this.lbVaris);
            this.pnlSeferUst.Controls.Add(this.lbKalanKoltuk);
            this.pnlSeferUst.Location = new System.Drawing.Point(133, 290);
            this.pnlSeferUst.Name = "pnlSeferUst";
            this.pnlSeferUst.Size = new System.Drawing.Size(1184, 34);
            this.pnlSeferUst.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTekYon);
            this.groupBox1.Controls.Add(this.rbGidisDonus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbKalkis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.cmbVaris);
            this.groupBox1.Controls.Add(this.lbDonus);
            this.groupBox1.Controls.Add(this.dtGidisTarih);
            this.groupBox1.Controls.Add(this.dtDonusTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(607, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 251);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Bilgileri";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlSeferUst);
            this.Controls.Add(this.pnlBilgiler);
            this.Controls.Add(this.grpGiris);
            this.Controls.Add(this.pnlSeferler);
            this.Name = "frmMain";
            this.Text = "ANA SAYFA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.grpGiris.ResumeLayout(false);
            this.pnlBilgiler.ResumeLayout(false);
            this.pnlBilgiler.PerformLayout();
            this.pnlSeferUst.ResumeLayout(false);
            this.pnlSeferUst.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTekYon;
        private System.Windows.Forms.RadioButton rbGidisDonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKalkis;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtGidisTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDonus;
        private System.Windows.Forms.DateTimePicker dtDonusTarih;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbKalanKoltuk;
        private System.Windows.Forms.Label lbVaris;
        private System.Windows.Forms.Label lbKalkis;
        private System.Windows.Forms.Panel pnlSeferler;
        private System.Windows.Forms.GroupBox grpGiris;
        public System.Windows.Forms.Label lbAdSoyad;
        public System.Windows.Forms.Label lbGecmis;
        public System.Windows.Forms.Button btnGiris;
        public System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.Panel pnlSeferUst;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}