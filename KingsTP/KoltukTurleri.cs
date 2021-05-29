using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class KoltukTurleri
    {
        int ID;
        string kolturTuru;
        public DataTable Doldur()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,KoltukTuru FROM tblKoltukTurleri", null);
            return dt;
        }
    }
}
