using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//global data used throughout the program
namespace OrderingSystem
{
    public class GlobalData
    {
        public static MenuManagementSystem MenuOrderingSystem = new MenuManagementSystem();  
        public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\..\\OrderingSystemDB\\OrderingSystemDB.accdb";
        public static string IMAGEFAILED =
            "https://media.istockphoto.com/vectors/no-image-available-icon-vector-id1216251206?k=6&m=1216251206&s=612x612&w=0&h=G8kmMKxZlh7WyeYtlIHJDxP5XRGm9ZXyLprtVJKxd-o=";
        public const double SALES_TAX = 0.08;
        public static string role;
        public static string setMenu;
        public const string TAKEOUT = "0";
    }
}
