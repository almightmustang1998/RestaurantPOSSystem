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
/*
 * this code generates and displays the bill for a specific order, including item descriptions and prices, as well as calculating and displaying the subtotal, tax, and total cost. 
 */
namespace OrderingSystem
{
    public partial class frmBill : Form
    {
        public ulong orderNumber;
        public int id = -1;
        
        public frmBill()
        {
            InitializeComponent();
        }


        private void frmBill_Load(object sender, EventArgs e)
        {
            Order order = new Order();
            List<int> itemsInOrder = OrderDB.GetItemsInOrder(id);
            for(int i = 0; i < itemsInOrder.Count; i++)
            {
                MenuItem item = MenuItemDB.getMenuItemByID(itemsInOrder[i]);
                order.Add(item);
                lstOrder.Items.Add(item.Description);
                lstOrder.Items[i].SubItems.Add(item.Price.ToString("C"));
            }

            int footerRow = lstOrder.Items.Count + 1;
            double totalCost = order.Cost;
            double tax = order.Cost * GlobalData.SALES_TAX;

            lstOrder.Items.Add(" ");

            lstOrder.Items.Add("Sub Total");

            lstOrder.Items[footerRow].SubItems.Add(totalCost.ToString("C"));

            lstOrder.Items.Add("Tax");
            lstOrder.Items[footerRow + 1].SubItems.Add(tax.ToString("C"));

            lstOrder.Items.Add("Total");

            lstOrder.Items[footerRow + 2].SubItems.Add((tax + totalCost).ToString("C"));



        }

        public void setID(int orderID)
        {
            id = orderID;
        }

    }
}
