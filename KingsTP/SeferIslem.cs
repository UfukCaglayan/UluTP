using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class SeferIslem
    {
        int kalkisID;
        int varisID;
        string tarih;

        public void setKalkisID(int kalkisID)
        {
            this.kalkisID = kalkisID;
        }

        public void setVarisID(int varisID)
        {
            this.varisID = varisID;
        }

        public void setTarih(string tarih)
        {
            this.tarih = tarih;
        }

        public DataTable SeferGetir()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT (SELECT TerminalAdi FROM tblTerminaller WHERE ID = KalkisTerminalID) AS KalkisTerminal,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = VarisTerminalID) AS VarisTerminal,KalkisZaman,HareketSuresi,KalanKoltuk,CONVERT(INT, FLOOR(Fiyat)),S.ID,KoltukTuru FROM tblSeferler S INNER JOIN tblOtobusler O ON S.OtobusID = O.ID INNER JOIN tblKoltukTurleri KT ON O.KoltukTuruID = KT.ID WHERE KalkisTerminalID = @param1 AND VarisTerminalID = @param2 AND CONVERT(DATE, KalkisZaman) = @param3", new SqlParameter[] { new SqlParameter("param1", this.kalkisID), new SqlParameter("param2", this.varisID), new SqlParameter("param3", this.tarih) });
            return dt;
        }
        public DataTable TerminalDoldur()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            return dt;
        }

        public void KoltukAzalt(int seferID, int rezerve)
        {
            MSSQLDataConnection.UpdateDataToDB("UPDATE tblSeferler SET KalanKoltuk = KalanKoltuk - @param1 WHERE ID = @param2 ", new SqlParameter[] { new SqlParameter("param1", rezerve), new SqlParameter("param2", seferID) });
        }

        public void KoltukArttir(int rezerveID)
        {
            MSSQLDataConnection.UpdateDataToDB("UPDATE S SET S.KalanKoltuk = S.KalanKoltuk + 1 FROM tblSeferler S INNER JOIN tblKoltukRezerve KR ON S.ID = KR.SeferID WHERE KR.ID =  @param1 ", new SqlParameter[] { new SqlParameter("param1", rezerveID) });
        }
    }
}
