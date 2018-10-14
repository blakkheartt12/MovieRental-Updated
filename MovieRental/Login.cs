using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class  Login : Form
    {

        LoginController c1 = new LoginController();


        public Login()
        {
            InitializeComponent();
            
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            bool status = false;

            
            string userID = userIdTxtBx.Text;
            string password = passwordTxtBx.Text;

            if (adminLbl.Visible)
            {
                if (userID.ToLowerInvariant() == "admin" && password.ToLowerInvariant() == "admin")
                {
                    status = true;
                    MessageBox.Show("Please add a new employee to disable the default login username and password. The Employee" +
                        " Menu can be accessed by clicking on the Employee Menu option on the menu strip. ");
                    c1.loadPanel2();
                }
                else {

                    MessageBox.Show("Username or password is not correct. Please check username and password.");
                }

            }
            else {
                status = c1.login(userID, password);

            }
            if (status)
            {
                this.Hide();

            }


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            c1.exitApp();
        }

        private void passwordTxtBx_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                LoginBtn.PerformClick();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            EmployeeController employee = new EmployeeController();
            if (employee.getUserCount() == 0) {

                adminLbl.Visible = true;

            }
        }
    }
}
