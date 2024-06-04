using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class frmMainMenu : Form
    {
        // TEST/DEMO - ArrayList should be replaced with a database.
        private ArrayList arrTest = new ArrayList();    

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            SetupMenu();        // TEST GUI
            SetupForm();
        }
        private void SetupForm()
        {
            if(GlobalData.role == "Server")
            {
                btnMenu.Visible = false;
                btnViewOrders.Visible = false;
                btnCreateOrder.Visible = true;
                lblTitle.Text = "Server Main Menu";
            }
            else if(GlobalData.role == "Kitchen")
            {
                btnMenu.Visible = false;
                btnViewOrders.Visible = true;
                btnCreateOrder.Visible = false;
                lblTitle.Text = "Kitchen Main Menu";
            }
            else
            {
                btnMenu.Visible = true;
                btnViewOrders.Visible = true;
                btnCreateOrder.Visible = true;
                lblTitle.Text = "Manager Main Menu";
            }
        }

            private void SetupMenu()
        {
            // Add a number of Appetizers
            arrTest.Add(new MenuItem("Chicken Enchilada Soup", 3.99, MenuCategory.Appetizer));
            arrTest.Add(new MenuItem("California Crab Salad", 9.99, MenuCategory.Appetizer));
            arrTest.Add(new MenuItem("Bloomin Onion", 7.99, MenuCategory.Appetizer));
            arrTest.Add(new MenuItem("Texas Cheese Fries", 4.99, MenuCategory.Appetizer));

            // Add a number of Entrees
            arrTest.Add(new MenuItem("Surf & Turf", 32.99, MenuCategory.Entree));
            arrTest.Add(new MenuItem("9oz Filet", 23.99, MenuCategory.Entree));
            arrTest.Add(new MenuItem("Chicken Piccata", 15.99, MenuCategory.Entree));
            arrTest.Add(new MenuItem("Veal Marsala", 17.99, MenuCategory.Entree));
            arrTest.Add(new MenuItem("Grilled Salmon", 18.99, MenuCategory.Entree));

            // Add a number of Desserts
            arrTest.Add(new MenuItem("Tiramisu", 8.99, MenuCategory.Dessert));
            arrTest.Add(new MenuItem("Cheesecake", 5.99, MenuCategory.Dessert));
            arrTest.Add(new MenuItem("Chocolate Cake", 5.99, MenuCategory.Dessert));

            // Add a number of Drinks
            arrTest.Add(new MenuItem("Iced Tea", 1.99, MenuCategory.Drink));
            arrTest.Add(new MenuItem("Lemonade", 1.99, MenuCategory.Drink));

            // Add items to the system's menu
            foreach (MenuItem item in arrTest)
            {
               GlobalData.MenuOrderingSystem.AddToMenu(item);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            frmOrder theOrderForm = new frmOrder();
            theOrderForm.ShowDialog();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmViewOrders theViewOrdersForm = new frmViewOrders();
            theViewOrdersForm.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmModifyMenu theModifyMenuForm = new frmModifyMenu();
            theModifyMenuForm.ShowDialog();
        }
    }
}
