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
           /* DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT KalkisTerminalID,VarisTerminalID,CONVERT(TIME,TarihSaat) FROM tblSeferler WHERE KalkisTerminaIID = @param1 AND VarisTerminalIID = @param2 AND CONVERT(DATE, TarihSaat) = @param3", new SqlParameter[] { new SqlParameter("param1", Sefer.KalkisID), new SqlParameter("param2", Sefer.VarisID), new SqlParameter("param3", Sefer.tarih) });
            lbKalkisTerminal.Text = dt.Rows[0][0].ToString();
            lbVarisTerminal.Text = dt.Rows[0][1].ToString();
            lbKalkisSaat.Text = dt.Rows[0][2].ToString();*/
        }
    }
}
