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
        private string gidisTS;
        

        private int kalTerminal_id;
        private int varTerminal_id;

        private string bKod;
        private int hSure;
        private int fiyat;
        private int otobusID;

        private int kalanKoltuk;

        public Sefer()
        {

        }
        public Sefer(string gidisTS, int kalTerminal_id, int varTerminal_id, string bKod, int hSure, int fiyat, int otobusID, int kalanKoltuk)
        {
            this.gidisTS = gidisTS;
            this.kalTerminal_id = kalTerminal_id;
            this.varTerminal_id = varTerminal_id;
            this.bKod = bKod;
            this.hSure = hSure;
            this.fiyat = fiyat;
            this.otobusID = otobusID;
            this.kalanKoltuk = kalanKoltuk;


            MSSQLDataConnection.InsertDataToDB("INSERT INTO tblSeferler (OtobusID,KalkisTerminalID,VarisTerminalID,KalkisZaman,BiletKodu,HareketSuresi,KalanKoltuk,Fiyat) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)", new SqlParameter[] {
                new SqlParameter("param1", this.otobusID),
                new SqlParameter("param2", this.kalTerminal_id),
                new SqlParameter("param3", this.varTerminal_id),
                new SqlParameter("param4", this.gidisTS),
                new SqlParameter("param5", this.bKod),
                new SqlParameter("param6", this.hSure),
                new SqlParameter("param7", this.kalanKoltuk),
                new SqlParameter("param8", this.fiyat)
            });
        }

            


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
