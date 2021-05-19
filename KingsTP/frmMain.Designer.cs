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
            this.lbKalanKoltuk = new System.Windows.Forms.Label();
            this.grpGiris.SuspendLayout();
            this.pnlBilgiler.SuspendLayout();
            this.pnlSeferUst.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTekYon
            // 
            this.rbTekYon.AutoSize = true;
            this.rbTekYon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTekYon.Location = new System.Drawing.Point(72, 37);
            this.rbTekYon.Name = "rbTekYon";
            this.rbTekYon.Size = new System.Drawing.Size(109, 27);
            this.rbTekYon.TabIndex = 0;
            this.rbTekYon.TabStop = true;
            this.rbTekYon.Text = "Tek Yön";
            this.rbTekYon.UseVisualStyleBackColor = true;
            this.rbTekYon.CheckedChanged += new System.EventHandler(this.rbTekYon_CheckedChanged);
            // 
            // rbGidisDonus
            // 
            this.rbGidisDonus.AutoSize = true;
            this.rbGidisDonus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGidisDonus.Location = new System.Drawing.Point(200, 37);
            this.rbGidisDonus.Name = "rbGidisDonus";
            this.rbGidisDonus.Size = new System.Drawing.Size(148, 27);
            this.rbGidisDonus.TabIndex = 1;
            this.rbGidisDonus.TabStop = true;
            this.rbGidisDonus.Text = "Gidis Donus";
            this.rbGidisDonus.UseVisualStyleBackColor = true;
            this.rbGidisDonus.CheckedChanged += new System.EventHandler(this.rbGidisDonus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereden";
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.DisplayMember = "TerminalAdi";
            this.cmbKalkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Items.AddRange(new object[] {
            "Seçiniz",
            "1+1",
            "2+1",
            "3+1"});
            this.cmbKalkis.Location = new System.Drawing.Point(205, 77);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(176, 30);
            this.cmbKalkis.TabIndex = 10;
            this.cmbKalkis.ValueMember = "ID";
            // 
            // cmbVaris
            // 
            this.cmbVaris.DisplayMember = "TerminalAdi";
            this.cmbVaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            "Seçiniz",
            "1+1",
            "2+1",
            "3+1"});
            this.cmbVaris.Location = new System.Drawing.Point(205, 116);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(176, 30);
            this.cmbVaris.TabIndex = 12;
            this.cmbVaris.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nereye";
            // 
            // dtGidisTarih
            // 
            this.dtGidisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtGidisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGidisTarih.Location = new System.Drawing.Point(205, 152);
            this.dtGidisTarih.Name = "dtGidisTarih";
            this.dtGidisTarih.Size = new System.Drawing.Size(176, 28);
            this.dtGidisTarih.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gidis Tarihi";
            // 
            // lbDonus
            // 
            this.lbDonus.AutoSize = true;
            this.lbDonus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonus.ForeColor = System.Drawing.Color.Black;
            this.lbDonus.Location = new System.Drawing.Point(38, 185);
            this.lbDonus.Name = "lbDonus";
            this.lbDonus.Size = new System.Drawing.Size(153, 27);
            this.lbDonus.TabIndex = 19;
            this.lbDonus.Text = "Dönüs Tarihi";
            // 
            // dtDonusTarih
            // 
            this.dtDonusTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtDonusTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDonusTarih.Location = new System.Drawing.Point(205, 186);
            this.dtDonusTarih.Name = "dtDonusTarih";
            this.dtDonusTarih.Size = new System.Drawing.Size(176, 28);
            this.dtDonusTarih.TabIndex = 18;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(42, 219);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(339, 40);
            this.btnListele.TabIndex = 20;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbFiyat.Location = new System.Drawing.Point(884, 7);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(49, 24);
            this.lbFiyat.TabIndex = 27;
            this.lbFiyat.Text = "Fiyat";
            // 
            // lbVaris
            // 
            this.lbVaris.AutoSize = true;
            this.lbVaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbVaris.Location = new System.Drawing.Point(405, 7);
            this.lbVaris.Name = "lbVaris";
            this.lbVaris.Size = new System.Drawing.Size(52, 24);
            this.lbVaris.TabIndex = 24;
            this.lbVaris.Text = "Varış";
            // 
            // lbKalkis
            // 
            this.lbKalkis.AutoSize = true;
            this.lbKalkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKalkis.Location = new System.Drawing.Point(98, 7);
            this.lbKalkis.Name = "lbKalkis";
            this.lbKalkis.Size = new System.Drawing.Size(58, 24);
            this.lbKalkis.TabIndex = 22;
            this.lbKalkis.Text = "Kalkış";
            // 
            // pnlSeferler
            // 
            this.pnlSeferler.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeferler.Location = new System.Drawing.Point(363, 346);
            this.pnlSeferler.Name = "pnlSeferler";
            this.pnlSeferler.Size = new System.Drawing.Size(1184, 203);
            this.pnlSeferler.TabIndex = 28;
            // 
            // grpGiris
            // 
            this.grpGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGiris.BackColor = System.Drawing.Color.Transparent;
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
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(29, 50);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 39);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(129, 50);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 39);
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
            this.pnlBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.pnlBilgiler.Controls.Add(this.lbAdSoyad);
            this.pnlBilgiler.Controls.Add(this.lbGecmis);
            this.pnlBilgiler.Location = new System.Drawing.Point(12, 12);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(296, 100);
            this.pnlBilgiler.TabIndex = 32;
            // 
            // pnlSeferUst
            // 
            this.pnlSeferUst.BackColor = System.Drawing.Color.White;
            this.pnlSeferUst.Controls.Add(this.lbFiyat);
            this.pnlSeferUst.Controls.Add(this.lbKalkis);
            this.pnlSeferUst.Controls.Add(this.lbVaris);
            this.pnlSeferUst.Controls.Add(this.lbKalanKoltuk);
            this.pnlSeferUst.Location = new System.Drawing.Point(363, 297);
            this.pnlSeferUst.Name = "pnlSeferUst";
            this.pnlSeferUst.Size = new System.Drawing.Size(1184, 34);
            this.pnlSeferUst.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(837, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 279);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Bilgileri";
            // 
            // lbKalanKoltuk
            // 
            this.lbKalanKoltuk.AutoSize = true;
            this.lbKalanKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKalanKoltuk.Location = new System.Drawing.Point(579, 7);
            this.lbKalanKoltuk.Name = "lbKalanKoltuk";
            this.lbKalanKoltuk.Size = new System.Drawing.Size(113, 24);
            this.lbKalanKoltuk.TabIndex = 26;
            this.lbKalanKoltuk.Text = "Kalan Koltuk";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KingsTP.Properties.Resources.oto;
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
        private System.Windows.Forms.Label lbKalanKoltuk;
    }
}