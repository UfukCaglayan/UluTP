using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KingsTP
{
    public class Kayit
    {
        int ID;
        string adSoyad;
        string TCKimlikNo;
        string telefon;
        string email;
        string sifre;

        public Kayit(string adSoyad, string TCKimlikNo, string telefon, string email, string sifre)
        {
            this.adSoyad = adSoyad;
            this.TCKimlikNo = TCKimlikNo;
            this.telefon = telefon;
            this.email = email;
            this.sifre = sifre;
        }
        public bool kayitVarmi()
        {
            int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblUyeler WHERE TCKimlikNo = @param1 OR Email = @param2", new SqlParameter[] { new SqlParameter("param1", this.TCKimlikNo), new SqlParameter("param2", this.email) });
            if (cnt == 0)
                return true;
            else
                return false;
        }


        public int KayitOl()
        {
            int id = MSSQLDataConnection.InsertDataToDBrtID("INSERT INTO tblUyeler (AdSoyad,TCKimlikNo,Telefon,Email,Sifre,Admin) VALUES (@param1,@param2,@param3,@param4,@param5,@param6) SELECT SCOPE_IDENTITY()", new SqlParameter[] { new SqlParameter("param1", this.adSoyad), new SqlParameter("param2", this.TCKimlikNo), new SqlParameter("param3", this.telefon), new SqlParameter("param4", this.email), new SqlParameter("param5", this.sifre), new SqlParameter("param6", "False") });
            return id;
        }

        public bool emailKontrol(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        

    }
}
