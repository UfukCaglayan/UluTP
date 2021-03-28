namespace KingsTP
{
    partial class frmSeferIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.nupSaat = new System.Windows.Forms.NumericUpDown();
            this.nupDakika = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtDakika = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(455, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 138);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt İşlemleri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(18, 99);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(251, 23);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(18, 60);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(251, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(18, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(251, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDakika);
            this.groupBox1.Controls.Add(this.txtSaat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nupDakika);
            this.groupBox1.Controls.Add(this.nupSaat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtTarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVaris);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKalkis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbOtobus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 191);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otobüs";
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.DisplayMember = "Plaka";
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Items.AddRange(new object[] {
            "Seçiniz",
            "1+1",
            "2+1",
            "3+1"});
            this.cmbOtobus.Location = new System.Drawing.Point(149, 20);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(187, 24);
            this.cmbOtobus.TabIndex = 9;
            this.cmbOtobus.ValueMember = "ID";
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.DisplayMember = "Plaka";
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Items.AddRange(new object[] {
            "Seçiniz",
            "1+1",
            "2+1",
            "3+1"});
            this.cmbKalkis.Location = new System.Drawing.Point(149, 50);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(187, 24);
            this.cmbKalkis.TabIndex = 11;
            this.cmbKalkis.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kalkış Terminali";
            // 
            // cmbVaris
            // 
            this.cmbVaris.DisplayMember = "Plaka";
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            "Seçiniz",
            "1+1",
            "2+1",
            "3+1"});
            this.cmbVaris.Location = new System.Drawing.Point(149, 80);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(187, 24);
            this.cmbVaris.TabIndex = 13;
            this.cmbVaris.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Varış Terminali";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(149, 116);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(187, 22);
            this.dtTarih.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saat";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // nupSaat
            // 
            this.nupSaat.Location = new System.Drawing.Point(209, 153);
            this.nupSaat.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nupSaat.Name = "nupSaat";
            this.nupSaat.Size = new System.Drawing.Size(20, 22);
            this.nupSaat.TabIndex = 18;
            this.nupSaat.ValueChanged += new System.EventHandler(this.nupSaat_ValueChanged);
            // 
            // nupDakika
            // 
            this.nupDakika.Location = new System.Drawing.Point(314, 153);
            this.nupDakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupDakika.Name = "nupDakika";
            this.nupDakika.Size = new System.Drawing.Size(22, 22);
            this.nupDakika.TabIndex = 19;
            this.nupDakika.ValueChanged += new System.EventHandler(this.nupDakika_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = ":";
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.AllowDrop = true;
            this.dgvSeferler.AllowUserToAddRows = false;
            this.dgvSeferler.AllowUserToDeleteRows = false;
            this.dgvSeferler.AllowUserToOrderColumns = true;
            this.dgvSeferler.AllowUserToResizeColumns = false;
            this.dgvSeferler.AllowUserToResizeRows = false;
            this.dgvSeferler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeferler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeferler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSeferler.Location = new System.Drawing.Point(31, 283);
            this.dgvSeferler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.RowHeadersWidth = 51;
            this.dgvSeferler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeferler.Size = new System.Drawing.Size(710, 493);
            this.dgvSeferler.TabIndex = 1005;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(455, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 84);
            this.groupBox3.TabIndex = 1006;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sefer";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(147, 153);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(61, 22);
            this.txtSaat.TabIndex = 1007;
            this.txtSaat.Text = "00";
            // 
            // txtDakika
            // 
            this.txtDakika.Location = new System.Drawing.Point(254, 153);
            this.txtDakika.Name = "txtDakika";
            this.txtDakika.Size = new System.Drawing.Size(61, 22);
            this.txtDakika.TabIndex = 1008;
            this.txtDakika.Text = "00";
            // 
            // frmSeferIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 789);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvSeferler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSeferIslemleri";
            this.Text = "Sefer İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSeferIslemleri_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKalkis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupDakika;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupSaat;
        private System.Windows.Forms.TextBox txtDakika;
        private System.Windows.Forms.TextBox txtSaat;
    }
}