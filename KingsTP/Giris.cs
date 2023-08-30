using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class Giris
    {
        string email;
        string sifre;
        string adSoyad;

        public Giris(string email, string sifre)
        {
            this.email = email;
            this.sifre = sifre;
        }
        public int GirisYap()
        {
            int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblUyeler WHERE Email = @param1 AND Sifre = @param2", new SqlParameter[] { new SqlParameter("param1", this.email), new SqlParameter("param2", this.sifre) });
            if (cnt == 1)
            {
                DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,AdSoyad FROM tblUyeler WHERE Email = @param1 AND Sifre = @param2", new SqlParameter[] { new SqlParameter("param1", this.email), new SqlParameter("param2", this.sifre) });
                this.adSoyad = dt.Rows[0][1].ToString();
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
                return -1;
        }
        public bool adminKontrol()
        {
            string kontrol = MSSQLDataConnection.SelectStringFromDB("SELECT Admin FROM tblUyeler WHERE Email = @param1", new SqlParameter[] { new SqlParameter("param1", this.email) });
            if (kontrol == "True")
                return true;
            else
                return false;

        }

        public string getAdSoyad()
        {
            return this.adSoyad;
        }
    }
}
