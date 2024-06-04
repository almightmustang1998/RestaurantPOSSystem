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
    public partial class frmBill : Form
    {
        public ulong orderNumber;

        public frmBill()
        {
            InitializeComponent();
        }


        private void frmBill_Load(object sender, EventArgs e)
        {                       
            // Get the system from the GlobalData class
            Order theOrder = GlobalData.MenuOrderingSystem.GetOrder(orderNumber);

            if (theOrder != null)
            {
                ArrayList orderedItems = theOrder.GetItems();

                for (int i = 0; i < orderedItems.Count; i++)
                {
                    MenuItem item = (MenuItem)orderedItems[i];

                    lstOrder.Items.Add(item.Description);
                    lstOrder.Items[i].SubItems.Add(item.Price.ToString("C"));
                }

                int footerRow = lstOrder.Items.Count + 1;
                double total = theOrder.Cost;
                lstOrder.Items.Add("");                     // add an empty line to the list
                lstOrder.Items.Add("Sub Total:");
                lstOrder.Items[footerRow].SubItems.Add(total.ToString("C"));

                double tax = total * GlobalData.SALES_TAX;
                lstOrder.Items.Add("Tax:");
                lstOrder.Items[footerRow + 1].SubItems.Add(tax.ToString("C"));

                total = total + tax;
                lstOrder.Items.Add("Total:");
                lstOrder.Items[footerRow + 2].SubItems.Add(total.ToString("C"));
            }
        }
    }
}
