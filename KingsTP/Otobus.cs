using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class Otobus
    {
        int ID;
        string plaka;
        int koltukTuruID;

        public Otobus()
        {

        }

        public Otobus(string plaka, int koltukTuruID)
        {
            this.plaka = plaka;
            this.koltukTuruID = koltukTuruID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public bool otobusVarmi(string plaka)
        {
            bool kontrol = false;

            int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblOtobusler WHERE Plaka = @param1", new SqlParameter[] { new SqlParameter("param1", plaka) });
            if (cnt == 0)
                kontrol = false;
            else
                kontrol = true;

            return kontrol;
        }
        public DataTable Doldur()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT O.ID,Plaka,KoltukTuru,KoltukTuruID FROM tblOtobusler O INNER JOIN tblKoltukTurleri KT ON O.KoltukTuruID = KT.ID", null);
            return dt;
        }

        public DataTable Arama(string plaka)
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT O.ID,Plaka,KoltukTuru,KoltukTuruID FROM tblOtobusler O INNER JOIN tblKoltukTurleri KT ON O.KoltukTuruID = KT.ID WHERE Plaka LIKE '%" + plaka + "%'", null);
            return dt;
        }

        public void Kaydet()
        {
            MSSQLDataConnection.InsertDataToDB("INSERT INTO tblOtobusler (Plaka,KoltukTuruID) VALUES (@param1,@param2)", new SqlParameter[] { new SqlParameter("param1", this.plaka), new SqlParameter("param2", this.koltukTuruID) });
        }

        public void Guncelle()
        {
            MSSQLDataConnection.UpdateDataToDB("UPDATE tblOtobusler SET Plaka = @param1,KoltukTuruID= @param2 WHERE ID = @param3 ", new SqlParameter[] { new SqlParameter("param1", this.plaka), new SqlParameter("param2", this.koltukTuruID), new SqlParameter("param3", this.ID) });
        }

        public void Sil(int otobusID)
        {
            MSSQLDataConnection.DeleteDataFromDB("DELETE FROM tblOtobusler WHERE ID = @param1", new SqlParameter[] { new SqlParameter("param1", otobusID) });
        }
    }
}
