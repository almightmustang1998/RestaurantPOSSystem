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
//this allows the servers or the kitchen staff to update orders 
namespace OrderingSystem
{
    public partial class frmViewOrders : Form
    {
        public ulong SelectedOrderNumber;
        string view = "Kitchen";
        int id = -1;
        

        public frmViewOrders()
        {
            InitializeComponent();
        }

        private void frmViewOrders_Load(object sender, EventArgs e)
        {
            if(GlobalData.role == "Kitchen")
            {
                btnCancel.Visible = false;
                btnSwitch.Visible = false;
                btnViewBill.Visible = false;
                btnRemove.Visible = false;
                btnAddItems.Visible = false;
                btnPriority.Visible = false;
            }
            else if (GlobalData.role == "Server")
            {
                btnViewOrderProgress.Visible = false;
                btnSwitch.Visible = false;
                btnOrderComplete.Visible = false;
                btnRemove.Visible = false;
                btnPriority.Visible = false;
                view = "Server";
                lblKitchen.Text = "Server View";
            }
            LoadOrders();
        }

        private void LoadOrders()
        {
            if (view == "Kitchen")
            {
                dgvViewOrders.DataSource = OrderDB.GetOrdersNotDone("Not Finished");
            }

            else {
                dgvViewOrders.DataSource = OrderDB.GetOrdersNotDone("Finished");
            }

        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OrderDB.CancelOrder(id);
            LoadOrders();
            MessageBox.Show("Order Cancelled");
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Need to select an order");
            }
            else
            {
                frmBill billForm = new frmBill();
                billForm.setID(id);
                billForm.ShowDialog();
            }
        }
        

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViewOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = (int)dgvViewOrders.Rows[e.RowIndex].Cells[0].Value;
            }

            catch (Exception ex)
            {
                if (ex is System.IndexOutOfRangeException || ex is System.InvalidCastException)
                {
                    MessageBox.Show("Please do not click the last row.. no data there");
                }
            }
        }

        private void btnOrderComplete_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Need to select an order");
            }
            else
            {
                OrderDB.OrderUpdate(id);
                LoadOrders();
                MessageBox.Show("Order Complete");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (view == "Kitchen")
            {
                view = "Server";
                lblKitchen.Text = "Server View";
            }
            else
            {
                view = "Kitchen";
                lblKitchen.Text = "Kitchen View";
            }

            LoadOrders();
        }

        private void btnViewOrderProgress_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Need to select an order");
            }
            else
            {
                frmViewItemProgress itemProgress = new frmViewItemProgress();
                itemProgress.setOrderID(id);
                itemProgress.ShowDialog();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Need to select an order");
            }
            else
            {
                frmRemove remove = new frmRemove();
                remove.setOrderID(id);
                remove.ShowDialog();
                LoadOrders();
            }
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Need to select an order");
            }
            else
            {
                OrderDB.MakeOrderPriority(id);
                LoadOrders();
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.getOrderID(id);
            order.ShowDialog();
            LoadOrders();
        }
    }
}
