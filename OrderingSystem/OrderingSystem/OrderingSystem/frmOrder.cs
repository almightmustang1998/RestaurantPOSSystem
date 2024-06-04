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

namespace OrderingSystem
{
    public partial class frmOrder : Form
    {
        Order newOrder;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadMenu(MenuCategory.None);
        }

        private void picAppetizer_Click(object sender, EventArgs e)
        {
            LoadMenu(MenuCategory.Appetizer);
        }

        private void picEntree_Click(object sender, EventArgs e)
        {
            LoadMenu(MenuCategory.Entree);
        }

        private void picDessert_Click(object sender, EventArgs e)
        {
            LoadMenu(MenuCategory.Dessert);
        }

        private void picBeverage_Click(object sender, EventArgs e)
        {
            LoadMenu(MenuCategory.Drink);
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
                    newOrder.TableNumber = "ToGo";
                else
                    newOrder.TableNumber = txtTable.Text;

                // Use the system from the GlobalData class
                if (GlobalData.MenuOrderingSystem.SubmitOrder(newOrder) == true)
                {
                    MessageBox.Show("The order was submitted.", "Order Submission Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The order submission failed. Please try creating the order again.",
                                    "Order Submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                newOrder = null;
                lstMenu.BackColor = Color.White;
                lstMenu.Items.Clear();
                btnRemoveItem.Enabled = false;
                txtTable.Text = "";
            }

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (newOrder == null)
                newOrder = new Order();

            for (int i = 0; i < lstMenu.SelectedItems.Count; i++)
            {
                MenuItem item = new MenuItem();
                item.Description = lstMenu.SelectedItems[i].SubItems[0].Text;
                item.Price = double.Parse(lstMenu.SelectedItems[i].SubItems[1].Text, NumberStyles.Currency);
                item.Category = (MenuCategory)int.Parse(lstMenu.SelectedItems[i].SubItems[2].Text);

                newOrder.Add(item);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            newOrder = null;
            lstMenu.BackColor = Color.White;
            lstMenu.Items.Clear();
            btnRemoveItem.Enabled = false;
            txtTable.Text = "";
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
                LoadOrder();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            bool removed = false;

            for (int i = 0; i < lstMenu.SelectedItems.Count; i++)
            {
                MenuItem item = new MenuItem();
                item.Description = lstMenu.SelectedItems[i].SubItems[0].Text;
                item.Price = double.Parse(lstMenu.SelectedItems[i].SubItems[1].Text, NumberStyles.Currency);
                item.Category = (MenuCategory)int.Parse(lstMenu.SelectedItems[i].SubItems[2].Text);
                removed = newOrder.Remove(item);
            }

            if (removed == true)
                LoadOrder();

        }

        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            frmViewOrders viewOrderFrom = new frmViewOrders();
            viewOrderFrom.ShowDialog();
            ulong orderNumber = viewOrderFrom.SelectedOrderNumber;

            if (orderNumber != 0)
            {
                // Get the order from system in the GlobalData class
                newOrder = GlobalData.MenuOrderingSystem.GetOrder(orderNumber);
                LoadOrder();

                grpModifyOrder.Visible = true;
                grpNewOrder.Visible = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (newOrder == null)
            {
                MessageBox.Show("The order was empty. Please add items to the order before submitting it.",
                                "Order Submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtTable.Text == "")
                    newOrder.TableNumber = "ToGo";
                else
                    newOrder.TableNumber = txtTable.Text;

                // Use the system from the GlobalData class
                if (GlobalData.MenuOrderingSystem.ChangeOrder(newOrder.OrderNumber, newOrder) == true)
                {
                    MessageBox.Show("The changes to the order were submitted.", "Order Modification Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A problem occurred. No changes were made to the order. Please try again.",
                                    "Order Modification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                newOrder = null;
                lstMenu.BackColor = Color.White;
                lstMenu.Items.Clear();
                btnRemoveItem.Enabled = false;
                txtTable.Text = "";

                grpModifyOrder.Visible = false;
                grpNewOrder.Visible = true; 
            }
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            newOrder = null;
            lstMenu.BackColor = Color.White;
            lstMenu.Items.Clear();

            grpModifyOrder.Visible = false;
            grpNewOrder.Visible = true;
            btnRemoveItem.Enabled = false;
        }

        private void LoadMenu(MenuCategory category)
        {
            btnAddToOrder.Enabled = true;
            btnRemoveItem.Enabled = false;

            lstMenu.Items.Clear();
            lstMenu.BackColor = Color.White;

            if (category != MenuCategory.None)
            {
                // Get the menu items from the system stored in the GlobalData class
                ArrayList items = GlobalData.MenuOrderingSystem.GetMenu(category);

                for (int i = 0; i < items.Count; i++)
                {
                    MenuItem item = (MenuItem)items[i];
                    int value = (int)item.Category;

                    lstMenu.Items.Add(item.Description);
                    lstMenu.Items[i].SubItems.Add(item.Price.ToString("C"));
                    lstMenu.Items[i].SubItems.Add(value.ToString());
                }
            }
                
        }

        private void LoadOrder()
        {
            btnAddToOrder.Enabled = false;
            btnRemoveItem.Enabled = true;

            lstMenu.Items.Clear();

            if (newOrder != null)
            {
                lstMenu.BackColor = Color.LightSteelBlue;

                ArrayList items = newOrder.GetItems();

                for (int i = 0; i < items.Count; i++)
                {
                    MenuItem item = (MenuItem)items[i];
                    int value = (int)item.Category;
                    lstMenu.Items.Add(item.Description);
                    lstMenu.Items[i].SubItems.Add(item.Price.ToString("C"));
                    lstMenu.Items[i].SubItems.Add(value.ToString());
                }

                txtTable.Text = newOrder.TableNumber;
            }

        }

                     
    } // end of Form class
}   // end of namespace
