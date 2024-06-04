using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * The purpose of this code is to provide methods to interact with the database for managing menu items,
 * including adding, viewing, deleting, and modifying menu items and their attributes, as well as retrieving menu items by various criteria */

namespace OrderingSystem
{
    class MenuItemDB
    {

        //adds item to menu
        public static void AddItemToMenu(MenuItem item, string imageURL)
        {
            string insertStatement =
                 "INSERT INTO MenuItem (Description, Price, Category, MealType, [ImageURL]) " +
                "VALUES (@Description, @Price, @Category, @MealType, @ImageURL)";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@Description", item.Description);
            command.Parameters.AddWithValue("@Price", item.Price);
            command.Parameters.AddWithValue("@Category", item.Category.ToString());
            command.Parameters.AddWithValue("@MealType", item.MenuType.ToString());
            command.Parameters.AddWithValue("@ImageURL", imageURL);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        //returns a table of items with a certain category
        public static DataTable ViewItemsByCategory(string category)
        {
            OleDbConnection myConnection;
            OleDbDataAdapter myDataAdapter;
            DataSet itemDataSet;
            DataTable itemTable;
            string strSQL;

            strSQL = "SELECT * " +
                    "FROM MenuItem " +
                    "Where Category = '" + category + "'";

            myConnection = new OleDbConnection(GlobalData.ConnectionString);
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            itemDataSet = new DataSet("CategoryTable");
            myDataAdapter.Fill(itemDataSet, "CategoryTable");
            itemTable = itemDataSet.Tables["CategoryTable"];

            return itemTable;
        }
        //deletes an item by its primary key itemID
        public static void DeleteMenuItem(int itemID)
        {
            string deleteStatement =
                "DELETE FROM MenuItem " +
                "WHERE ID = @itemID; ";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(deleteStatement, connection);

            command.Parameters.AddWithValue("@ID", itemID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        //there is 3 different menus: breakfast, lunch, and dinner
        //this functions gets the appropriate menu by checking the time of the day
        public static DataTable getMenuByTimeandCategory(string category)
        {

            int hours = DateTime.Now.Hour;
            string timeAbbreviation = DateTime.Now.ToString("tt");

            string MenuType = "";
            OleDbConnection myConnection;
            OleDbDataAdapter myDataAdapter;
            DataSet menuDataSet;
            DataTable menuTable;
            string strSQL;
            if (timeAbbreviation == "AM")
            {
                MenuType = "Breakfast";

                strSQL = "SELECT * " +
                        "FROM MenuItem " +
                        "Where MealType = '" + MenuType + "'"
                        + "AND Category = '" + category + "'";

                myConnection = new OleDbConnection(GlobalData.ConnectionString);
                myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
                menuDataSet = new DataSet("BreakfastTable");
                myDataAdapter.Fill(menuDataSet, "BreakfastTable");
                menuTable = menuDataSet.Tables["BreakfastTable"];

                return menuTable;
            }

            else if (hours >= 12 && hours < 17)
            {
                MenuType = "Lunch";
                strSQL = "SELECT * " +
                       "FROM MenuItem " +
                       "Where MealType = '" + MenuType + "'"
                       + "AND Category = '" + category + "'";

                myConnection = new OleDbConnection(GlobalData.ConnectionString);
                myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
                menuDataSet = new DataSet("LunchTable");
                myDataAdapter.Fill(menuDataSet, "LunchTable");
                menuTable = menuDataSet.Tables["LunchTable"];

                return menuTable;
            }
            else
            {
                MenuType = "Dinner";
                strSQL = "SELECT * " +
                       "FROM MenuItem " +
                       "Where MealType = '" + MenuType + "'"
                       + "AND Category = '" + category + "'";

                myConnection = new OleDbConnection(GlobalData.ConnectionString);
                myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
                menuDataSet = new DataSet("DinnerTable");
                myDataAdapter.Fill(menuDataSet, "DinnerTable");
                menuTable = menuDataSet.Tables["DinnerTable"];

                return menuTable;
            }

        }
        //update price of a menu item
        public static bool ModifyPrice(int MenuID, string price)
        {
            string insertStatement =
                "UPDATE MenuItem " +
                "SET Price = @Price " +
                "WHERE ID = @MenuID; ";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@MenuID", MenuID);

            connection.Open();

            int count = command.ExecuteNonQuery();

            connection.Close();

            return (count > 0);
        }

        //allow the image of an item to be modified
        public static bool ModifyImageURL(int MenuID, string url)
        {
            string insertStatement =
                "UPDATE MenuItem " +
                "SET ImageURL = @url " +
                "WHERE ID = @MenuID; ";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@url", url);
            command.Parameters.AddWithValue("@MenuID", MenuID);

            connection.Open();

            int count = command.ExecuteNonQuery();

            connection.Close();

            return (count > 0);
        }

        //allows the description of an item to be modified
        public static bool ModifyDescription(int MenuID, string description)
        {
            string insertStatement =
                "UPDATE MenuItem " +
                "SET Description = @Description " +
                "WHERE ID = @MenuID; ";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@MenuID", MenuID);

            connection.Open();

            int count = command.ExecuteNonQuery();

            connection.Close();

            return (count > 0);
        }

        //allows the category of an item to be changed (Appetizer, Dessert, Drink, Entree, None, Salad)
        public static bool ModifyCategory(int MenuID, string category)
        {
            string insertStatement =
                "UPDATE MenuItem " +
                "SET Category = @Category " +
                "WHERE ID = @MenuID; ";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@MenuID", MenuID);

            connection.Open();

            int count = command.ExecuteNonQuery();

            connection.Close();

            return (count > 0);
        }

        //allows the meal type of an item to be changed (Breakfast, Lunch, Dinner, None)
        public static bool ModifyMealType(int MenuID, string mealType)
        {
            string insertStatement =
                "UPDATE MenuItem " +
                "SET MealType = @MealType " +
                "WHERE ID = @MenuID; ";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@MealType", mealType);
            command.Parameters.AddWithValue("@MenuID", MenuID);

            connection.Open();

            int count = command.ExecuteNonQuery();

            connection.Close();

            return (count > 0);
        }

        //gets a certain menu item by its id
        public static MenuItem getMenuItemByID(int ID)
        {
            MenuItem item = new MenuItem();

            string selectStatement =
                    "SELECT Description, Price, Category, MealType " +
                    "FROM MenuItem " +
                    "WHERE ID = @ID";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(selectStatement, connection);

            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();

            OleDbDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.SingleRow & System.Data.CommandBehavior.CloseConnection);

            if (reader.Read())
            {

                item.Description = reader["Description"].ToString();
                item.Price = Double.Parse(reader["Price"].ToString());
                item.Category = (MenuCategory)Enum.Parse(typeof(MenuCategory), reader["Category"].ToString());
                item.MenuType = (MenuType)Enum.Parse(typeof(MenuType), reader["MealType"].ToString());
            }

            connection.Close();

            return item;
        }

        //get id of a menu item by its attributes
        public static int getMenuItemID(MenuItem item)
        {
            int id = -1;
            OleDbConnection myConnection;
            OleDbCommand command;
            string strSQL;

            strSQL = "SELECT ID " +
                    "FROM MenuItem " +
                    "Where Description = '" + item.Description.ToString() + "' AND " +
                    "Price = " + item.Price + " AND " +
                    "Category = '" + item.Category.ToString() + "' AND " +
                     "MealType = '" + item.MenuType.ToString() + "'";

            myConnection = new OleDbConnection(GlobalData.ConnectionString);
            command = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();

            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = (int)reader["ID"];
            }

            myConnection.Close();
            return id;
        }
        //counts the total number of items on the menu
        public static int getMenuItemCount()
        {
            int id = -1;
            OleDbConnection myConnection;
            OleDbCommand command;
            string strSQL;

            strSQL = "SELECT COUNT(ID) as NumberOfItems " +
                    "FROM MenuItem ";
                    

            myConnection = new OleDbConnection(GlobalData.ConnectionString);
            command = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();

            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = (int)reader["NumberOfItems"];
            }

            myConnection.Close();
            return id;
        }
    }
}
