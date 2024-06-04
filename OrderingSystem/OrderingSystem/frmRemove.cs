using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this code allows items to be removed from orders
namespace OrderingSystem
{
    
    public partial class frmRemove : Form
    {
        int orderID = -1;
        public frmRemove()
        {
            InitializeComponent();
        }
        public void load()
        {
            lvItems.Items.Clear();
            Order order = new Order();
            List<string> itemsInOrder = OrderDB.GetItemsInOrderAndProgress(orderID);
            for (int i = 0; i < itemsInOrder.Count; i++)
            {
                String[] namesList = itemsInOrder[i].Split(',');
                int MenuID = int.Parse(namesList[0]);
                int ItemID = int.Parse(namesList[2]);
                MenuItem item = MenuItemDB.getMenuItemByID(MenuID);
                lvItems.Items.Add(ItemID.ToString());
                lvItems.Items[i].SubItems.Add(orderID.ToString());
                lvItems.Items[i].SubItems.Add(MenuID.ToString());
                lvItems.Items[i].SubItems.Add(item.Description);
            }
        }
        public void setOrderID(int ID)
        {
            orderID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {           
                this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in lvItems.SelectedItems)
            {
                int ItemID = int.Parse(item.SubItems[0].Text);
                OrderDB.RemoveItemFromOrder(ItemID);
                Order order = new Order();
                List<int> itemsInOrder = OrderDB.GetItemsInOrder(orderID);
                for (int i = 0; i < itemsInOrder.Count; i++)
                {
                    MenuItem items = MenuItemDB.getMenuItemByID(itemsInOrder[i]);
                    order.Add(items);
                }
                double totalCost = order.Cost;
                OrderDB.OrderUpdateCost(orderID, totalCost);
                load();
                
                }
            }
        

        private void frmRemove_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
