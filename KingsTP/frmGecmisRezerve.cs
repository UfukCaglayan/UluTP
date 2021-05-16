using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsTP
{
    public partial class frmGecmisRezerve : Form
    {
        public frmGecmisRezerve()
        {
            InitializeComponent();
        }


        private void frmRezerveBilgi_Load(object sender, EventArgs e)
        {
            KoltukRezerve koltukRezerve = new KoltukRezerve();
            DataTable dt = koltukRezerve.GecmisRezerve(GirisBilgileri.KullaniciID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ucGecmisRezerve uc1 = new ucGecmisRezerve();
                Label lbTCKimlikNo = uc1.Controls.Find("lbTCKimlikNo", true).FirstOrDefault() as Label;
                lbTCKimlikNo.Text = dt.Rows[i][0].ToString();
                Label lbAdSoyad = uc1.Controls.Find("lbAdSoyad", true).FirstOrDefault() as Label;
                lbAdSoyad.Text = dt.Rows[i][1].ToString();
                Label lbCinsiyet = uc1.Controls.Find("lbCinsiyet", true).FirstOrDefault() as Label;
                lbCinsiyet.Text = dt.Rows[i][2].ToString();
                Label lbKoltukNo = uc1.Controls.Find("lbKoltukNo", true).FirstOrDefault() as Label;
                lbKoltukNo.Text = dt.Rows[i][3].ToString();
                Label lbRezerveID = uc1.Controls.Find("lbRezerveID", true).FirstOrDefault() as Label;
                lbRezerveID.Text = dt.Rows[i][4].ToString();
                uc1.Top = i * 75;
                pnlGecmis.Controls.Add(uc1);
            }
        }

        private void lbMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}
