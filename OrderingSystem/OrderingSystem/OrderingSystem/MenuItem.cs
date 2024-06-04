using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public enum MenuCategory 
    {
        Appetizer, Dessert, Drink, Entree, None, Salad 
    }

    public class MenuItem
    {
        private string description;
        private double price;
        private MenuCategory category;

        public MenuItem()
        {
            description = "";
            price = 0.0;
            category = MenuCategory.None;
        }

        public MenuItem(string description, double price, MenuCategory category)
        {
            this.description = description;
            this.price = price;
            this.category = category;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        public double Price
        {
            get { return price; }
            set 
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentException("Price cannot be a negative value");
            }
        }

        public MenuCategory Category
        {
            get { return category; }
            set { category = value; }
        }


       
    }
}
