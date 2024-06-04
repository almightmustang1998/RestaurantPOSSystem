using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 * This code is designed to export data from the database into CSV files by executing SQL SELECT queries, 
 * generating filenames based on the query statements and current timestamp, and saving the results into 
 * appropriately named CSV files in a specified directory. */

namespace OrderingSystem
{
    class Excel
    {
        public static string SELECTORDERITEMS = "SELECT * FROM OrderItems";
        public static string SELECTMENUITEM = "SELECT * FROM MenuItem";
        public static string SELECTORDER = "SELECT * FROM Orders";
        public static string EXCELFILEDIR = "..\\..\\..\\ExcelLogger\\";
        public static string TYPEOFFILE = ".CSV";
        
        //pass query and file name to create and fill file
        public static void SQLToCSV(string query, string Filename)
        {

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);
            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            using (System.IO.StreamWriter fileStream = new System.IO.StreamWriter(Filename))
            {
                // go thru the fields and add headers
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string field = reader.GetName(i);
                    if (field.Contains(","))
                        field = "\"" + field + "\"";
                    fileStream.Write(field + ",");
                }

                fileStream.WriteLine();

                // go thru the rows and output the data
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string value = reader[i].ToString();
                        if (value.Contains(","))
                            value = "\"" + value + "\"";

                        fileStream.Write(value + ",");
                    }
                    fileStream.WriteLine();
                }
                connection.Close();
                fileStream.Close();
            }
        }

        //create file name based on select statement 
        public static string CreateFileName(string selectstatement)
        {
            string fileName = selectstatement.Substring(selectstatement.LastIndexOf(' '));
            fileName = fileName + DateTime.Now.ToString();
            fileName = Regex.Replace(fileName, "\\s", "_"); //replaces white space with underscore
            fileName = Regex.Replace(fileName, ":", "_");   //replaces dots with underscore
            fileName = Regex.Replace(fileName, "/", "_");   //replaces slash with underscore
            return fileName;
        }

        //returns list of select statements
        public static List<String> CreateSelectList()
        {
            List<string> selectstatements = new List<string>();
            selectstatements.Add(SELECTMENUITEM);
            selectstatements.Add(SELECTORDER);
            selectstatements.Add(SELECTORDERITEMS);

            return selectstatements;
        }

        //creates multiple xslx files 
        public static void ExportXslxFiles()
        {
            //get list of statements
           List<string> statements = CreateSelectList();

           //go through statements
           for(int i = 0; i < statements.Count; i++)
            {
                //create file name
                string fileName = EXCELFILEDIR  + CreateFileName(statements[i]) + TYPEOFFILE;
                //convert the database files to CSV file
                SQLToCSV(statements[i], fileName);
            }

        }
    }
}
