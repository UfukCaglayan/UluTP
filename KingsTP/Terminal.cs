using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class Terminal
    {
        int ID;
        string terminalAdi;

        public Terminal()
        {

        }

        public Terminal(string terminalAdi)
        {
            this.terminalAdi = terminalAdi;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
     
        
        public bool terminalVarmi(string terminalAdi)
        {
            bool kontrol = false;

            int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblTerminaller WHERE TerminalAdi = @param1", new SqlParameter[] { new SqlParameter("param1", terminalAdi) });
            if (cnt == 0)
                kontrol = false;
            else
                kontrol = true;

            return kontrol;
        }
        public DataTable Doldur()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT * FROM tblTerminaller", null);
            return dt;
        }

        public DataTable Arama(string terminalAdi)
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT * FROM tblTerminaller WHERE TerminalAdi LIKE '%" + terminalAdi + "%'", null);
            return dt;
        }

        public void Kaydet()
        {
            MSSQLDataConnection.InsertDataToDB("INSERT INTO tblTerminaller (TerminalAdi) VALUES (@param1)", new SqlParameter[] { new SqlParameter("param1", this.terminalAdi) });
        }

        public void Guncelle()
        {
            MSSQLDataConnection.UpdateDataToDB("UPDATE tblTerminaller SET TerminalAdi = @param1 WHERE ID = @param2 ", new SqlParameter[] { new SqlParameter("param1", this.terminalAdi), new SqlParameter("param2", this.ID) });
        }

        public void Sil(int terminalID)
        {
            MSSQLDataConnection.DeleteDataFromDB("DELETE FROM tblTerminaller WHERE ID = @param1", new SqlParameter[] { new SqlParameter("param1", terminalID) });
        }
    }
}
