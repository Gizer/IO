using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ManagerMethods
    {
        public static DataSet DisplayTable(string name)
        {
            DataSet ds = new DataSet();
            if (DBConnector.Open())
                ds = (DBConnector.Query("SELECT * FROM " + name));
            else
                return null;
            DBConnector.Close();
            return ds;
        }

        public static bool UpdateTable(string tableName, string colName, string newValue, string id, string where)
        {
            if (DBConnector.Open())
            {
                try
                {
                    DBConnector.Query("UPDATE " + tableName + " SET " + colName + " = '" + newValue + "' WHERE " + where + " = '" + id + "'");
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
        }

        public static bool DeleteFromTable(string tableName, string id, string where)
        {
            if (DBConnector.Open())
            {
                try
                {
                    DBConnector.Query("DELETE FROM " + tableName + " WHERE " + where + " = '" + id + "'");
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}