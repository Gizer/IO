using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Oracle.DataAccess.Client;

namespace DB
{
    public static class DBConnector
    {
        private static OracleConnection connection = null;

        //private  string encString = StringCipher.RandomString();
        public static string CurrentUser;

        public static string CurrentPass;
        public static string Login = string.Empty;

        public static string Pass = string.Empty;

        public static void SetLogin(string login)
        {
            Login = login;// StringCipher.Encrypt(login, encString);
            CurrentUser = login;
        }

        public static void SetPass(string pass)
        {
            Pass = pass;//StringCipher.Encrypt(pass, encString);
            CurrentPass = pass;
        }

        public static bool Open()
        {
            if (connection == null)
            {
                //Twoj connection string
                //connection = new OracleConnection("User Id=" + Login/*StringCipher.Decrypt(Login,encString)*/ + ";Password=" + Pass/*StringCipher.Decrypt(Pass, encString)*/ + ";Data Source=localhost;");

                //Moj connection string
                //connection = con.OracleConnection("");
                connection = new OracleConnection("User Id=" + Login/*StringCipher.Decrypt(Login,encString)*/ + ";Password=" + Pass/*StringCipher.Decrypt(Pass, encString)*/ + ";Data Source=localhost;");
            }
            else if (connection.State == System.Data.ConnectionState.Open)
                return true;
            try
            {
                //con.Open();
                connection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            return false;
        }

        public static bool Close()
        {
            if (connection == null)
                return true;
            else if (connection.State == System.Data.ConnectionState.Closed)
                return true;
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static DataSet Query(string query)
        {
            if (String.IsNullOrEmpty(query))
                return null;
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
                try
                {
                    if (!Open())
                        return null;
                }
                catch
                {
                    return null;
                }
            try
            {
                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Close();
                cmd.Dispose();
                ds.Dispose();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}