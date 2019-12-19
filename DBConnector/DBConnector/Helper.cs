using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DB
{
    public static class Helper
    {
        public static string CheckWorkerID()
        {
            DataSet ds = new DataSet();
            ds = DBConnector.Query("SELECT ID_PRACOWNIKA FROM PRACOWNICY WHERE IMIE = '" + DBConnector.CurrentUser + "' AND WHERE NAZWISKO='" + DBConnector.CurrentPass+"'");
            return ds.ToString();
        }

        public static string CheckVehicleID()
        {
            throw new NotImplementedException();
        }
    }
}