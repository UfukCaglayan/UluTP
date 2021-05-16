using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;

namespace KingsTP
{
    public static class MSSQLDataConnection
    {
        public static string dbConnStr = ConfigurationManager.ConnectionStrings["MSSQLconnStr"].ToString();
        private static SqlConnection dbConn = null;
        private static SqlCommand dbCmd = null;

        public static DataTable SelectDataFromDB(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            DataTable dt = new DataTable();
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbConn.Open();
                if (Parameters != null)
                {
                    foreach (SqlParameter param in Parameters)
                        dbCmd.Parameters.Add(param);
                }

                dbCmd.CommandTimeout = 10000;
                dt.Load(dbCmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                dt = null;
                dbCmd = null;
            }
            finally
            {
                dbCmd = null;
                dbConn.Close();
            }
            return dt;
        }
        public static int SelectIntFromDB(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            int sonuc = 0;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbConn.Open();
                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                sonuc = int.Parse(dbCmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                sonuc = -1;
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }
        public static string SelectStringFromDB(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            string sonuc;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbConn.Open();
                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                sonuc = dbCmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                sonuc = "";
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }
        public static bool InsertDataToDB(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            SqlTransaction tran = null;
            bool sonuc = false;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbConn.Open();
                tran = dbConn.BeginTransaction();
                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                dbCmd.Transaction = tran;
                dbCmd.ExecuteNonQuery();
                tran.Commit();
                sonuc = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }

        public static void InsertRezerveTablo(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                using (SqlConnection con = new SqlConnection(dbConnStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert_Rezerve"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@tblRezerveSp", dt);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }

        }
        public static bool UpdateDataToDB(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            SqlTransaction tran = null;
            bool sonuc = false;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbConn.Open();
                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                tran = dbConn.BeginTransaction();
                dbCmd.Transaction = tran;
                dbCmd.ExecuteNonQuery();
                tran.Commit();
                sonuc = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }
        public static bool DeleteDataFromDB(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            SqlTransaction tran = null;
            bool sonuc = false;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbConn.Open();
                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                tran = dbConn.BeginTransaction();
                dbCmd.Transaction = tran;
                dbCmd.ExecuteNonQuery();
                tran.Commit();
                sonuc = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }
        public static int SPGetIntValue(string Query)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            int sonuc = 0;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbConn.Open();
                sonuc = int.Parse(dbCmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                sonuc = -1;
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public static int SPGetIntValue(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            int sonuc = 0;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbConn.Open();

                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                sonuc = int.Parse(dbCmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                sonuc = -1;
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public static void SPExecute(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                dbConn.Open();

                dbCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                dbConn.Close();
            }
        }

        public static int InsertDataToDBrtID(string Query, SqlParameter[] Parameters)
        {
            if (dbConn == null)
                dbConn = new SqlConnection(dbConnStr);

            SqlTransaction tran = null;
            int sonuc = 0;
            try
            {
                dbCmd = new SqlCommand(Query, dbConn);
                dbConn.Open();
                foreach (SqlParameter param in Parameters)
                    dbCmd.Parameters.Add(param);

                tran = dbConn.BeginTransaction();
                dbCmd.Transaction = tran;
                sonuc = Convert.ToInt32(dbCmd.ExecuteScalar());
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                dbConn.Close();
            }
            return sonuc;
        }
    }
}