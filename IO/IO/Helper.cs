using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class Helper
    {
        public static string CheckWorkerID()
        {
            foreach (var item in Program.users)
            {
                if (item.Item1 == DBConnector.CurrentUser && item.Item2 == DBConnector.CurrentPass)
                    return item.Item3;
            }
            throw new Exception("Nieznany błąd");
        }

        public static string CheckVehicleID()
        {
            throw new NotImplementedException();
        }
    }
}