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
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tarih = dtTarih.Value.ToString("yyyy-MM-dd");
            string saat = txtSaat.Text + ":" + txtDakika.Text;
            string tarihSaat = tarih + " " + saat;
            MessageBox.Show(tarihSaat);


          
        }

        private void nupSaat_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupSaat.Value.ToString()) < 10)
                txtSaat.Text = "0" + nupSaat.Value;
            else
                txtSaat.Text = nupSaat.Value.ToString();
        }

        private void nupDakika_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupDakika.Value.ToString()) < 10)
                txtDakika.Text = "0" + nupDakika.Value;
            else
                txtDakika.Text = nupDakika.Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
