using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this code takes care of modifications done to the menu 
namespace OrderingSystem
{
    public partial class frmModifyMenu : Form
    {
        //holds value of item selected in DGV
        int id = -1;

        public frmModifyMenu()
        {
            InitializeComponent();
        }

        private void btnAddToMenu_Click(object sender, EventArgs e)
        {
            MenuItem item = new MenuItem();
            double price = 0;
            
            if (double.TryParse(txtPrice.Text, out price) &&
                double.Parse(txtPrice.Text) > 0)
            {
                if (txtDesc.Text != "")
                {
                    item.Price = price;
                    item.Category = (MenuCategory)cboCategory.SelectedIndex;
                    item.Description = txtDesc.Text;
                    item.MenuType = (MenuType)cmboBoxMealType.SelectedIndex;
                    string url = txtBoxURL.Text;

                    //adds item to database
                    MenuItemDB.AddItemToMenu(item, url);

                    // Use the system from the GlobalData class
                    GlobalData.MenuOrderingSystem.AddToMenu(item);

                    // Reset the form's controls
                    cboCategory.SelectedIndex = -1;
                    txtDesc.Text = "";
                    txtPrice.Text = "";
                    txtBoxURL.Text = "";
                    MessageBox.Show("The item was successfully added to the menu.", "Menu Entry Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enter a description for the item.", "Invalid Input",
                                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else 
            {
                MessageBox.Show("Enter a valid price for the item.", "Invalid Input", 
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cboCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvCategorizedItems.DataSource = MenuItemDB.ViewItemsByCategory(cboCategoryList.Text);

            //hide id column
           dgvCategorizedItems.Columns["ID"].Visible = false;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {

                try
                {
                    MenuItemDB.DeleteMenuItem(id);
                    MessageBox.Show("Succesfully Deleted Item from Menu");

                    dgvCategorizedItems.DataSource = MenuItemDB.ViewItemsByCategory(cboCategoryList.Text);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
                MessageBox.Show("Please select an Item to delete");

        }



        private void dgvCategorizedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategorizedItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //gets selected id
                id = (int)dgvCategorizedItems.Rows[e.RowIndex].Cells[0].Value;
            }
            
            catch(Exception ex)
            {
                if (ex is System.IndexOutOfRangeException || ex is System.InvalidCastException)
                {
                    MessageBox.Show("Please do not click the last row.. no data there");
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Input Validate later with another method later
            //get the checked textboxes
            List<TextBox> txt = checkTextBoxes();


            //if the list of textboxes is not empty
            if (txt.Count != 0)
            {
                //go through txt List 
                for (int i = 0; i < txt.Count; i++)
                {
                    //if the textbox name has Price
                    if (txt[i].Name.Contains("Price"))
                    {
                        MenuItemDB.ModifyPrice(id, txt[i].Text);
                    }
                    //if the textbox name has description
                    if (txt[i].Name.Contains("Description"))
                    {
                        MenuItemDB.ModifyDescription(id, txt[i].Text);
                    }
                    //checking for Category
                    if (txt[i].Name.Contains("Category"))
                    {
                       MenuItemDB.ModifyCategory(id, txt[i].Text);
                    }
                    //checking for MealType
                    if (txt[i].Name.Contains("MealType"))
                    {
                        MenuItemDB.ModifyMealType(id, txt[i].Text);

                    }
                    //checking for image url
                    if (txt[i].Name.Contains("ImageURL"))
                    {
                        MenuItemDB.ModifyImageURL(id, txt[i].Text);

                    }
                }

                MessageBox.Show("Succesfully Modified");
                dgvCategorizedItems.DataSource = MenuItemDB.ViewItemsByCategory(cboCategoryList.Text);
            }

        }
        private List<TextBox> checkTextBoxes()
        {
            //add all textboxes to list
            List<TextBox> textboxes = new List<TextBox>();
            textboxes.Add(txtModifyPrice);
            textboxes.Add(txtModifyDescription);
            textboxes.Add(txtModifyCategory);
            textboxes.Add(txtModifyMealType);
            textboxes.Add(txtBoxModifyImageURL);

            //list holds modified textboxes
            List<TextBox> modified = new List<TextBox>();

            //go through list of textboxes
            foreach (TextBox txtBox in textboxes)
            {
                //make sure string is not empty
                if (txtBox.Text != "")
                {
                    //add textbox to modified list
                    modified.Add(txtBox);
                }

            }

            return modified;
        }
    }
}
