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

        private void frmSatis_Load(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            DataTable dtKalkis = satis.TerminalDoldur();
            DataTable dtVaris = satis.TerminalDoldur();
            cmbKalkis.DataSource = dtKalkis;
            cmbVaris.DataSource = dtVaris;
            dtDonusTarih.Enabled = false;
            pnlSeferUst.Visible = false;
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.setKalkisID(Convert.ToInt32(cmbKalkis.SelectedValue));
            satis.setVarisID(Convert.ToInt32(cmbVaris.SelectedValue));
            string kalkisTarih = dtGidisTarih.Value.ToString("yyyy-MM-dd");
            satis.setTarih(kalkisTarih);
            DataTable dt = satis.SeferGetir();
            if (dt.Rows.Count > 0)
            {
                pnlSeferUst.Visible = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ucSefer uc1 = new ucSefer();
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
            }
          
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKayit kayit = new frmKayit();
            kayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (btnGiris.Text == "Giriş")
            {
                this.Hide();
                frmGiris giris = new frmGiris();
                giris.Show();
            }
            else
            {
                btnGiris.Text = "Giriş";
                GirisBilgileri.KullaniciID = -1;
                pnlBilgiler.Visible = false;
                btnKayit.Visible = true;
            }
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
    }
}
