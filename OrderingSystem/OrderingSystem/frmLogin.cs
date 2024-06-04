using System;
using System.Data.OleDb;
using System.Windows.Forms;
//this code allows users to login
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
               //try to get role from database to direct user to the proper screen as different types of users have different permissions
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
