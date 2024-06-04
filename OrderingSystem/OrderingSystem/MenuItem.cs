using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//allows the creation and management of menu items with properties like description, price, category, and meal type (breakfast, lunch, dinner).

namespace OrderingSystem
{
    public enum MenuCategory
    {
        Appetizer, Dessert, Drink, Entree, None, Salad
    }

    //added menu type to define breakfast, lunch, or dinner
    public enum MenuType
    {
        Breakfast, Lunch, Dinner, None
    }

    public class MenuItem
    {
        private string description;
        private double price;
        private MenuCategory category;
        private MenuType meal;

        public MenuItem()
        {
            description = "";
            price = 0.0;
            category = MenuCategory.None;
            meal = MenuType.None;
        }

        public MenuItem(string description, double price, MenuCategory category)
        {
            this.description = description;
            this.price = price;
            this.category = category;
        }

        //constructor with menu type 
        public MenuItem(string description, double price, MenuCategory category, MenuType meal)
        {
            this.description = description;
            this.price = price;
            this.category = category;
            this.meal = meal;
        }

        public MenuType MenuType
        {
            get { return meal; }
            set { meal = value; }
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
