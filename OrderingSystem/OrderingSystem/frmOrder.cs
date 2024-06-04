using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Globalization;
//this code ties together the logic and view for orders to be put together
namespace OrderingSystem
{
    public partial class frmOrder : Form
    {
        Order newOrder;
        int id = -1;
        int viewOrderID = -1;

        //Variable when coming from View Orders form
        int orderID = -1;
        List<int> allItems = new List<int>();
        List<int> newItems = new List<int>();
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

            if(orderID == -1)
            {
                btnAddCurrentOrder.Visible = false;
                btnSaveChanges.Visible = false;
                btnViewCurrentOrder.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
              allItems =  OrderDB.GetItemsInOrder(orderID);
            }


        }

        private void picAppetizer_Click(object sender, EventArgs e)
        {
            dgvCurrentOrder.Visible = false;
            dgvMenu.Visible = true;
            btnAddToOrder.Enabled = true;
            btnRemoveItem.Enabled = false;
            dgvMenu.DataSource = MenuItemDB.getMenuByTimeandCategory("Appetizer");
            dgvMenu.Columns["ID"].Visible = false;

        }

        private void picEntree_Click(object sender, EventArgs e)
        {
            dgvCurrentOrder.Visible = false;
            dgvMenu.Visible = true;
            btnAddToOrder.Enabled = true;
            btnRemoveItem.Enabled = false;
            dgvMenu.DataSource = MenuItemDB.getMenuByTimeandCategory("Entree");
            dgvMenu.Columns["ID"].Visible = false;
        }

        private void picDessert_Click(object sender, EventArgs e)
        {
            dgvCurrentOrder.Visible = false;
            dgvMenu.Visible = true;
            btnAddToOrder.Enabled = true;
            btnRemoveItem.Enabled = false;
            dgvMenu.DataSource = MenuItemDB.getMenuByTimeandCategory("Dessert");
            dgvMenu.Columns["ID"].Visible = false;
        }

        private void picBeverage_Click(object sender, EventArgs e)
        {
            dgvCurrentOrder.Visible = false;
            dgvMenu.Visible = true;
            btnAddToOrder.Enabled = true;
            btnRemoveItem.Enabled = false;
            dgvMenu.DataSource = MenuItemDB.getMenuByTimeandCategory("Drink");
            dgvMenu.Columns["ID"].Visible = false;
        }
        

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            
            if (newOrder == null)
            {
                MessageBox.Show("The order was empty. Please add items to the order before submitting it.",
                                "Order Submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                if (txtTable.Text == "")
                {
                    //All takeout will be table number 0
                    newOrder.TableNumber = GlobalData.TAKEOUT;
                }
                else
                {
                    newOrder.TableNumber = txtTable.Text;
                }

                newOrder.OrderDateTime = DateTime.Now;
                OrderDB.AddOrder(newOrder);
               int newOrderID = OrderDB.findOrderID(newOrder);
               OrderDB.AddOrderItems(newOrderID, newOrder);
                MessageBox.Show("Order Submitted");
                newOrder = null;
                dgvCurrentOrder.DataSource = null;
                btnRemoveItem.Enabled = false;
                txtTable.Text = "";
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            
            
            if (newOrder == null)
                newOrder = new Order();

            if (id == -1)
            {
                MessageBox.Show("Need to select Item");
            }
            else
            {
                MenuItem item = MenuItemDB.getMenuItemByID(id);

                newOrder.Add(item);
            }
            
            
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            
            newOrder = null;
            btnRemoveItem.Enabled = false;
            txtTable.Text = "";
            dgvCurrentOrder.DataSource = null;
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (newOrder == null)
            {
                MessageBox.Show("The current order is empty", "Current Order",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvMenu.Visible = false;
                dgvCurrentOrder.Visible = true;
                LoadOrder();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            
            bool removed = false;

            
                MenuItem item = new MenuItem();
            item.MenuType = (MenuType)Enum.Parse(typeof(MenuType), dgvCurrentOrder.Rows[viewOrderID].Cells[0].Value.ToString());
            item.Description = dgvCurrentOrder.Rows[viewOrderID].Cells[1].Value.ToString();
            item.Price = double.Parse(dgvCurrentOrder.Rows[viewOrderID].Cells[2].Value.ToString());
            item.Category = (MenuCategory)Enum.Parse(typeof(MenuCategory), dgvCurrentOrder.Rows[viewOrderID].Cells[3].Value.ToString());
            removed = newOrder.Remove(item);
            

            if (removed == true)
                LoadOrder();
            

        }

        private void LoadOrder()
        {
            
            btnAddToOrder.Enabled = false;
            btnRemoveItem.Enabled = true;

            dgvCurrentOrder.DataSource = newOrder.GetItems();
           

        }

        private void dgvMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
              
                
                id = (int)dgvMenu.Rows[e.RowIndex].Cells[0].Value;
                string imageUrl = dgvMenu.Rows[e.RowIndex].Cells[5].Value.ToString();
                SetImage.CheckAndSetImage(ref pictureBoxFrmOrder, imageUrl);
            }

            catch (Exception ex)
            {
                if (ex is System.IndexOutOfRangeException || ex is System.InvalidCastException)
                {
                    MessageBox.Show("Please do not click the last row.. no data there");
                }
            }
        }

        private void dgvCurrentOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewOrderID = e.RowIndex;
            
        }

        public void getOrderID(int ID)
        {
            orderID = ID;
            btnAddToOrder.Visible = false;
            btnCancelOrder.Visible = false;
            btnRemoveItem.Visible = false;
            btnViewOrder.Visible = false;
            btnSubmitOrder.Visible = false;
            lblTable.Visible = false;
            txtTable.Visible = false;
        }

        private void btnViewCurrentOrder_Click(object sender, EventArgs e)
        {
            dgvCurrentOrder.Rows.Clear();
            dgvMenu.Visible = false;
            dgvCurrentOrder.Visible = true;
            dgvCurrentOrder.Columns.Add("Menu", "MenuType");
            dgvCurrentOrder.Columns.Add("Description", "Description");
            dgvCurrentOrder.Columns.Add("Price", "Price");
            dgvCurrentOrder.Columns.Add("Category", "Category");
            for (int i = 0; i < allItems.Count; i++)
            {
               MenuItem item = MenuItemDB.getMenuItemByID(allItems[i]);
                dgvCurrentOrder.Rows.Add(item.MenuType, item.Description, item.Price, item.Category);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCurrentOrder_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Need to select Item");
            }
            else
            {
                newItems.Add(id);
                allItems.Add(id);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < newItems.Count; i++)
            {
                OrderDB.AddNewItemsToOrder(orderID, newItems[i]);
            }
            OrderDB.MakeOrderPriority(orderID);


            Order order = new Order();
            for (int i = 0; i < allItems.Count; i++)
            {
                MenuItem items = MenuItemDB.getMenuItemByID(allItems[i]);
                order.Add(items);
            }
            double totalCost = order.Cost;
            OrderDB.OrderUpdateCost(orderID, totalCost);



            this.Close();
        }
    } // end of Form class
}   // end of namespace
