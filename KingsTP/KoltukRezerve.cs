using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KingsTP
{
    public class KoltukRezerve
    {
        public int KoltukTuruGetir(int seferID)
        {
            int koltukTuru = MSSQLDataConnection.SelectIntFromDB("SELECT KoltukTuruID FROM tblSeferler S INNER JOIN tblOtobusler O ON S.OtobusID = O.ID WHERE S.ID = @param1", new SqlParameter[] { new SqlParameter("param1", seferID) });
            return koltukTuru;
        }
        public DataTable KoltukDoldur(int seferID)
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT KoltukNo,Cinsiyet FROM tblKoltukRezerve WHERE SeferID = @param1", new SqlParameter[] { new SqlParameter("param1", seferID) });
            return dt;
        }

        public void RezerveEt(DataTable dt)
        {
            MSSQLDataConnection.InsertRezerveTablo(dt);
        }

        public DataTable GecmisRezerve(int uyeID)
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT TCKimlikNo,Ad + ' ' + Soyad AS AdSoyad,Cinsiyet,KoltukNo,KR.ID,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = KalkisTerminalID) AS KalkisTerminal,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = VarisTerminalID) AS VarisTerminal FROM tblKoltukRezerve KR INNER JOIN tblSeferler S ON KR.SeferID = S.ID WHERE UyeID = @param1 AND KalkisZaman > GETDATE()", new SqlParameter[] { new SqlParameter("param1", uyeID) });
            return dt;
        }

        public void RezerveIptal(int rezerveID)
        {
            MSSQLDataConnection.DeleteDataFromDB("DELETE FROM tblKoltukRezerve WHERE ID = @param1", new SqlParameter[] { new SqlParameter("param1", rezerveID) });
        }
    }
}
