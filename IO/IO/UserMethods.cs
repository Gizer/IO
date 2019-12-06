using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    internal class UserMethods
    {
        public static DataSet DisplayTimetable()
        {
            DataSet ds;
            if (DBConnector.Open())
            {
                ds = DBConnector.Query("SELECT CZAS, P.Nazwa, p.przystanek_podwojny, n.numer_linii FROM rozklad LEFT JOIN Przystanki p ON p.ID_Przystanku = rozklad.ID_Przystanku LEFT JOIN Numer_Linii n ON n.id_numer_linii = rozklad.ID_Numer_Linii");
            }
            else
                return null;
            DBConnector.Close();
            return ds;
        }
    }
}