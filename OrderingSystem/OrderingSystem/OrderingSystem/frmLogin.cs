using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace OrderingSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
               //try to get role from database
               GlobalData.role = UserDB.Login(txtUsername.Text, txtPassword.Text);

                //if the role is not null, show the appropriate menu
                if (GlobalData.role != null)
                {
                    frmMainMenu mainMenu = new frmMainMenu();

                    mainMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
