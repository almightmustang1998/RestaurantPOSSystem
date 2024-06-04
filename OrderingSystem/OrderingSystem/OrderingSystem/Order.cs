using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class Order
    {
        private ulong orderNumber;
        private DateTime orderTime;
        private string tableNumber;
        private List<MenuItem> items;
        private double cost;

        public Order()
        {
            orderNumber = 0;
            tableNumber = "";
            items = new List<MenuItem>();
            cost = 0.0;
        }

        public ulong OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public DateTime OrderDateTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }

        public string TableNumber
        {
            get { return tableNumber; }
            set { tableNumber = value; }
        }

        // This property will calculate cost of the order before returning it.
        public double Cost
        {
            get 
            {
                cost = CalculateOrderTotal();
                return cost; 
            }
        }

        public int Count
        {
            get { return items.Count; }
        }

        // This method adds a MenuItem object to the List.
        // This method throws an exception when a null reference is passed as an argument.
        public void Add(MenuItem theItem)
        {
            if (theItem == null)
                throw new NullReferenceException("A null item cannot be added to an order.");
            else
                items.Add(theItem);
        }

        // This method returns a deep-copy of the items in the List of MenuItems as an ArrayList
        // The ArrayList items are deep-copies of the items stored in the List.
        public ArrayList GetItems()
        {
            ArrayList copiedItems = new ArrayList();

            foreach (MenuItem item in items)
            {
                MenuItem copy = new MenuItem();
                copy.Description = item.Description;
                copy.Price = item.Price;
                copy.Category = item.Category;
                copiedItems.Add(copy);
            }

            return copiedItems;
        }

        // This method removes the first instance of the MenuItem object from the List.
        // Returns true if it was able to remove the item. Otherwisem it returns false.
        public bool Remove(MenuItem theItem)
        {
            if (theItem == null)
                return false;

            // Find item to remove
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Description == theItem.Description &&
                    items[i].Price == theItem.Price &&
                    items[i].Category == theItem.Category)
                {
                    items.RemoveAt(i);
                    return true;
                } 
            }

            return false;
        }

        public void ResetOrder()
        {
            items.Clear();
            cost = 0.0;
        }

        private double CalculateOrderTotal()
        {
            double total = 0.0;

            foreach (MenuItem item in items)
            {
                total = total + item.Price;
            }

            return total;
        }

    }   // end class
}   // end namespace
