using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
The purpose of this code is to manage orders within the ordering system database. It provides functionalities for adding new orders,
updating and deleting existing orders, managing order items, and retrieving information about orders and their statuses from the database.
The code uses the OleDb library to interact with a database, handling operations like inserting, updating, and querying data related to orders and their items.
*/

namespace OrderingSystem
{
    class OrderDB
    {
        //adds an order to the db
        public static void AddOrder(Order currentOrder)
        {
            try{
                string insert =
                    "INSERT INTO Orders (OrderTime, TableNumber, Cost, Finished, Priority) " +
                   "VALUES (@OrderTime, @TableNumber, @Cost, @NotFinished, @Priority)";

                OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);
                OleDbCommand cmnd = new OleDbCommand(insert, connection);

                cmnd.Parameters.AddWithValue("@OrderTime", currentOrder.OrderDateTime.ToString());
                cmnd.Parameters.AddWithValue("@TableNumber", currentOrder.TableNumber.ToString());
                cmnd.Parameters.AddWithValue("@Cost", currentOrder.Cost);
                cmnd.Parameters.AddWithValue("@NotFinished", "Not Finished");
                cmnd.Parameters.AddWithValue("@Priority", false);

                connection.Open();

                cmnd.ExecuteNonQuery();

                connection.Close();
            }

