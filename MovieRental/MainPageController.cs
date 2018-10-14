using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net.Mail;

namespace MovieRental
{
    class MainPageController
    {
        MovieModel movieModel = new MovieModel();
        CustomerModel customermodel = new CustomerModel();
        int customerID;
        string custFname;
        string custLname;
        string custAddress;
        string custCity;
        string custState;
        string custZip;
        string custEmail;

        

        public void exitApp()
        {
            Application.Exit();
        }
        
        public void loadCustomer()
        {            
            movieModel.loadCustomer();
        }

        internal void loadMovieInfo()
        {
            movieModel.loadMovieInfo();
        }

        internal void loadRentalInfo()
        {
            movieModel.loadRentalInfo();
        }

        public bool finishLoadingData()
        {
            bool click;
            click = movieModel.finishLoadingData();
            return click;
        }

        
        public void addCustomer(int id, String fname, String lname, String address, String city, String state, String zip, String email)
        {
            
            Customer customer = new Customer()
            {
                ID = id,
                FirstName = fname,
                LastName = lname,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                Email = email
            };
            
            

            if (id<=0 || fname == "" || lname == "" || address == "" || city == "" || state == "" || zip == "")
            {
                MessageBox.Show("ID, First Name, Last Name, Address, City, State, and Zip are required. Customer was not added.");
            }
            else if (!email.Equals("") && !IsValidEmail(email))
            {
                MessageBox.Show("Please verify the email address. Customer was not added.");
            }

            else
            {
                customermodel.AddCustomer(customer);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
               
            }

            catch (Exception e)
            {
                return false;
            }
        }

        internal int newID(string cID)
        {
            int newNumber = 0;
            newNumber = movieModel.newID(cID);           
            return newNumber;        
        }

        internal Customer SearchByID(int newCID)
        {
          Customer customer = customermodel.SearchByID(newCID);            
            return customer;
        }

        internal void UpdateCustomer(Customer customer)
        {
            if (!customer.Email.Equals("") && !IsValidEmail(customer.Email))
            {
                MessageBox.Show("Please verify the email address. Customer information was not updated.");
            }
            else
            {

                customermodel.UpdateCustomer(customer);
            }
        }

        internal Customer SearchByName(string custFNameTxtBx, string custLNameTxtBx)
        {
            custFname = custFNameTxtBx;
            custLname = custLNameTxtBx;

            Customer customer = customermodel.SearchByName(custFname,custLname);
            return customer;
            
        }

        internal void saveFileRentalHistory()
        {
            movieModel.saveFileRentalHistory();
        }

        internal void movieList()
        {
            movieModel.movieList();
        }

        internal void saveClientList()
        {
            movieModel.saveClientList();
        }
    }
}
