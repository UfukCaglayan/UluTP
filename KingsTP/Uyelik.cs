﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class Uyelik
    {
        int ID;
        string adSoyad;
        string TCKimlikNo;
        string telefon;
        string email;
        string sifre;

        public Uyelik(string adSoyad, string TCKimlikNo, string telefon, string email, string sifre)
        {
            this.adSoyad = adSoyad;
            this.TCKimlikNo = TCKimlikNo;
            this.telefon = telefon;
            this.email = email;
            this.sifre = sifre;
        }



        public bool KayitOl()
        {
            int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblUyeler WHERE TCKimlikNo = @param1 OR Email = @param2", new SqlParameter[] { new SqlParameter("param1", this.TCKimlikNo), new SqlParameter("param2", this.email) });
            if (cnt == 0)
            {
                MSSQLDataConnection.InsertDataToDB("INSERT INTO tblUyeler (AdSoyad,TCKimlikNo,Telefon,Email,Sifre) VALUES (@param1,@param2,@param3,@param4,@param5)", new SqlParameter[] { new SqlParameter("param1", this.adSoyad), new SqlParameter("param2", this.TCKimlikNo), new SqlParameter("param3", this.telefon), new SqlParameter("param4", this.email), new SqlParameter("param5", this.sifre) });
                return true;
            }
            else
                return false;
        }

        

    }
}
