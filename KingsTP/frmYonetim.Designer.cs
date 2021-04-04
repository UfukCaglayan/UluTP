namespace KingsTP
{
    partial class frmYonetim
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
            this.msIslemler = new System.Windows.Forms.MenuStrip();
            this.tsmOtobusIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTerminalIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeferIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.msIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIslemler
            // 
            this.msIslemler.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOtobusIslemleri,
            this.tsmTerminalIslemleri,
            this.tsmSeferIslemleri,
            this.tsmCikis});
            this.msIslemler.Location = new System.Drawing.Point(0, 0);
            this.msIslemler.Name = "msIslemler";
            this.msIslemler.Size = new System.Drawing.Size(1902, 28);
            this.msIslemler.TabIndex = 3;
            this.msIslemler.Text = "menuStrip1";
            // 
            // tsmOtobusIslemleri
            // 
            this.tsmOtobusIslemleri.Name = "tsmOtobusIslemleri";
            this.tsmOtobusIslemleri.Size = new System.Drawing.Size(131, 24);
            this.tsmOtobusIslemleri.Text = "Otobüs İşlemleri";
            this.tsmOtobusIslemleri.Click += new System.EventHandler(this.tsmOtobusIslemleri_Click);
            // 
            // tsmTerminalIslemleri
            // 
            this.tsmTerminalIslemleri.Name = "tsmTerminalIslemleri";
            this.tsmTerminalIslemleri.Size = new System.Drawing.Size(140, 24);
            this.tsmTerminalIslemleri.Text = "Terminal İşlemleri";
            this.tsmTerminalIslemleri.Click += new System.EventHandler(this.tsmTerminalIslemleri_Click);
            // 
            // tsmSeferIslemleri
            // 
            this.tsmSeferIslemleri.Name = "tsmSeferIslemleri";
            this.tsmSeferIslemleri.Size = new System.Drawing.Size(117, 24);
            this.tsmSeferIslemleri.Text = "Sefer İşlemleri";
            this.tsmSeferIslemleri.Click += new System.EventHandler(this.tsmSeferIslemleri_Click);
            // 
            // tsmCikis
            // 
            this.tsmCikis.Name = "tsmCikis";
            this.tsmCikis.Size = new System.Drawing.Size(53, 24);
            this.tsmCikis.Text = "Çıkış";
            // 
            // frmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.msIslemler);
            this.IsMdiContainer = true;
            this.Name = "frmYonetim";
            this.Text = "Yönetim Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msIslemler.ResumeLayout(false);
            this.msIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIslemler;
        private System.Windows.Forms.ToolStripMenuItem tsmOtobusIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmTerminalIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmSeferIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmCikis;
    }
}