            catch(Exception e )
            {
                Console.WriteLine(e.ToString());
            }
        }
        //look up an order by an id number
        public static int findOrderID(Order currentOrder)
        {
            int id = -1;
            OleDbConnection myConnection;
            OleDbCommand command;
            string strSQL;

            strSQL = "SELECT ID " +
                    "FROM Orders " +
                    "Where OrderTime = '" + currentOrder.OrderDateTime.ToString() + "' AND " +
                    "TableNumber = '" + currentOrder.TableNumber.ToString() + "' AND " +
                    "Cost = " + currentOrder.Cost + "";

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

        //take a list of items as currentOrder to add them to the DB
        public static void AddOrderItems(int orderID, Order currentOrder)
        {
            List<MenuItem> items = currentOrder.GetItemsInList();

            for(int i = 0; i < items.Count; i++)
            {
                MenuItem currentitem = items[i];
                int MenuID = MenuItemDB.getMenuItemID(currentitem);
                string insertStatement =
                "INSERT INTO OrderItems (OrderID, MenuItemID, Progress) " +
               "VALUES (@OrderID, @MenuItemID, @Progress )";

                OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

                OleDbCommand command = new OleDbCommand(insertStatement, connection);

                command.Parameters.AddWithValue("@OrderID", orderID);
                command.Parameters.AddWithValue("@MenuItemID", MenuID);
                command.Parameters.AddWithValue("@Progress", "Not Started");

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        //adds item to an existing order
        public static void AddNewItemsToOrder(int orderID, int menuID)
        {
            string insertStatement =
            "INSERT INTO OrderItems (OrderID, MenuItemID, Progress) " +
           "VALUES (@OrderID, @MenuItemID, @Progress )";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@OrderID", orderID);
            command.Parameters.AddWithValue("@MenuItemID", menuID);
            command.Parameters.AddWithValue("@Progress", "Not Started");

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        //get all orders that have not been completed
        public static DataTable GetOrdersNotDone(String view)
        {
            OleDbConnection myConnection;
            OleDbDataAdapter myDataAdapter;
            DataSet orderDataSet;
            DataTable orderTable;
            string strSQL;

            strSQL = "SELECT * " +
                    "FROM Orders"  +
                   " WHERE Finished = " + "'" + view + "'" +
                   "Order by Priority ASC, ID ASC;";

            myConnection = new OleDbConnection(GlobalData.ConnectionString);
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);

            orderDataSet = new DataSet("OrderTable");
            myDataAdapter.Fill(orderDataSet, "OrderTable");
            orderTable = orderDataSet.Tables["OrderTable"];

            return orderTable;
        }

        //update an order to be completed
        public static void OrderUpdate(int id)
        {
           
            try
            {
                string insert =
                    "UPDATE Orders " + 
                "SET Finished = @Finished " +
                "WHERE ID = @ID; ";

                OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);
                OleDbCommand cmnd = new OleDbCommand(insert, connection);

                cmnd.Parameters.AddWithValue("@Finished", "Finished");
                cmnd.Parameters.AddWithValue("@ID", id);

                connection.Open();

                cmnd.ExecuteNonQuery();

                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        //users are allowed to cancel orders. this deletes the order from the database. 
        public static void CancelOrder(int itemID)
        {
            string deleteStatement =
                "DELETE FROM Orders " +
                "WHERE ID = @itemID; ";

            OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);

            OleDbCommand command = new OleDbCommand(deleteStatement, connection);

            command.Parameters.AddWithValue("@ID", itemID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        //return a list of all items in an order by passing the id of the order in the parameter (id is Primary Key, in DB it is OrderID)
        public static List<int> GetItemsInOrder(int id)
        {
            List<int> listOfItems = new List<int>();

            OleDbConnection myConnection;
            OleDbCommand command;
            string strSQL;

            strSQL = "SELECT * " +
                    "FROM OrderItems WHERE OrderID = @OrderID";


            myConnection = new OleDbConnection(GlobalData.ConnectionString);
            command = new OleDbCommand(strSQL, myConnection);
            command.Parameters.AddWithValue("@OrderID", id);
            myConnection.Open();

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int menuItemID = (int)reader["MenuItemID"];
                listOfItems.Add(menuItemID);

            }

            myConnection.Close();

            return listOfItems;

        }


        //returns a list of all items in the order with the progress of each item such as completed or in progress
        public static List<string> GetItemsInOrderAndProgress(int id)
        {
            List<string> listOfItems = new List<string>();

            OleDbConnection myConnection;
            OleDbCommand command;
            string strSQL;

            strSQL = "SELECT * " +
                    "FROM OrderItems WHERE OrderID = @OrderID";


            myConnection = new OleDbConnection(GlobalData.ConnectionString);
            command = new OleDbCommand(strSQL, myConnection);
            command.Parameters.AddWithValue("@OrderID", id);
            myConnection.Open();

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                int IndvidualID = (int)reader["IndividualID"];
                int menuItemID = (int)reader["MenuItemID"];
                string progress = reader["Progress"].ToString();
                listOfItems.Add(menuItemID + ","+ progress + "," + IndvidualID);

            }

            myConnection.Close();

            return listOfItems;

        }

        //update the status of an item 
        public static void OrderUpdateProgress(int itemID, string change)
        {
           
            try
            {
                string update =
                    "UPDATE OrderItems " +
                "SET Progress = @Progress " +
                "WHERE IndividualID = @ItemID ";

                OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);
                OleDbCommand cmnd = new OleDbCommand(update, connection);

                cmnd.Parameters.AddWithValue("@Progress", change);
                cmnd.Parameters.AddWithValue("@ItemID", itemID);

                connection.Open();

                cmnd.ExecuteNonQuery();

                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //removes an item from a specific order
        public static void RemoveItemFromOrder(int itemID)
        {
            try
            {
                string delete =
                    "DELETE FROM OrderItems " +
                "WHERE IndividualID = @itemID; ";

                OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);
                OleDbCommand cmnd = new OleDbCommand(delete, connection);

                cmnd.Parameters.AddWithValue("@ItemID", itemID);

                connection.Open();

                cmnd.ExecuteNonQuery();

                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Update total coast
        public static void OrderUpdateCost(int OrderID, double Cost)
        {

            try
            {
                string update =
                    "UPDATE Orders " +
                "SET Cost = @cost " +
                "WHERE ID = @OrderID";

                OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);
                OleDbCommand cmnd = new OleDbCommand(update, connection);

                cmnd.Parameters.AddWithValue("@cost", Cost);
                cmnd.Parameters.AddWithValue("@OrderID", OrderID);
                

                connection.Open();

                cmnd.ExecuteNonQuery();

                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //moves up the priority of an order
        public static void MakeOrderPriority(int OrderID)
        {

            try
            {
                string update =
                    "UPDATE Orders " +
                "SET Priority = @Priority " +
                "WHERE ID = @OrderID";

                OleDbConnection connection = new OleDbConnection(GlobalData.ConnectionString);
                OleDbCommand cmnd = new OleDbCommand(update, connection);

                cmnd.Parameters.AddWithValue("@Priority", true);
                cmnd.Parameters.AddWithValue("@OrderID", OrderID);


                connection.Open();

                cmnd.ExecuteNonQuery();

                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
