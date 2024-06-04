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
    public partial class frmViewOrders : Form
    {
        public ulong SelectedOrderNumber;

        public frmViewOrders()
        {
            InitializeComponent();
        }

        private void frmViewOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            lstOrders.Items.Clear();

            // Get the list of orders from the system stored in the GlobalData class
            ArrayList orders = GlobalData.MenuOrderingSystem.GetOrders();
            for (int i = 0; i < orders.Count; i++)
            {
                Order objOrder = (Order)orders[i];
                lstOrders.Items.Add(objOrder.OrderNumber.ToString());
                lstOrders.Items[i].SubItems.Add(objOrder.TableNumber);
                lstOrders.Items[i].SubItems.Add(objOrder.OrderDateTime.ToString("t"));
                lstOrders.Items[i].SubItems.Add(objOrder.Cost.ToString("C"));
            }

        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItems.Count > 0)
                SelectedOrderNumber = ulong.Parse(lstOrders.SelectedItems[0].SubItems[0].Text);
            else
                SelectedOrderNumber = 0;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Use the system from the GlobalData class
            if (GlobalData.MenuOrderingSystem.CancelOrder(SelectedOrderNumber) == true)
            {
                LoadOrders();
                MessageBox.Show("The order was cancelled.", "Order Cancellation Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The order could not be cancelled.", "Order Cancellation Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            frmBill billForm = new frmBill();
            billForm.orderNumber = SelectedOrderNumber;
            billForm.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
