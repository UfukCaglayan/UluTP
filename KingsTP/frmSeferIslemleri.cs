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
    public partial class frmSeferIslemleri : Form
    {
        public frmSeferIslemleri()
        {
            InitializeComponent();
        }

        private void frmSeferIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dtOtobusler = MSSQLDataConnection.SelectDataFromDB("SELECT ID,Plaka FROM tblOtobusler", null);
            cmbOtobus.DataSource = dtOtobusler;
            DataTable dtKalkis = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            cmbKalkis.DataSource = dtKalkis;
            DataTable dtVaris = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            cmbVaris.DataSource = dtVaris;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string gidisTarih = dtGidisTarih.Value.ToString("yyyy-MM-dd");
            string gidisSaat = txtGidisSaat.Text + ":" + txtGidisDakika.Text;
            string gidisTarihSaat = gidisTarih + " " + gidisSaat;

            string donusTarih = dtDonusTarih.Value.ToString("yyyy-MM-dd");
            string donusSaat = txtDonusSaat.Text + ":" + txtDonusDakika.Text;
            string donusTarihSaat = donusTarih + " " + donusSaat;

            int otobusID = Convert.ToInt32(cmbOtobus.SelectedValue);

            int kalanKoltuk = MSSQLDataConnection.SelectIntFromDB("SELECT KoltukSayisi FROM tblKoltukTurleri KT INNER JOIN tblOtobusler O ON KT.ID = O.KoltukTuruID WHERE O.ID = @param1", new SqlParameter[] { new SqlParameter("param1", otobusID) });

        }

        private void nupSaat_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupGidisSaat.Value.ToString()) < 10)
                txtGidisSaat.Text = "0" + nupGidisSaat.Value;
            else
                txtGidisSaat.Text = nupGidisSaat.Value.ToString();
        }

        private void nupDakika_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupGidisDakika.Value.ToString()) < 10)
                txtGidisDakika.Text = "0" + nupGidisDakika.Value;
            else
                txtGidisDakika.Text = nupGidisDakika.Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void nupDonusSaat_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupDonusSaat.Value.ToString()) < 10)
                txtDonusSaat.Text = "0" + nupDonusSaat.Value;
            else
                txtDonusSaat.Text = nupDonusSaat.Value.ToString();
        }

        private void nupDonusDakika_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupDonusDakika.Value.ToString()) < 10)
                txtDonusDakika.Text = "0" + nupDonusDakika.Value;
            else
                txtDonusDakika.Text = nupDonusDakika.Value.ToString();
        }
    }
}
