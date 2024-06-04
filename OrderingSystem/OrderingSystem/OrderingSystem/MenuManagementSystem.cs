using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class MenuManagementSystem
    {
        private List<Order> orders = new List<Order>();
        private List<MenuItem> menu = new List<MenuItem>();

        public bool AddToMenu(MenuItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("MenuItem argument cannot be a null reference.");
            }
            else
            {
                menu.Add(item);
                return true;
            }
        }

        public bool AddToOrder(ulong orderNumber, MenuItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("MenuItem argument cannot be a null reference.");
            }
            else
            {
                Order foundOrder = FindOrder(orderNumber);
                if (foundOrder == null)
                {
                    return false;
                }
                else
                {
                    // create deap-copy - you shmuck!
                    foundOrder.Add(item);
                    return true;
                }
            }
        }

        public void ClearMenu()
        {
            menu.Clear();
        }

        public void ClearOrders()
        {
            orders.Clear();
        }

        public bool CancelOrder(ulong orderNumber)
        {
            Order foundOrder = FindOrder(orderNumber);
            if (foundOrder == null)
            {
                return false;
            }
            else
            {
                orders.Remove(foundOrder);
                return true;
            }
        }

        // This method clears the previous itesm in an existing Order and adds all the items
        // from the Order object passed into the method. A deep-copy of each item is placed into the existing Order.
        // This way the Order cannot be modified outside of the MenuManagementSystem.
        public bool ChangeOrder(ulong orderNumber, Order changedOrder)
        {
            Order originalOrder = FindOrder(orderNumber);
            if (originalOrder == null)
            {
                return false;
            }
            else
            {
                originalOrder.ResetOrder();     // clear the previously ordered items
                originalOrder.TableNumber = changedOrder.TableNumber;

                ArrayList orderItems = changedOrder.GetItems();

                // Create a deep-copy of each item in the Order passed into the method,
                // and store the copied items into the system's existing order.
                foreach (MenuItem item in orderItems)
                {
                    MenuItem copy = new MenuItem();
                    copy.Category = item.Category;
                    copy.Description = item.Description;
                    copy.Price = item.Price;
                    originalOrder.Add(item);
                }

                return true;
            }
        }

        // This method clears the previous items in an existing Order and adds all the items
        // from the List of MenuItem objects passed into the method.  A deep-copy of each item is placed into the existing Order.
        // This way the Order cannot be modified outside of the MenuManagementSystem.
        public bool ChangeOrder(ulong orderNumber, List<MenuItem> items, string tableNumber = "")
        {
            Order theOrder = FindOrder(orderNumber);
            if (theOrder == null || items.Count == 0)
            {
                return false;
            }
            else
            {
                theOrder.ResetOrder();      // clear the previously ordered items
                theOrder.TableNumber = tableNumber;

                // Create a deep-copy of each item in the Order passed into the method,
                // and store the copied items into the system's existing order.
                foreach (MenuItem item in items)
                {
                    MenuItem copy = new MenuItem();
                    copy.Category = item.Category;
                    copy.Description = item.Description;
                    item.Price = copy.Price;
                    theOrder.Add(item);
                }

                return true;
            }
        }

        // This private helper method finds an Order in the List of Orders based on the order number.
        // This method will return null if nothing is found.
        private Order FindOrder(ulong orderNumber)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderNumber == orderNumber)
                    return orders[i];
            }

            return null;
        }

        // This method returns a deep-copy of the items in the List of MenuItems (Menu) as an ArrayList.
        // The ArrayList is a copy of the menu. This way the Menu cannot be modified outside the MenuManagementSystem.
        public ArrayList GetMenu()
        {
            ArrayList copiedItems = new ArrayList();

            foreach (MenuItem item in menu)
            {
                MenuItem copy = new MenuItem();
                copy.Category = item.Category;
                copy.Description = item.Description;
                copy.Price = item.Price;
                copiedItems.Add(copy);
            }

            return copiedItems;
        }

        // This method returns a deep-copy of the items in the List of MenuItems (Menu) by Category as an ArrayList.
        // The ArrayList is a copy of the menu. This way the Menu cannot be modified outside the MenuManagementSystem.
        public ArrayList GetMenu(MenuCategory category)
        {
            ArrayList copiedItems = new ArrayList();

            foreach (MenuItem item in menu)
            {
                if (item.Category == category)
                {
                    MenuItem copy = new MenuItem();
                    copy.Category = item.Category;
                    copy.Description = item.Description;
                    copy.Price = item.Price;
                    copiedItems.Add(copy);
                }
            }

            return copiedItems;
        }

        // This method returns a deep-copy of the orders in the List of Orders as an ArrayList.
        // The ArrayList contains a copy of the orders and it's data. This way the Orders cannot be modified outside the MenuManagementSystem.
        public ArrayList GetOrders()
        {
            ArrayList copiedOrders = new ArrayList();

            foreach (Order order in orders)
            {
                Order copy = new Order();
                DateTime dt = order.OrderDateTime;

                copy.OrderNumber = order.OrderNumber;
                copy.TableNumber = order.TableNumber;
                //copy.OrderDateTime = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Millisecond);
                copy.OrderDateTime = order.OrderDateTime;   //DateTime is a value-type

                ArrayList items = order.GetItems();     // returns a deep-copy of the items in the Order
                for (int i = 0; i < items.Count; i++ )
                {
                    copy.Add((MenuItem)items[i]);
                }

                copiedOrders.Add(copy);
            }

            return copiedOrders;
        }

        // This method returns a deep-copy of a specified Order from the List of Orders. 
        // The Order and its data is copied so it cannot be modified outside the System.
        public Order GetOrder(ulong orderNumber)
        {
            Order originalOrder = FindOrder(orderNumber);
            if (originalOrder == null)
            {
                return null;
            }
            else
            {
                Order copy = new Order();
                DateTime dt = originalOrder.OrderDateTime;

                copy.OrderNumber = originalOrder.OrderNumber;
                copy.TableNumber = originalOrder.TableNumber;
                //copy.OrderDateTime = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Millisecond);
                copy.OrderDateTime = originalOrder.OrderDateTime;   //DateTime is a value-type

                ArrayList items = originalOrder.GetItems();     // returns a deep-copy of the items in the Order
                for (int i = 0; i < items.Count; i++)
                {
                    copy.Add((MenuItem)items[i]);
                }

                return copy;
            }
        }

        // This method removes all occurrences of an item from the Menu. 
        public bool RemoveFromMenu(MenuItem item)
        {
            ArrayList itemsToRemove = new ArrayList();
            bool removed = false;

            // Find items to remove and store their indices
            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Category == item.Category &&
                     menu[i].Description == item.Description &&
                     menu[i].Price == item.Price)
                    itemsToRemove.Add(i);
            }

            // Remove any items that were found
            foreach (int i in itemsToRemove)
            {
                menu.RemoveAt(i);
                removed = true;
            }

            return removed;
        }

        public bool SubmitOrder(List<MenuItem> items, string table = "")
        {
            bool orderCompleted = false;
            string timeStamp = "";
            DateTime time = DateTime.Now;

            if (items.Count > 0)
            {
                timeStamp += time.Month.ToString();
                timeStamp += time.Day.ToString();
                timeStamp += time.Year.ToString();
                timeStamp += time.Hour.ToString();
                timeStamp += time.Minute.ToString();
                timeStamp += time.Second.ToString();
                timeStamp += time.Millisecond.ToString();

                ulong orderNumber = 0;

                if (ulong.TryParse(timeStamp, out orderNumber) == false)
                {
                    throw new Exception("A problem occurred creating the order number.");
                }

                // The Order class' Add method throws an exception when a MenuItem is null.
                // Either pass this exception back to the part of the program that uses this method
                // or return false, which this method does.
                try
                {
                    Order order = new Order();
                    order.OrderDateTime = time;
                    order.OrderNumber = orderNumber;
                    order.TableNumber = table;

                    // Create a deep-copy of the List passed into the method
                    foreach (MenuItem item in items)
                    {
                        MenuItem copy = new MenuItem();
                        copy.Category = item.Category;
                        copy.Description = item.Description;
                        copy.Price = item.Price;
                        order.Add(copy);
                    }

                    int beforeAddCount = orders.Count;
                    orders.Add(order);
                    int afterAddCount = orders.Count;

                    if (afterAddCount > beforeAddCount)
                        orderCompleted = true;
                    else
                        orderCompleted = false;

                }
                catch (Exception ex)
                {
                    orderCompleted = false;
                }
            }

            return orderCompleted;
        }

        public bool SubmitOrder(Order theOrder)
        {
            ArrayList items = theOrder.GetItems();
            List<MenuItem> list = new List<MenuItem>();

            foreach (MenuItem item in items)
            {
                list.Add(item);
            }

            return SubmitOrder(list, theOrder.TableNumber);
        }

    }  // end of class
}  // end of namespace
