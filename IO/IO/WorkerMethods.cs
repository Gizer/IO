using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class WorkerMethods
    {
        public static DataSet DisplaySchedule()
        {
            DataSet ds;
            if (DBConnector.Open())
            {
                ds = DBConnector.Query("SELECT Grafik.*, p.Imie, p.Nazwisko FROM Grafik LEFT JOIN Pracownicy p ON p.ID_pracownika = Grafik.ID_Pracownika WHERE Grafik.ID_Pracownika = '" + Helper.CheckWorkerID() + "'");
            }
            else
                return null;
            DBConnector.Close();
            return ds;
        }

        public static DataSet DisplayInformation()
        {
            DataSet ds;
            if (DBConnector.Open())
            {
                ds = DBConnector.Query("SELECT * FROM Pracownicy WHERE ID_Pracownika = '" + Helper.CheckWorkerID() + "'");
            }
            else
                return null;
            DBConnector.Close();
            return ds;
        }
    }
}