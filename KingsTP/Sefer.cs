using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class Sefer
    {
        public void KoltukAzalt(int seferID,int rezerve)
        {
            MSSQLDataConnection.UpdateDataToDB("UPDATE tblSeferler SET KalanKoltuk = KalanKoltuk - @param1 WHERE ID = @param2 ", new SqlParameter[] { new SqlParameter("param1", rezerve), new SqlParameter("param2", seferID) });
        }

        public void KoltukArttir(int rezerveID)
        {
            MSSQLDataConnection.UpdateDataToDB("UPDATE S SET S.KalanKoltuk = S.KalanKoltuk + 1 FROM tblSeferler S INNER JOIN tblKoltukRezerve KR ON S.ID = KR.SeferID WHERE KR.ID =  @param1 ", new SqlParameter[] { new SqlParameter("param1", rezerveID) });
        }
    }
}
