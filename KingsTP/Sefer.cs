using System;
using System.Collections.Generic;
using System.Data;
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

        
        public Sefer(string gidisTS, int kalTerminal_id, int varTerminal_id, string bKod, int hSure, int fiyat, int otobusID)
        {
            this.gidisTS = gidisTS;
            this.kalTerminal_id = kalTerminal_id;
            this.varTerminal_id = varTerminal_id;
            this.bKod = bKod;
            this.hSure = hSure;
            this.fiyat = fiyat;
            this.otobusID = otobusID;
        }

        public void setKalanKoltuk(int otobusID)
        {
            int kalanKoltuk = MSSQLDataConnection.SelectIntFromDB("SELECT KoltukSayisi FROM tblKoltukTurleri KT INNER JOIN tblOtobusler O ON KT.ID = O.KoltukTuruID WHERE O.ID = @param1", new SqlParameter[] { new SqlParameter("param1", otobusID) });
            this.kalanKoltuk = kalanKoltuk;
        }

        public void Kaydet()
        {
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

        public void Guncelle(int id)
        {
            MSSQLDataConnection.InsertDataToDB("UPDATE  tblSeferler SET OtobusID=@param1,KalkisTerminalID=@param2,VarisTerminalID=@param3,KalkisZaman=@param4,BiletKodu=@param5,HareketSuresi=@param6,KalanKoltuk=@param7,Fiyat=@param8 WHERE ID=@param9", new SqlParameter[] {
                new SqlParameter("param1", this.otobusID),
                new SqlParameter("param2", this.kalTerminal_id),
                new SqlParameter("param3", this.varTerminal_id),
                new SqlParameter("param4", this.gidisTS),
                new SqlParameter("param5", this.bKod),
                new SqlParameter("param6", this.hSure),
                new SqlParameter("param7", this.kalanKoltuk),
                new SqlParameter("param8", this.fiyat),
                new SqlParameter("param9", id)
            });
        }

        public DataTable SeferDoldur()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,(SELECT Plaka FROM tblOtobusler WHERE ID = OtobusID) AS Plaka,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = KalkisTerminalID) AS KalkisTerminal,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = VarisTerminalID) AS VarisTerminal,KalkisZaman,BiletKodu,HareketSuresi,KalanKoltuk,Fiyat,KalkisTerminalID,VarisTerminalID,OtobusID FROM tblSeferler", null);
            return dt;
        }

        public void Sil(int seferID)
        {
            MSSQLDataConnection.DeleteDataFromDB("DELETE FROM tblSeferler WHERE ID = @param1", new SqlParameter[] { new SqlParameter("param1", seferID) });
        }

        public DataTable Arama(string biletKodu)
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = KalkisTerminalID) AS KalkisTerminal,(SELECT TerminalAdi FROM tblTerminaller WHERE ID = VarisTerminalID) AS VarisTerminal,KalkisZaman,BiletKodu,HareketSuresi,KalanKoltuk,Fiyat FROM tblSeferler WHERE BiletKodu LIKE '%" + biletKodu + "%'", null); 
            return dt;
        }

        public DataTable OtobusDoldur()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,Plaka FROM tblOtobusler", null);
            return dt;
        }

        public DataTable TerminalDoldur()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            return dt;
        }

    }
}
