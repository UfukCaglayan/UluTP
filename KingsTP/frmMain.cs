using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsTP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {

            InitializeComponent();
        }

        int seferID;
        char gidisDonus;
        int koltukNo = 0;
        SingleLinkedList GidisKoltuklar;
        SingleLinkedList DonusKoltuklar;
        public void KoltukDoldur(int sefer, int h)
        {
            if (rbGidisDonus.Checked)
            {
                if (gidisDonus == 'g')
                {
                    if(GidisKoltuklar.head != null)
                        GidisKoltuklar = new SingleLinkedList();
                }
                else
                    DonusKoltuklar = new SingleLinkedList();
            }
            else
                GidisKoltuklar = new SingleLinkedList();

            pnlOtobus.Controls.Clear();
            int sag = 0, sol = 0;
            seferID = sefer;
            KoltukRezerve koltukRezerve = new KoltukRezerve();
            int koltukTuru = koltukRezerve.KoltukTuruGetir(seferID);
            if (koltukTuru == 1)
            {
                sag = 1;
                sol = 1;
            }
            else if (koltukTuru == 2)
            {
                sag = 2;
                sol = 1;
            }
            else if (koltukTuru == 3)
            {
                sag = 2;
                sol = 2;
            }
            int sagSon = 0;
            for (int i = 0; i < sag; i++)
            {
                for (int k = 1; k <= 20; k++)
                {
                    Button btnSag = new Button();
                    btnSag.Width = 60;
                    btnSag.Height = 50;
                    btnSag.Location = new Point(((k - 1) * 65), (i * 55));
                    string koltukText = "";
                    if (sag == 2)
                    {
                        if (i == 0)
                        {
                            koltukText = (k * 2 - 1).ToString();
                        }
                        else if (i == 1)
                        {
                            koltukText = (k * 2).ToString();
                        }
                    }
                    else if (sag == 1)
                    {
                        koltukText = k.ToString();
                    }
                    btnSag.Click += btnKoltuk_Click;
                    btnSag.Text = koltukText;
                    btnSag.Name = "btnKoltuk" + koltukText;
                    btnSag.Image = UluTP.Properties.Resources.boskol;
                    btnSag.BackgroundImageLayout = ImageLayout.Stretch;
                    pnlOtobus.Controls.Add(btnSag);
                }
            }
            sagSon = sag * 20;
            for (int i = 0; i < sol; i++)
            {
                for (int k = 1; k <= 20; k++)
                {
                    Button btnSol = new Button();
                    btnSol.Width = 60;
                    btnSol.Height = 50;
                    btnSol.Location = new Point(1 + ((k - 1) * 65), 140 + (i * 55));

                    string koltukText = "";
                    if (sol == 2)
                    {
                        if (i == 0)
                        {
                            koltukText = (k * 2 - 1 + sagSon).ToString();
                        }
                        else if (i == 1)
                        {
                            koltukText = (k * 2 + sagSon).ToString();
                        }
                    }
                    else if (sol == 1)
                    {
                        koltukText = (sagSon + k).ToString();
                    }
                    btnSol.Click += btnKoltuk_Click;
                    btnSol.Text = koltukText;
                    btnSol.Name = "btnKoltuk" + koltukText;
                    btnSol.Image = UluTP.Properties.Resources.boskol;
                    btnSol.BackgroundImageLayout = ImageLayout.Stretch;
                    pnlOtobus.Controls.Add(btnSol);
                }
                pnlOtobusUst.Visible = true;
                UserControl ucs = this.Controls.Find("ucs" + h, true).FirstOrDefault() as UserControl;
                int konumY = ucs.Location.Y + pnlOtobusUst.Height + 15;
                if(konumY < this.Height - pnlOtobusUst.Height - 20)
                    pnlOtobusUst.Location = new Point(pnlOtobusUst.Location.X, konumY);
                else
                    pnlOtobusUst.Location = new Point(pnlOtobusUst.Location.X, ucs.Location.Y - 60);
            }


            DataTable dt = koltukRezerve.KoltukDoldur(seferID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string koltuk = dt.Rows[i][0].ToString();
                string cinsiyet = dt.Rows[i][1].ToString();
                Button btnKoltuk = this.Controls.Find("btnKoltuk" + koltuk, true).FirstOrDefault() as Button;
                if (cinsiyet == "E")
                    btnKoltuk.Image = UluTP.Properties.Resources.erkek;
                else
                    btnKoltuk.Image = UluTP.Properties.Resources.kadin;

                btnKoltuk.Enabled = false;
            }
        } 


        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            koltukNo = Convert.ToInt32(btn.Text);
            pnlCinsiyet.Location = new Point(pnlOtobusUst.Location.X + btn.Location.X + btn.Width / 2, pnlOtobusUst.Location.Y + btn.Location.Y - 62);
            pnlCinsiyet.Visible = true;
        }
       

        public void Giris(string adSoyad)
        {
            lbAdSoyad.Visible = true;
            lbAdSoyad.Text = " Hoş Geldin\r\n " + adSoyad;
            btnGiris.Text = "Çıkış";
            btnKayit.Text = "Rezerve Geçmişi";
            btnKayit.Location = new Point(10, 50);
            btnGiris.Location = new Point(10, 90);
            grpGiris.Height = 130;
            btnKayit.Width = 190;
            btnGiris.Width = 190;

        }
        private void frmSatis_Load(object sender, EventArgs e)
        {
          
            gidisDonus = 'g';
            SeferIslem seferIslem = new SeferIslem();
            DataTable dtKalkis = seferIslem.TerminalDoldur();
            DataTable dtVaris = seferIslem.TerminalDoldur();
            rbTekYon.Checked = true;
            cmbKalkis.DataSource = dtKalkis;
            cmbVaris.DataSource = dtVaris;
            cmbKalkis.Text = "Seçiniz";
            cmbVaris.Text = "Seçiniz";

            dtDonusTarih.Enabled = false;
            pnlSeferUst.Visible = false;
            dtGidisTarih.MinDate = DateTime.Now;
            dtDonusTarih.MinDate = DateTime.Now;
           
            grpGiris.Width = 225;
            grpGiris.Location = new Point(this.Width - 225, 0);
            lbAdSoyad.Location = new Point(3, lbAdSoyad.Location.Y);
            btnGiris.Location = new Point(30, 45);
            btnKayit.Location = new Point(125, 45);
            btnKayit.Width = 75;
            btnGiris.Width = 75;
            pnlOtobusUst.Visible = false;
            pnlCinsiyet.Visible = false;
            pnlKoltukBilgiler.Visible = false;
           
        }

        
        private void panelDoldur(DataTable dt)
        {
            pnlSeferler.Visible = true;
            pnlSeferUst.Visible = true;
            pnlSeferler.Controls.Clear();
            if (dt.Rows.Count > 0)
            {
                int i = 0;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    ucSefer uc1 = new ucSefer();
                    uc1.Name = "ucs" + i;
                    Label lbKalkisTerminal = uc1.Controls.Find("lbKalkisTerminal", true).FirstOrDefault() as Label;
                    lbKalkisTerminal.Text = dt.Rows[i][0].ToString();
                    Label lbVarisTerminal = uc1.Controls.Find("lbVarisTerminal", true).FirstOrDefault() as Label;
                    lbVarisTerminal.Text = dt.Rows[i][1].ToString();
                    Label lbKalkisSaat = uc1.Controls.Find("lbKalkisSaat", true).FirstOrDefault() as Label;
                    lbKalkisSaat.Text = dt.Rows[i][2].ToString();
                    Label lbHareket = uc1.Controls.Find("lbHareket", true).FirstOrDefault() as Label;
                    lbHareket.Text = dt.Rows[i][3].ToString() + " Saat";
                    Label lbKalanKoltuk = uc1.Controls.Find("lbKalanKoltuk", true).FirstOrDefault() as Label;
                    lbKalanKoltuk.Text = dt.Rows[i][4].ToString();
                    Label lbFiyat = uc1.Controls.Find("lbFiyat", true).FirstOrDefault() as Label;
                    lbFiyat.Text = dt.Rows[i][5].ToString() + " TL";
                    Label lbSeferID = uc1.Controls.Find("lbSeferID", true).FirstOrDefault() as Label;
                    lbSeferID.Text = dt.Rows[i][6].ToString();
                    Label lbKoltukTuru = uc1.Controls.Find("lbKoltukTuru", true).FirstOrDefault() as Label;
                    lbKoltukTuru.Text = dt.Rows[i][7].ToString();
                    uc1.Top = i * 70;

                    pnlSeferler.Controls.Add(uc1);
                }
                pnlSeferler.Height = i * 80;
            }
            else
            {
                pnlSeferUst.Visible = false;
                MessageBox.Show("Sefer bulunamadı", "Sefer İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Listele()
        {
            SeferIslem seferIslem = new SeferIslem();
            string kalkisTarih = "";

            if (gidisDonus == 'g')
            {
                seferIslem.setKalkisID(Convert.ToInt32(cmbKalkis.SelectedValue));
                seferIslem.setVarisID(Convert.ToInt32(cmbVaris.SelectedValue));
                kalkisTarih = dtGidisTarih.Value.ToString("yyyy-MM-dd");
            }
            else
            {

                pnlOtobusUst.Visible = false;
                seferIslem.setKalkisID(Convert.ToInt32(cmbVaris.SelectedValue));
                seferIslem.setVarisID(Convert.ToInt32(cmbKalkis.SelectedValue));
                kalkisTarih = dtDonusTarih.Value.ToString("yyyy-MM-dd");
            }

            seferIslem.setTarih(kalkisTarih);
            DataTable dt = new DataTable();
            dt = seferIslem.SeferGetir();
            panelDoldur(dt);


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (cmbKalkis.Text != "Seçiniz" && cmbVaris.Text != "Seçiniz")
            {

                if (cmbKalkis.SelectedValue.ToString() != cmbVaris.SelectedValue.ToString())
                {

                    pnlSeferler.Controls.Clear();
                    gidisDonus = 'g';
                    pnlOtobusUst.Visible = false;
                    GidisKoltuklar = new SingleLinkedList();
                    DonusKoltuklar = new SingleLinkedList();
                    pnlSeferUst.Location = new Point(pnlSeferler.Location.X, grpSefer.Location.Y + grpSefer.Height + 5);
                    pnlSeferler.Location = new Point(pnlSeferler.Location.X, grpSefer.Location.Y + grpSefer.Height + pnlSeferUst.Height + 15);

                    if (rbGidisDonus.Checked)
                    {
                        if (dtDonusTarih.Value > dtGidisTarih.Value)
                        {
                            lbDonusSefer.Text = "Gidiş Yolculuğu";
                            btnRezerve.Text = "Dönüş Yolculuğu";
                            Listele();
                        }
                        else
                            MessageBox.Show("Dönüş tarihi Gidiş tarihinden ileride olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lbDonusSefer.Visible = false;
                        lbDonusSefer.Text = "";
                        Listele();
                    }
                }
                else
                    MessageBox.Show("Kalkış terminaliyle Varış terminali farklı olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Kalkış veya Varış terminalini seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (btnKayit.Text == "Kayıt")
            {
                frmKayit kayit = new frmKayit();
                kayit.Owner = this;
                kayit.Show();
            }
            else
            {
                frmGecmisRezerve gecmisRezerve = new frmGecmisRezerve();
                gecmisRezerve.Owner = this;
                gecmisRezerve.Show();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (btnGiris.Text == "Giriş")
            {
                frmGiris giris = new frmGiris();
                giris.Owner = this;
                giris.Show();
            }
            else
            {
                btnGiris.Text = "Giriş";
                btnKayit.Text = "Kayıt";
                lbAdSoyad.Text = "";
                lbAdSoyad.Visible = false;
                GirisBilgileri.KullaniciID = -1;
                btnKayit.Visible = true;
                grpGiris.Height = 120;
                btnGiris.Location = new Point(30, 45);
                btnKayit.Location = new Point(125, 45);
                btnKayit.Width = 75;
                btnGiris.Width = 75;
                pnlOtobusUst.Visible = false;
                gidisDonus = 'g';
            }
        }

        private void btnSecim_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char cinsiyet = Convert.ToChar(btn.Text);
            HelperSLL objHelper = new HelperSLL();
            if (rbGidisDonus.Checked)
            {
                if (gidisDonus == 'g')
                {
                    objHelper.DeleteNodebyKey(GidisKoltuklar, koltukNo);
                    objHelper.InsertLast(GidisKoltuklar, seferID, koltukNo, cinsiyet);
                }
                else
                {
                    objHelper.DeleteNodebyKey(DonusKoltuklar, koltukNo);
                    objHelper.InsertLast(DonusKoltuklar, seferID, koltukNo, cinsiyet);
                }
            }
            else
            {
                objHelper.DeleteNodebyKey(GidisKoltuklar, koltukNo);
                objHelper.InsertLast(GidisKoltuklar, seferID, koltukNo, cinsiyet);
            }
            string btnName = "btnKoltuk" + koltukNo;
            Button btnKoltuk = this.Controls.Find(btnName, true).FirstOrDefault() as Button;
            if(btn.Name == "btnErkek")
                btnKoltuk.Image = UluTP.Properties.Resources.erkek;
            else
                btnKoltuk.Image = UluTP.Properties.Resources.kadin;

            btnKoltuk.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCinsiyet.Visible = false;
        }

        private void lbGecmis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGecmisRezerve gecmisRezerve = new frmGecmisRezerve();
            gecmisRezerve.Show();
        }

        private void rbTekYon_CheckedChanged(object sender, EventArgs e)
        {
            dtDonusTarih.Enabled = false;
        }

        private void rbGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            dtDonusTarih.Enabled = true;
        }

       
        int sayac = 0;
     
        private void rezerveDoldur(SingleLinkedList list,int top)
        {
            Node iter = list.head;
            
            while (iter != null)
            {
                ucRezerve uc1 = new ucRezerve();
                uc1.Name = "ucRezerve" + sayac;
                Label lbKoltukNo = uc1.Controls.Find("lbKoltukNo", true).FirstOrDefault() as Label;
                lbKoltukNo.Text = iter.koltuk.ToString();
                uc1.Top = sayac * 55 + top;

                pnlBilgiler.Controls.Add(uc1);

                sayac++;
                iter = iter.next;
               
            }
           
            pnlKoltukBilgiler.Visible = true;
            pnlOtobusUst.Visible = false;
          

        }
        private void Rezerve()
        {
            sayac = 0;
            pnlSeferUst.Visible = false;
            pnlSeferler.Visible = false;
            pnlKoltukBilgiler.Location = new Point(pnlKoltukBilgiler.Location.X, 150);
            if (rbGidisDonus.Checked == false)
            {
                rezerveDoldur(GidisKoltuklar,0);
                pnlKoltukBilgiler.Height = sayac * 55 + btnTamamla.Height + 30;
            }
            else
            {
                Label lblGidis = new Label();
                lblGidis.Top = sayac * 80 + 10;
                lblGidis.Left = 10;
                lblGidis.Text = "Gidiş Yolculuğu";
                pnlBilgiler.Controls.Add(lblGidis);
              
                rezerveDoldur(GidisKoltuklar,30);
             
                Label lblDonus = new Label();
                lblDonus.Left = 10;
                lblDonus.Top = sayac * 55 + 30;
                lblDonus.Text = "Dönüş Yolculuğu";
                pnlBilgiler.Controls.Add(lblDonus);
                rezerveDoldur(DonusKoltuklar,50);
                pnlKoltukBilgiler.Height = (sayac + 1) * 55 + btnTamamla.Height + 30;
               
            }
        }

        
        private void btnRezerve_Click(object sender, EventArgs e)
        {
            if (rbGidisDonus.Checked)
            {
                if (gidisDonus == 'g')
                {
                    if (GidisKoltuklar.head != null)
                    {
                        gidisDonus = 'd';
                        Listele();
                        btnRezerve.Text = "Rezerve Et";
                        lbDonusSefer.Text = "Dönüş Yolculuğu";
                    }
                    else
                        MessageBox.Show("Gidiş yolculuğu için koltuk seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DonusKoltuklar.head != null)
                        Rezerve();
                    else
                        MessageBox.Show("Dönüş yolculuğu için koltuk seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (GidisKoltuklar.head != null)
                    Rezerve();
                else
                    MessageBox.Show("Koltuk seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            pnlOtobusUst.Visible = false;
        }

        int kSayac = 0;

        private void sifirla()
        {
            pnlOtobusUst.Visible = false;
            pnlKoltukBilgiler.Visible = false;
            cmbKalkis.Text = "Seçiniz";
            cmbVaris.Text = "Seçiniz";
        }
        private void RezerveEt(SingleLinkedList list,char gd)
        {
          
            KoltukRezerve koltukRezerve = new KoltukRezerve();
            DataTable dt = new DataTable();
            dt.Columns.Add("SeferID", typeof(int));
            dt.Columns.Add("KoltukID", typeof(int));
            dt.Columns.Add("TCKimlikNo", typeof(string));
            dt.Columns.Add("Ad", typeof(string));
            dt.Columns.Add("Soyad", typeof(string));
            dt.Columns.Add("Cinsiyet", typeof(string));
            dt.Columns.Add("UyeID", typeof(string));

            Node iter = list.head;
            int sID = iter.seferID;
            bool kontrol = true;
            int adet = 0;
            List<string> kimlikNo = new List<string>();
            bool kimlikNoKontrol = true;
            while (iter != null)
            {
                UserControl uc = this.Controls.Find("ucRezerve" + kSayac, true).FirstOrDefault() as UserControl;
                TextBox txTCKimlikNo = uc.Controls.Find("txTCKimlikNo", true).FirstOrDefault() as TextBox;
                if (txTCKimlikNo.Text.Length != 11)
                    kontrol = false;

                if (kimlikNo.Contains(txTCKimlikNo.Text))
                    kimlikNoKontrol = false;

                kimlikNo.Add(txTCKimlikNo.Text);
                TextBox txtAd = uc.Controls.Find("txtAd", true).FirstOrDefault() as TextBox;
                if(txtAd.Text == "")
                    kontrol = false;

                TextBox txtSoyad = uc.Controls.Find("txtSoyad", true).FirstOrDefault() as TextBox;
                if(txtSoyad.Text == "")
                    kontrol = false;

                dt.Rows.Add(sID, iter.koltuk, txTCKimlikNo.Text, txtAd.Text, txtSoyad.Text, iter.cinsiyet, GirisBilgileri.KullaniciID);
                kSayac++;
                iter = iter.next;
                adet++;
            }
            if (kontrol == true)
            {
                if (kimlikNoKontrol)
                {
                    koltukRezerve.RezerveEt(dt);
                    SeferIslem seferIslem = new SeferIslem();
                    seferIslem.KoltukAzalt(sID, adet);


                    if (rbTekYon.Checked)
                    {
                        pnlBilgiler.Controls.Clear();
                        sifirla();
                        MessageBox.Show("İşlem başarıyla tamamlandı", "Koltuk Rezerve", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (gd == 'd')
                        {
                            pnlBilgiler.Controls.Clear();
                            gidis = false;
                            sifirla();
                            gidisSon = 0;
                            MessageBox.Show("İşlem başarıyla tamamlandı", "Koltuk Rezerve", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            gidis = true;
                            gidisSon = kSayac;
                        }
                    }
                }
                else
                {
                    kSayac = gidisSon;
                    MessageBox.Show("Girdiğiniz TC Kimlik Numaraları benzersiz olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                kSayac = gidisSon;
                MessageBox.Show("Bilgilerinizi doğru bir şekikde girmelisiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool gidis = false;
        int gidisSon;
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (gidis == false)
            {
                kSayac = 0;
                RezerveEt(GidisKoltuklar, 'g');
            }
            if (rbGidisDonus.Checked)
            {
                if(gidis == true)
                    RezerveEt(DonusKoltuklar, 'd');
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            pnlCinsiyet.Visible = false;
            string btnName = "btnKoltuk" + koltukNo;
            Button btnKoltuk = this.Controls.Find(btnName, true).FirstOrDefault() as Button;
            btnKoltuk.Image = UluTP.Properties.Resources.boskol;
            HelperSLL objHelper = new HelperSLL();
            if (rbGidisDonus.Checked)
            {
                if (gidisDonus == 'g')
                    objHelper.DeleteNodebyKey(GidisKoltuklar, koltukNo);
                else
                    objHelper.DeleteNodebyKey(DonusKoltuklar, koltukNo);
            }
            else
                objHelper.DeleteNodebyKey(GidisKoltuklar, koltukNo);
        }

        private void btnBilgiKapat_Click(object sender, EventArgs e)
        {
            pnlKoltukBilgiler.Visible = false;
        }
    }
}
