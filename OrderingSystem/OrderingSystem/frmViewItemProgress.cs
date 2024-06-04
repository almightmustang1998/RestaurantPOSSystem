using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this code updates the progress of an item that has been ordered. for example, an item may be in the process of getting cooked or completed 
namespace OrderingSystem
{
    public partial class frmViewItemProgress : Form
    {
        int orderID = -1;
        public frmViewItemProgress()
        {
            InitializeComponent();
        }

        private void frmViewItemProgress_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            lvProgress.Items.Clear();
            Order order = new Order();
            List<string> itemsInOrder = OrderDB.GetItemsInOrderAndProgress(orderID);
            for (int i = 0; i < itemsInOrder.Count; i++)
            {
                String[] namesList = itemsInOrder[i].Split(',');
                int MenuID = int.Parse(namesList[0]);
                string progress = namesList[1];
                int ItemID = int.Parse(namesList[2]);
                MenuItem item = MenuItemDB.getMenuItemByID(MenuID);
                lvProgress.Items.Add(ItemID.ToString());
                lvProgress.Items[i].SubItems.Add(orderID.ToString());
                lvProgress.Items[i].SubItems.Add(MenuID.ToString());
                lvProgress.Items[i].SubItems.Add(item.Description);
                lvProgress.Items[i].SubItems.Add(progress);
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

        private void btnCooking_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvProgress.SelectedItems)
            {
                int ItemID = int.Parse(item.SubItems[0].Text);
                string currentProgress = item.SubItems[4].Text;
                if (item.SubItems[4].Text == "Cooking")
                {
                    MessageBox.Show("Item is already cooking");
                }
                else if(item.SubItems[4].Text == "Cooked"){
                    MessageBox.Show("Item is already cooked");
                }
                else
                {
                    OrderDB.OrderUpdateProgress(ItemID, "Cooking");
                    load();
                }
            }
        }

        private void btnCooked_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvProgress.SelectedItems)
            {
                int ItemID = int.Parse(item.SubItems[0].Text);
                string currentProgress = item.SubItems[4].Text;
                if (item.SubItems[4].Text == "Not Started")
                {
                    MessageBox.Show("Item needs to be cooking before it can be called cooked");
                }
                else if (item.SubItems[4].Text == "Cooked")
                {
                    MessageBox.Show("Item is already cooked");
                }
                else
                {
                    OrderDB.OrderUpdateProgress(ItemID, "Cooked");
                    load();
                }
            }
        }
    }
}
