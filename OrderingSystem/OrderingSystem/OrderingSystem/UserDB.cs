using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace OrderingSystem
{
    class UserDB
    {
        //returns null if username and password are NOT found
        //otherwise returns the role of the user that logged in 
        public static string Login(string username, string password)
        {
            string role = null;

            string selectStatement =
                    "SELECT Role " +
                    "FROM Login " +
                    "WHERE Username = @username AND Password = @password";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(selectStatement, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();

            OleDbDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.SingleRow & System.Data.CommandBehavior.CloseConnection);

            if (reader.Read())
            {

              role = reader["Role"].ToString(); 

            }

            connection.Close();

            return role;
        }
    }
}
