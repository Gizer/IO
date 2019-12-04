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
        public static string sprawdzIDPojazdu()
        {
            throw new NotImplementedException();
        }

        public static string sprawdzIDPracownika()
        {
            throw new NotImplementedException();
        }

        public static DataTable WyswietlPracownikow()
        {
            DataTable dt = new DataTable();
            if (DBConnector.Open())
                dt.Load(DBConnector.Query("SELECT * FROM pracownicy"));
            else
                return null;
            DBConnector.Close();
            return dt;
        }

        public static DataTable WyswietlWypadki()
        {
            DataTable dt = new DataTable();
            if (DBConnector.Open())
                dt.Load(DBConnector.Query("SELECT * FROM wypadki_dane"));
            else
                return null;
            DBConnector.Close();
            return dt;
        }

        public static DataTable WyswietlPojazdy()
        {
            DataTable dt;
            if (DBConnector.Open())
            {
                dt = new DataTable();
                dt.Load(DBConnector.Query("SELECT * FROM pojazdy"));
            }
            else
                return null;
            DBConnector.Close();
            return dt;
        }

        public static DataTable WyswietlRozklad()
        {
            DataTable dt = new DataTable();
            if (DBConnector.Open())
                dt.Load(DBConnector.Query("SELECT * FROM rozklad"));
            else
                return null;
            DBConnector.Close();
            return dt;
        }

        public static DataTable WyswietlZajezdnie()
        {
            DataTable dt = new DataTable();
            if (DBConnector.Open())
                dt.Load(DBConnector.Query("SELECT * FROM zajezdnie"));
            else
                return null;
            DBConnector.Close();
            return dt;
        }

        public static DataTable WyswietlPrzystanki()
        {
            DataTable dt = new DataTable();
            if (DBConnector.Open())
                dt.Load(DBConnector.Query("SELECT * FROM przystanki"));
            else
                return null;
            DBConnector.Close();
            return dt;
        }

        public static DataTable WyswietlGrafik()
        {
            DataTable dt = new DataTable();
            if (DBConnector.Open())
                dt.Load(DBConnector.Query("SELECT * FROM grafik"));
            else
                return null;
            DBConnector.Close();
            return dt;
        }

        public static void UpdatePracownikow()
        {
        }
    }
}