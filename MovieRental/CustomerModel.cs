using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MovieRental
{
    class Customer
    {        
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string FileName { get; set; }
        public bool Suspended { get; set; }
    }

    class CustomerModel
    {


        SqlDataReader reader;
        



        internal Customer SearchByID(int customerID)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString = @"SELECT * FROM CUSTOMER_INFO WHERE CUSTOMER_ID = @CUSTOMER_ID";
            var connection = new SqlConnection(connectionString);

            Customer customer = new Customer();
            customer.ID = customerID;



            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = queryString;
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ID", customerID);
                    reader = cmd2.ExecuteReader();

                    while (reader.Read())
                    {
                        customer.FirstName  = (reader["CUSTOMER_FName"].ToString());
                        customer.LastName   = (reader["CUSTOMER_LNAME"].ToString());
                        customer.Address    = (reader["CUSTOMER_ADDRESS1"].ToString());
                        customer.City       = (reader["CUSTOMER_CITY"].ToString());
                        customer.State      = (reader["CUSTOMER_STATE"].ToString());
                        customer.Zip        = (reader["CUSTOMER_ZIP"].ToString());
                        customer.Email      = (reader["CUSTOMER_EMAIL"].ToString());
                        customer.Suspended  = bool.Parse(reader["SUSPENDED"].ToString());

                    }

                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }

            return customer;
        }

        internal Customer SearchByName(string custFname, string custLname)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString = @"SELECT * FROM CUSTOMER_INFO WHERE CUSTOMER_FNAME = @FIRSTNAME AND CUSTOMER_LNAME = @LASTNAME";
            var connection = new SqlConnection(connectionString);

            Customer customer = new Customer();

            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = queryString;
                    cmd2.Parameters.AddWithValue("@FIRSTNAME", custFname);
                    cmd2.Parameters.AddWithValue("@LASTNAME", custLname);
                    reader = cmd2.ExecuteReader();

                    while (reader.Read())
                    {
                        customer.ID = int.Parse(reader["CUSTOMER_ID"].ToString());
                        customer.FirstName = (reader["CUSTOMER_FName"].ToString());
                        customer.LastName = (reader["CUSTOMER_LNAME"].ToString());
                        customer.Address = (reader["CUSTOMER_ADDRESS1"].ToString());
                        customer.City = (reader["CUSTOMER_CITY"].ToString());
                        customer.State = (reader["CUSTOMER_STATE"].ToString());
                        customer.Zip = (reader["CUSTOMER_ZIP"].ToString());
                        customer.Email = (reader["CUSTOMER_EMAIL"].ToString());
                        customer.Suspended = bool.Parse(reader["SUSPENDED"].ToString());

                    }

                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }

            return customer;
        }

        internal void UpdateCustomer(Customer customer)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            
            string queryString = @"UPDATE  CUSTOMER_INFO set 
                                    CUSTOMER_FNAME = @CUSTOMER_FNAME,
                                    CUSTOMER_LNAME = @CUSTOMER_LNAME,
                                    CUSTOMER_ADDRESS1 = @CUSTOMER_ADDRESS1,
                                    CUSTOMER_CITY = @CUSTOMER_CITY,
                                    CUSTOMER_STATE = @CUSTOMER_STATE,
                                    CUSTOMER_ZIP = @CUSTOMER_ZIP,
                                    CUSTOMER_EMAIL = @CUSTOMER_EMAIL,
                                    SUSPENDED  = @SUSPENDED
                                    WHERE CUSTOMER_ID = @CUSTOMER_ID";


            using (var connection = new SqlConnection(connectionString))
            {


                connection.Open();
                SqlCommand cmd2 = new SqlCommand(queryString, connection);
                 try
                {
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ID", customer.ID );
                    cmd2.Parameters.AddWithValue("@CUSTOMER_FNAME", customer.FirstName);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_LNAME", customer.LastName);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ADDRESS1", customer.Address);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_CITY", customer.City);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_STATE", customer.State);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ZIP", customer.Zip);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_EMAIL", customer.Email);
                    cmd2.Parameters.AddWithValue("@SUSPENDED", customer.Suspended);

                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Customer " + customer.ID + " was successfully updated.");
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();

                }
            }
        }
        internal void AddCustomer(Customer customer)
        {


            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;            
            string queryString = @"Insert into CUSTOMER_INFO (CUSTOMER_ID,CUSTOMER_FNAME,CUSTOMER_LNAME,CUSTOMER_ADDRESS1,CUSTOMER_CITY,CUSTOMER_STATE,CUSTOMER_ZIP,CUSTOMER_EMAIL)
         values(@CUSTOMER_ID, @CUSTOMER_FNAME, @CUSTOMER_LNAME, @CUSTOMER_ADDRESS1, @CUSTOMER_CITY, @CUSTOMER_STATE, @CUSTOMER_ZIP, @CUSTOMER_EMAIL)";


            using (var connection = new SqlConnection(connectionString))
            {


                connection.Open();
                SqlCommand cmd2 = new SqlCommand();
                

                try
                {
                    cmd2 = new SqlCommand(queryString, connection);

                    cmd2.Parameters.AddWithValue("@CUSTOMER_ID", customer.ID);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_FNAME", customer.FirstName);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_LNAME", customer.LastName);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ADDRESS1", customer.Address);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_CITY", customer.City);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_STATE", customer.State);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ZIP", customer.Zip);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_EMAIL", customer.Email);

                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Customer " + customer.ID + " was successfully added.");
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();

                }
            }
        }
    }
}
