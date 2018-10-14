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
    public partial class Employee : Form
    {
        EmployeeController employees = new EmployeeController();
        public Employee()
        {
            InitializeComponent();
        }

        private void addEmpbtn_Click(object sender, EventArgs e)
        {
            empIDTxtBx.Clear();
            if (newPW1TxtBx.Text.Equals(newPW2TxtBx.Text))
            {

                employees.addEmployee(newPW1TxtBx.Text, empFNTxtBx.Text, empLNTxtBx.Text, secretQTxtBx.Text, answerTxtBx.Text);
                this.employeeTableAdapter1.Fill(this.mOVIESDataSet.EMPLOYEE);
            }
            else
            {

                MessageBox.Show("Passwords do not match. Make sure the password was typed correctly.");
            }
        }

        private void mR2Btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rentForm rentalInfo = new rentForm();
            rentalInfo.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cM2Btn_Click(object sender, EventArgs e)
        {
            MainPageView mainpage = new MainPageView();
            mainpage.Visible = true;
            mainpage.loadFilePanel.Visible = false;
            mainpage.mainPnl.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int newEID = employees.newID(empIDTxtBx.Text);


            employees.deleteEmployee(newEID);
            this.employeeTableAdapter1.Fill(this.mOVIESDataSet.EMPLOYEE);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            
            this.employeeTableAdapter1.Fill(this.mOVIESDataSet.EMPLOYEE);
        }

        private void empClearBtn_Click(object sender, EventArgs e)
        {

            empIDTxtBx.Clear();
            empFNTxtBx.Clear();
            empLNTxtBx.Clear();
            oldPWTxtBx.Clear();
            newPW1TxtBx.Clear();
            newPW2TxtBx.Clear();            
            answerTxtBx.Clear();
            oldPW2TxtBx.Clear();
            try
            {
                var itemIndex = secretQTxtBx.SelectedIndex;
                var item = secretQTxtBx.Items[itemIndex];
                secretQTxtBx.Items.RemoveAt(itemIndex);
            }
            catch (Exception z)
            {

            }
        }

        private void updateEmpBtn_Click(object sender, EventArgs e)
        {
            int newEID = employees.newID(empIDTxtBx.Text);

            if (newPW1TxtBx.Text.Equals(newPW2TxtBx.Text) && oldPWTxtBx.Text.Equals(oldPW2TxtBx.Text) && !answerTxtBx.Text.Equals("")
                && !secretQTxtBx.Text.Equals(""))
            {

                employees.update(newEID,newPW1TxtBx.Text,secretQTxtBx.Text,answerTxtBx.Text);
                this.employeeTableAdapter1.Fill(this.mOVIESDataSet.EMPLOYEE);
            }
            else
            {

                MessageBox.Show("Old password does not match or new passwords do not match. Make sure the password was typed correctly.");
                if (answerTxtBx.Text.Equals("") || secretQTxtBx.Text.Equals(""))
                {
                    MessageBox.Show("Secret Question and answer are required.");

                }
            }




        }


        private void allEmpGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (allEmpGrid.Rows.Count > 0)
            {

                if (this.allEmpGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.allEmpGrid.SelectedRows[0];
                    empIDTxtBx.Text = row.Cells[0].Value.ToString();
                    empFNTxtBx.Text = row.Cells[1].Value.ToString();
                    empLNTxtBx.Text = row.Cells[2].Value.ToString();
                    oldPW2TxtBx.Text = row.Cells[3].Value.ToString();
                }
            }



        }

        private void allEmpGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.allEmpGrid.Rows[e.RowIndex];
                empIDTxtBx.Text = row.Cells[0].Value.ToString();
                empFNTxtBx.Text = row.Cells[1].Value.ToString();
                empLNTxtBx.Text = row.Cells[2].Value.ToString();
                oldPW2TxtBx.Text = row.Cells[3].Value.ToString();

            }
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
