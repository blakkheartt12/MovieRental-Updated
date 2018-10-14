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
    public partial class MainPageView : Form


    {
        MainPageController mainPage = new MainPageController();


        public MainPageView()
        {

            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cUSTOMER_INFOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMER_INFOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mOVIESDataSet);

        }


        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadCustomerBtn_Click(object sender, EventArgs e)
        {
            mainPage.loadCustomer();
        }

        private void customerInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainPage.loadCustomer();
        }

        private void loadRentalDataBtn_Click(object sender, EventArgs e)
        {
            mainPage.loadMovieInfo();
        }

        private void rentalInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainPage.loadMovieInfo();
        }

        private void loadRentalDataBtn_Click_1(object sender, EventArgs e)
        {
            mainPage.loadRentalInfo();
        }

        private void rentalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPage.loadRentalInfo();
        }

        private void finishLoadingDataBtn_Click(object sender, EventArgs e)
        {

            bool click;
            click = mainPage.finishLoadingData();
            if (click)
            {
                loadFilePanel.Visible = false;
                mainPnl.Visible = true;
            }
        }

        private void addClientbtn_Click(object sender, EventArgs e)
        {
            //string custID = custIDtxtBx.Text;
            int newCID = mainPage.newID(custIDtxtBx.Text);

            mainPage.addCustomer(newCID, custFNameTxtBx.Text, custLNameTxtBx.Text, custAddrTxtBx.Text, custCityTxtBx.Text, stateComboBx.Text, custZipTxtBx.Text, custEmailTxtBx.Text);
            this.cUSTOMER_INFOTableAdapter.Fill(this.mOVIESDataSet.CUSTOMER_INFO);
        }

        private void finishLoadingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool click;
            click = mainPage.finishLoadingData();
            if (click)
            {
                loadFilePanel.Visible = false;
                mainPnl.Visible = true;
            }
        }

        private void searchIDBtn_Click(object sender, EventArgs e)
        {
            int newCID = mainPage.newID(custIDtxtBx.Text);
            if (newCID <= 0)
            {
                MessageBox.Show("Customer ID cannot be blank, negative or 0. Please enter a valid Customer ID.");
            }
            else
            {
                Customer customer = mainPage.SearchByID(newCID);

                custFNameTxtBx.Text = customer.FirstName;
                custLNameTxtBx.Text = customer.LastName;
                custAddrTxtBx.Text = customer.Address;
                custCityTxtBx.Text = customer.City;
                stateComboBx.Text = customer.State;
                custZipTxtBx.Text = customer.Zip;
                custEmailTxtBx.Text = customer.Email;
                deletedCheckBx.Checked = customer.Suspended;

                if (custFNameTxtBx.Text.Equals(null) || custFNameTxtBx.Text.Equals(""))
                {
                    MessageBox.Show("Customer ID does not exist");
                }
            }

            

        }

        private void allClientBtn_Click(object sender, EventArgs e)
        {
            bool visibility = !allClientsGrid2.Visible;
            allClientsGrid2.Visible = visibility;
            this.cUSTOMER_INFOTableAdapter.Fill(this.mOVIESDataSet.CUSTOMER_INFO);
            allClientBtn.Visible = false;
            hideCLBtn.Visible = true;
        }

        private void MainPageView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIESDataSet.CUSTOMER_INFO' table. You can move, or remove it, as needed.
            this.cUSTOMER_INFOTableAdapter.Fill(this.mOVIESDataSet.CUSTOMER_INFO);

        }

        private void cUSTOMER_INFOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMER_INFOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mOVIESDataSet);

        }


        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            int newCID = mainPage.newID(custIDtxtBx.Text);
            if (custIDtxtBx.Text == "")
            {
                MessageBox.Show("Customer ID has not been entered. Please select a customer record.");
            }
            else
            {
                Customer customer = new Customer()
                {
                    ID = newCID,
                    FirstName = custFNameTxtBx.Text,
                    LastName = custLNameTxtBx.Text,
                    Address = custAddrTxtBx.Text,
                    City = custCityTxtBx.Text,
                    State = stateComboBx.Text,
                    Zip = custZipTxtBx.Text,
                    Email = custEmailTxtBx.Text,
                    Suspended = deletedCheckBx.Checked

                };


                mainPage.UpdateCustomer(customer);
                this.cUSTOMER_INFOTableAdapter.Fill(this.mOVIESDataSet.CUSTOMER_INFO);
            }
        }
        private void searchNameBtn_Click(object sender, EventArgs e)
        {


            bool nameEnter = false;

            while (nameEnter == false)
            {
                if (custFNameTxtBx.Text.Equals("") || custLNameTxtBx.Text.Equals(""))
                {
                    MessageBox.Show("Either the First Name or Last Name has not been entered. First and Last name both must be entered", "Name Information Misssing");
                    nameEnter = false;
                    return;
                }
                else
                {
                    nameEnter = true;
                }
            }

            Customer customer = mainPage.SearchByName(custFNameTxtBx.Text, custLNameTxtBx.Text);

            //custFNameTxtBx.Text = customer.FirstName;
            //custLNameTxtBx.Text = customer.LastName;
            custIDtxtBx.Text = customer.ID.ToString();
            custAddrTxtBx.Text = customer.Address;
            custCityTxtBx.Text = customer.City;
            stateComboBx.Text = customer.State;
            custZipTxtBx.Text = customer.Zip;
            custEmailTxtBx.Text = customer.Email;
            deletedCheckBx.Checked = customer.Suspended;


        }

        private void movieRentalBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rentForm rentalInfo = new rentForm();
            rentalInfo.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPage.saveClientList();
        }

        private void rentalHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPage.saveFileRentalHistory();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPage.movieList();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            custIDtxtBx.Clear();
            custFNameTxtBx.Clear();
            custLNameTxtBx.Clear();
            custAddrTxtBx.Clear();
            custCityTxtBx.Clear();
            stateComboBx.SelectedIndex = 0;
            custZipTxtBx.Clear();
            custEmailTxtBx.Clear();
            allClientsGrid2.Visible = false;
            deletedCheckBx.Checked = false;
        }

        private void MainPageView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void allCustomerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void allClientsGrid2_SelectionChanged(object sender, EventArgs e)
        {
            if (allClientsGrid2.Visible == true) 
              {
                if (this.allClientsGrid2.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.allClientsGrid2.SelectedRows[0];
                    custIDtxtBx.Text = row.Cells[0].Value.ToString();
                    custFNameTxtBx.Text = row.Cells[1].Value.ToString();
                    custLNameTxtBx.Text = row.Cells[2].Value.ToString();
                    custAddrTxtBx.Text = row.Cells[3].Value.ToString();
                    custCityTxtBx.Text = row.Cells[4].Value.ToString();
                    stateComboBx.Text = row.Cells[5].Value.ToString();
                    custZipTxtBx.Text = row.Cells[6].Value.ToString();
                    custEmailTxtBx.Text = row.Cells[7].Value.ToString();
                    deletedCheckBx.Checked = (bool)row.Cells[8].Value ? true : false;
                }

            }

        }

        private void hideCLBtn_Click(object sender, EventArgs e)
        {
            bool visibility = !allClientsGrid2.Visible;
            allClientsGrid2.Visible = false;
            hideCLBtn.Visible = false;
            allClientBtn.Visible = true;
        }

        private void employeeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employee employee = new Employee();
            employee.Show();
        }
    }
}
