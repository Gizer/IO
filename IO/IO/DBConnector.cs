using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IO
{
    public static class DBConnector
    {
        private static OracleConnection connection = null;
        private static string encString = StringCipher.RandomString();
        private static string Login;
        private static string Pass;

        public static void SetLogin(string login)
        {
            Login = StringCipher.Encrypt(login, encString);
        }
        public static void SetPass(string pass)
        {
            Pass = StringCipher.Encrypt(pass, encString);
        }
        public static bool Open()
        {
            if (connection == null)
                connection = new OracleConnection("User Id=" + StringCipher.Decrypt(Login,encString) + ";Password=" + StringCipher.Decrypt(Pass, encString) + "; Data Source=*Integrated Security=no;");
            else if (connection.State == System.Data.ConnectionState.Open)
                return true;
            try
            {
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

        public static void Close()
        {
            if (connection == null)
                return;
            else if (connection.State == System.Data.ConnectionState.Closed)
                return;
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static OracleDataReader Query(string query)
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
                OracleDataReader dr = new OracleCommand(query, connection).ExecuteReader();
                Close();
                return dr;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
