using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieRental
{
    class Employees
    {
        public int ID { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecretQuestion { get; set; }
        public string Answer { get; set; }         
    }

    class EmployeeAdd
    {
        
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecretQuestion { get; set; }
        public string Answer { get; set; }
    }




    class EmployeeModel
    {


        SqlDataReader reader;


        internal void AddEmployee(EmployeeAdd employees)
        {


            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString = @"Insert into EMPLOYEE (PASSWORD,EMPLOYEE_FNAME,EMPLOYEE_LNAME,SECRET_QUESTION,ANSWER)
         values(@PASSWORD, @EMPLOYEE_FNAME, @EMPLOYEE_LNAME, @SECRET_QUESTION, @ANSWER)";


            using (var connection = new SqlConnection(connectionString))
            {


                connection.Open();
                SqlCommand cmd2 = new SqlCommand();


                try
                {
                    cmd2 = new SqlCommand(queryString, connection);

                    cmd2.Parameters.AddWithValue("@PASSWORD", employees.password);
                    cmd2.Parameters.AddWithValue("@EMPLOYEE_FNAME", employees.FirstName);
                    cmd2.Parameters.AddWithValue("@EMPLOYEE_LNAME", employees.LastName);
                    cmd2.Parameters.AddWithValue("@SECRET_QUESTION", employees.SecretQuestion);
                    cmd2.Parameters.AddWithValue("@ANSWER", employees.Answer);


                    cmd2.ExecuteNonQuery();
                    MessageBox.Show(employees.FirstName + " " + employees.LastName + " " + "was successfully added.");
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Emloyee was not added");
                    connection.Close();

                }
            }
        }// end of add employee

        internal void UpdateEmployee(int newEID, string pw, string secret, string a)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString = @"UPDATE EMPLOYEE SET PASSWORD =@PW, 
                                   SECRET_QUESTION = @SECRET, 
                                   ANSWER = @A
                                   WHERE EMPLOYEE_ID =@newEID";

            try
            {
                var connection = new SqlConnection(connectionString);

                connection.Open();
                SqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = queryString;
                cmd2.Parameters.AddWithValue("@newEID",newEID);
                cmd2.Parameters.AddWithValue("@PW",  pw);
                cmd2.Parameters.AddWithValue("@SECRET", secret);
                cmd2.Parameters.AddWithValue("@A", a);

                cmd2.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Password for employee id " + newEID + " has been updated");
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
                MessageBox.Show("An error occured. Password was not changed.");
            }
        }

        internal void DeleteEmployee(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString = @"DELETE FROM EMPLOYEE WHERE EMPLOYEE_ID = @ID";
         
            using (var connection = new SqlConnection(connectionString))
            {


                connection.Open();
                SqlCommand cmd2 = new SqlCommand();


                try
                {
                    cmd2 = new SqlCommand(queryString, connection);

                    cmd2.Parameters.AddWithValue("@ID", id);



                    cmd2.ExecuteNonQuery();
                    MessageBox.Show(id + " " + "was successfully deleted.");
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Emloyee was not deleted");
                    connection.Close();

                }
            }
        }//end of delete employee

        internal int newID(string eID)
        {
            int newNumber;
            try
            {
                newNumber = int.Parse(eID);
            }
            catch (Exception e)
            {
                newNumber = -1;
            }
            return newNumber;
        }


        /// <summary>
        /// Help on count code
        /// </summary>
        /// <returns></returns>
        public int count()
        {
            int rows = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString = @"Select Count(*) from EMPLOYEE";

            var connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = queryString;

            rows = (int)cmd2.ExecuteScalar();

            
            connection.Close();

           int count = rows;
            return count;



        }




    }//end of model

}
