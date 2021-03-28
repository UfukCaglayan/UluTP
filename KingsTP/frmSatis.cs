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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            DataTable dtKalkis = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            DataTable dtVaris = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            cmbKalkis.DataSource = dtKalkis;
            cmbVaris.DataSource = dtVaris;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string kalkisTarih = dtTarih.Value.ToString("yyyy-MM-dd");
            Sefer.KalkisID = Convert.ToInt32(cmbKalkis.SelectedValue);
            Sefer.VarisID = Convert.ToInt32(cmbVaris.SelectedValue);
            Sefer.tarih = kalkisTarih;

            int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblSeferler WHERE KalkisTerminaIID = @param1 AND VarisTerminalIID = @param2 AND CONVERT(DATE, TarihSaat) = @param3", new SqlParameter[] { new SqlParameter("param1", cmbKalkis.SelectedValue), new SqlParameter("param2", cmbVaris.SelectedValue), new SqlParameter("param3", kalkisTarih) });
            for (int i = 0; i < 5; i++)
            {
                ucSefer uc1 = new ucSefer();
                uc1.Top = i * 100;
                pnlSeferler.Controls.Add(uc1);
            }
            
          
        }
    }
}
