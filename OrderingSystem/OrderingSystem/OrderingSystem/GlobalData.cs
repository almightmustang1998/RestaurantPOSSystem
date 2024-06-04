using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class GlobalData
    {
        public static MenuManagementSystem MenuOrderingSystem = new MenuManagementSystem();
        public static string ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = OrderingSystemDB.accdb;";
        public const double SALES_TAX = 0.08;
        public static string role;
    }
}
