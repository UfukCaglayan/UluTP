using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KingsTP
{
    public partial class ucSefer : UserControl
    {
        public ucSefer()
        {
            InitializeComponent();
        }

        private void ucSefer_Load(object sender, EventArgs e)
        {
           /*

            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT (SELECT TerminalAdi FROM tblTerminaller WHERE ID = KalkisTerminalID) AS KalkisTerminal,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = VarisTerminalID) AS VarisTerminal,TarihSaat,HareketSuresi,KalanKoltuk,CONVERT(INT, FLOOR(Fiyat)),S.ID,KoltukTuru FROM tblSeferler S INNER JOIN tblOtobusler O ON S.OtobusID = O.ID INNER JOIN tblKoltukTurleri KT ON O.KoltukTuruID = KT.ID WHERE S.ID = @param1", new SqlParameter[] { new SqlParameter("param1", Sefer1.dtSeferler.Rows[Sefer1.row][0].ToString())});
            lbKalkisTerminal.Text = dt.Rows[0][0].ToString();
            lbVarisTerminal.Text = dt.Rows[0][1].ToString();
            lbKalkisSaat.Text = dt.Rows[0][2].ToString();
            lbHareket.Text = dt.Rows[0][3].ToString() + " Saat";
            lbKalanKoltuk.Text = dt.Rows[0][4].ToString();
            lbFiyat.Text = dt.Rows[0][5].ToString() + " TL";
            lbSeferID.Text = dt.Rows[0][6].ToString();
            lbKoltukTuru.Text = dt.Rows[0][7].ToString();
            Sefer1.row++;*/
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (GirisBilgileri.KullaniciID != -1)
            {
                frmKoltukRezerve KT = new frmKoltukRezerve();
                KT.Show();
                KT.KoltukDoldur(Convert.ToInt32(lbSeferID.Text));
            }
            else
                MessageBox.Show("Önce giriş yapmalısınız");
        }
    }
}
