using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public static class ManagerMethods
    {
        //private DBConnector DBConnector = new DBConnector();

        //public interface IOpen
        //{
        //    bool Open();
        //}

        //public interface IQuery
        //{
        //    DataSet Query
        //}

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

        public static bool AddRecord(char type, string[] args)
        {
            if (type == 'n')
            {
                if (DBConnector.Open())
                {
                    try
                    {
                        DBConnector.Query(String.Format("INSERT INTO NUMER_LINII (ID_NUMER_LINII, NUMER_LINII) VALUES ({0}, '{1}')", args[0], args[1]));
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
            else if (type == 'd')
            {
                if (DBConnector.Open())
                {
                    try
                    {
                        DBConnector.Query(String.Format("INSERT INTO ZAJEZDNIE (ID_ZAJEZDNI, NAZWA, LICZBA_STANOWISK, ADRES) VALUES ({0}, '{1}', {2}, '{3}')", args[0], args[1], args[2], args[3]));
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
            else if (type == 's')
            {
                if (DBConnector.Open())
                {
                    try
                    {
                        DBConnector.Query(String.Format("INSERT INTO GRAFIK (ID_GRAFIK, DZIEN_TYGODNIA, CZAS_ROZPOCZECIA, CZAS_KONCA, ID_POJAZDU, ID_PRACOWNIKA) VALUES ({0}, TO_TIMESTAMP('{1}', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('{2}', 'YYYY-MM-DD HH24:MI:SS'), '{3}', {4}, {5})", args[0], args[1], args[2], args[3], args[4], args[5]));
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
            else if (type == 'p')
            {
                if (DBConnector.Open())
                {
                    try
                    {
                        DBConnector.Query(String.Format("INSERT INTO PRZYSTANKI (ID_PRZYSTANKU, NAZWA, PRZYSTANEK_PODWOJNY) VALUES ({0}, '{1}', {2})", args[0], args[1], args[2]));
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
            else if (type == 't')
            {
                if (DBConnector.Open())
                {
                    try
                    {
                        DBConnector.Query(String.Format("INSERT INTO ROZKLAD (ID_ROZKLADU, CZAS, ID_PRZYSTANKU, ID_POJAZDU, ID_NUMER_LINII) VALUES ({0}, TO_TIMESTAMP('{1}', 'YYYY-MM-DD HH24:MI:SS'), {2}, {3}, {4})", args[0], args[1], args[2], args[3], args[4]));
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
            else if (type == 'v')
            {
                if (DBConnector.Open())
                {
                    try
                    {
                        DBConnector.Query(String.Format("INSERT INTO POJAZDY (ID_POJAZDU, NUMER_POJAZDU, ID_NUMER_LINII, ID_ZAJEZDNI) VALUES ({0}, '{1}', {2}, {3})", args[0], args[1], args[2], args[3]));
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
            else if (type == 'w')
            {
                if (DBConnector.Open())
                {
                    try
                    {
                        DBConnector.Query(String.Format("INSERT INTO PRACOWNICY (ID_PRACOWNIKA, IMIE, NAZWISKO, PESEL, PLACA, PREMIA) VALUES ({0}, '{1}', '{2}', {3}, {4}, {5})", args[0], args[1], args[2], args[3], args[4], args[5]));
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
            else
                return false;
        }
    }
}