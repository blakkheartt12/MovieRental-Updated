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

    
    class MovieModel
    {
        private string userId;
        private string password;
        //SqlDataReader reader;
        //int customerID = 0;
        //string cFName = null;
        //string cLName = null;
        //string cAddress = null;
        //string cCity = null;
        //string cState = null;
        //string cZip = null;
        //string cEmail = null;
        string fileName = null;

        public void openDialog ()
        {
            OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter =
             "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a text file";
            //string fileName = null;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                //richTextBox1.Text = System.IO.File.ReadAllText(fname); //this would output a richtext box if one was available
            }
            else
            {
                return;
            }


        }

        public bool checkLogin(string userId, string password)
        {

            this.userId = userId;
            this.password = password;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Boolean status;
                string queryString = @"Select * from EMPLOYEE where EMPLOYEE_ID = '" + userId + "' and " + "PASSWORD = '" + password + "'";
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.CommandText = "Select * from EMPLOYEE where EMPLOYEE_ID = '" + userId + "' and " + "PASSWORD = '" + password + "'";
                cmd.CommandType = CommandType.Text;


                reader = cmd.ExecuteReader();
                string epassword = null;
                int employeeID = 0;
                try
                {
                    while (reader.Read())
                    {
                        // get the results of each column
                        employeeID = (int)reader["EMPLOYEE_ID"];
                        epassword = (string)reader["PASSWORD"];
                    }

                    //Boolean status;
                    if (employeeID == int.Parse(userId) && epassword.Equals(password))
                    //(employeeID != 0)
                    {
                        loadpanel();

                        status = true;

                    }
                    else
                    {
                        MessageBox.Show("Please check your user id and password");
                        status = false;
                    }
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Please check your user id and password");
                    status = false;
                    connection.Close();
                }
                return status;


            }

        }

        public void loadpanel() {

            Login login1 = new Login();
            MainPageView newpage = new MainPageView();
            newpage.Show();
            newpage.loadFilePanel.SuspendLayout();
            newpage.loadFilePanel.Visible = true;
            newpage.loadFilePanel.BringToFront();
            newpage.loadFilePanel.Location = new System.Drawing.Point(0, 24);
            newpage.loadFilePanel.ResumeLayout();

        }

        internal void saveClientList()
        {

            int customerID = 0;
            string firstName = null;
            string lastName = null;
            bool suspended = false;
            string cid = null;
            string rid = null;
            string txt = null;


            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Open File";
            save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        List<String> data = new List<string>();
                        SqlCommand cmd = new SqlCommand(@"SELECT CUSTOMER_ID, CUSTOMER_FNAME, CUSTOMER_LNAME,SUSPENDED
                                                        FROM CUSTOMER_INFO ORDER BY CUSTOMER_ID", connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            customerID = (int)reader["CUSTOMER_ID"];
                            cid = customerID.ToString();
                            data.Add(cid);

                            firstName = (string)reader["CUSTOMER_FNAME"];
                            data.Add(firstName);

                            lastName = (string)reader["CUSTOMER_LNAME"];
                            data.Add(lastName);

                            suspended = (bool)reader["SUSPENDED"];
                            string suspend = suspended.ToString();
                            data.Add(suspend);
                            if (!suspend.Equals("False"))
                            {
                                txt += cid + ";" + firstName + " "+ lastName + ";" + "0" + "\n";
                            }
                            else
                            {
                                txt += cid + ";" + firstName + " " + lastName + ";" +"1" + "\n";
                            }
                        }


                        StreamWriter sw = new StreamWriter(File.Create(save.FileName));

                        {
                            sw.WriteLine(txt);
                            sw.Dispose();
                        }

                        reader.Close();
                    }
                    catch (Exception y)
                    {
                        MessageBox.Show(y.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }//end of if save dialog
        }

        internal void movieList()
        {

            RentMovie rentMovie = new RentMovie();
            int movieID = 0;
            string movieTitle = null;
            string dateRented = null;
            bool rented = true;
            string cid = null;
            string rid = null;
            string txt = null;


            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Open File";
            save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        List<String> data = new List<string>();
                        SqlCommand cmd = new SqlCommand(@"SELECT * FROM MOVIE_INFO ORDER BY MOVIE_ID", connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            movieID = (int)reader["MOVIE_ID"];
                            string mid = movieID.ToString();
                            data.Add(mid);

                            movieTitle = (string)reader["MOVIE_TITLE"];
                            data.Add(rentMovie.movieTitle);

                            rented = (bool)reader["RENTED"];
                            string rent = rented.ToString();
                            data.Add(rent);
                            if (!rent.Equals("False"))
                            {
                                txt += mid + ";" + movieTitle + ";" + "0" + "\n";
                            }
                            else
                            {
                                txt += mid + ";" + movieTitle + ";" + "1" + "\n";
                            }
                        }


                        StreamWriter sw = new StreamWriter(File.Create(save.FileName));

                        {
                            sw.WriteLine(txt);
                            sw.Dispose();
                        }

                        reader.Close();
                    }
                    catch (Exception y)
                    {
                        MessageBox.Show(y.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }//end of if save dialog

        }

        internal void saveFileRentalHistory()
        {
            RentMovie rentMovie = new RentMovie();
            int rentalID = 0;
            int customerID = 0;
            int movieID = 0;
            string movieTitle = null;
            string dateRented = null;
            Object dateReturned = null;
            string cid = null;
            string rid = null;
            string txt = null;
 

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Open File";
            save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                    string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;

                    using (var connection = new SqlConnection(connectionString))
                    {
                    try
                    {

                        connection.Open();
                        List<String> data = new List<string>();
                        SqlCommand cmd = new SqlCommand(@"SELECT RENTAL.RENTAL_ID,RENTAL.CUSTOMER_ID, RENTAL.MOVIE_ID, MOVIE_INFO.MOVIE_TITLE, RENTAL.DATE_RENTED, RENTAL.DATE_RETURNED
                                        FROM RENTAL INNER JOIN  MOVIE_INFO ON RENTAL.MOVIE_ID = MOVIE_INFO.MOVIE_ID
                                        ORDER BY RENTAL.MOVIE_ID, RENTAL.DATE_RENTED DESC", connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            rentalID = (int)reader["RENTAL_ID"];
                            rid = rentalID.ToString();
                            data.Add(rid);

                            customerID = (int)reader["CUSTOMER_ID"];
                            cid = customerID.ToString();
                            data.Add(cid);

                            movieID = (int)reader["MOVIE_ID"];
                            string mid = movieID.ToString();
                            data.Add(mid);

                            movieTitle = (string)reader["MOVIE_TITLE"];
                            data.Add(rentMovie.movieTitle);

                            dateRented = (string)reader["DATE_RENTED"];
                            data.Add(rentMovie.dateRented);

                            dateReturned = reader["DATE_RETURNED"];
                            if (dateReturned == null)
                            {
                                dateReturned = DBNull.Value;
                            }

                            data.Add(rentMovie.dateReturned);
                            if (!dateReturned.Equals(DBNull.Value))
                            {
                                txt += rid + ";" + cid + ";" + mid + ";" + movieTitle + ";" + dateRented + ";" + dateReturned + "\n";
                            }
                            else
                            {
                                txt += rid + ";" + cid + ";" + mid + ";" + movieTitle + ";" + dateRented + "\n";
                            }
                            
                        }
                       

                        StreamWriter sw = new StreamWriter(File.Create(save.FileName));
                        
                        {
                            sw.WriteLine(txt);
                            sw.Dispose();
                        }

                        reader.Close();
                    }
                    catch (Exception y)
                    {
                        MessageBox.Show(y.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }//end of if save dialog
        }
        
        internal int newID(string cID)
        {
            int newNumber;
            try
            {
                newNumber = int.Parse(cID);
            }
            catch ( Exception e)
            {
                 newNumber =-1;
            }
            return newNumber;
        }


        internal void deleteClient()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString0 = @"TRUNCATE TABLE CUSTOMER_INFO";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(queryString0, connection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Did not delete");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        internal void deleteRental()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString0 = @"TRUNCATE TABLE RENTAL";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(queryString0, connection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Did not delete");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        internal void deleteMovies()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString0 = @"Delete from MOVIE_INFO";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(queryString0, connection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Did not delete");
                }
                finally
                {
                    connection.Close();
                }
            }
        }




        /// <summary>
        /// //////////////////////////
        /// </summary>

        internal bool finishLoadingData()
        {
            bool click = false;
            DialogResult dialog = MessageBox.Show("Are you done loading all files?", "Finished Loading Files",
             MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                click = true;
                return click;

            }
            else if (dialog == DialogResult.No)
            {
                click = false;
                return click;
            }
            return click;
        }

        internal void loadRentalInfo()
        {
            openDialog();

            List<String[]> rentalInfo = new List<string[]>();
            try
            {
                String path = fileName;
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] _column = line.Split(new Char[] {';'});
                        rentalInfo.Add(_column);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            if
            (MessageBox.Show("Do you want to delete all current RENTAL Data and start with a fresh table select Yes", "Delete All RENTAL Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteRental();
            }
            
            string queryString = @"Insert into RENTAL (CUSTOMER_ID,MOVIE_ID,DATE_RENTED,DATE_RETURNED) values (@customerID, @movieID,@dateRented,@dateReturned)";
          
            using (var connection = new SqlConnection(connectionString))
            {
                int customerId = 0;
                int movieId = 0;
                string dateRented = String.Empty;
                string dateReturned = String.Empty;

                connection.Open();
                
                SqlCommand cmd2 = new SqlCommand(queryString, connection);
                
                cmd2.Parameters.Add("@customerID", SqlDbType.Int);
                cmd2.Parameters.Add("@movieID", SqlDbType.Int);
                cmd2.Parameters.Add("@dateRented", SqlDbType.VarChar);
                cmd2.Parameters.Add("@dateReturned", SqlDbType.VarChar);
                
                int rows = 0;
                for (int i = 0; i < rentalInfo.Count; i++)
                {
                    customerId = 0;
                    movieId = 0;
                    dateRented = null;
                    dateReturned = null;

                    String[] rental = rentalInfo[i];
                    

                    rental = rentalInfo[i];


                    customerId = int.Parse(rental[0]);
                    movieId = int.Parse(rental[1]);
                    dateRented = rental[2];

                    cmd2.Parameters[0].Value = customerId;
                    cmd2.Parameters[1].Value = movieId;
                    cmd2.Parameters[2].Value = dateRented;

                    if (rental.Length == 4)
                    {
                        dateReturned = rental[3];
                        cmd2.Parameters[3].Value = dateReturned;
                    }
                    else
                    {
                        cmd2.Parameters[3].Value = DBNull.Value;
                    }


                    

                    cmd2.ExecuteNonQuery();
                    rows++;


                }
                connection.Close();
                MessageBox.Show(rows + " records were added to RENTAL table");
            }
        }


        /// <summary>
        /// below is code to load a text file that has movie information
        /// </summary>

        public void loadMovieInfo()

        {
            openDialog();

            List<String[]> clientData = new List<string[]>();
            try
            {
                String path = fileName;
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] _column = line.Split(new Char[] {';'});
                        clientData.Add(_column);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            if
            (MessageBox.Show("Do you want to delete all current RENTAL Data and start with a fresh table select Yes", "Delete All RENTAL Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteMovies();
            }
            
            string queryString = @"Insert into MOVIE_INFO (MOVIE_ID,MOVIE_TITLE,RENTED) values (@movieID, @movieTitle,@rented)";



            using (var connection = new SqlConnection(connectionString))
            {
                int movieID = 0;
                string movieTitle = null;
                int rented = 0;

                connection.Open();
                SqlCommand cmd2 = new SqlCommand(queryString, connection);


                cmd2.Parameters.Add("@movieID", SqlDbType.Int);
                cmd2.Parameters.Add("@movieTitle", SqlDbType.VarChar);
                cmd2.Parameters.Add("@rented", SqlDbType.Bit);

                int rows = 0;
                for (int i = 0; i < clientData.Count; i++)
                {
                    movieID = 0;
                    movieTitle = null;
                    rented = 0;

                    String[] movie = clientData[i];


                    movieID = int.Parse(movie[0]);
                    movieTitle = movie[1];
                    if (movie.Length == 3)
                    {
                        int.TryParse(movie[2], out rented);
                    }


                    cmd2.Parameters[0].Value = movieID;
                    cmd2.Parameters[1].Value = movieTitle;
                    cmd2.Parameters[2].Value = rented;


                    cmd2.ExecuteNonQuery();
                    rows++;


                }
                connection.Close();
                MessageBox.Show(rows + " records were added to MOVIE_INFO table");
            }


        }

        /// <summary>
        /// Below is code to load customer info
        /// </summary>
        public void loadCustomer()
        {
            openDialog();

            List<String[]> clientData = new List<string[]>();
            try
            {
                String path = fileName;
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] _column = line.Split(new Char[] {';'});
                        clientData.Add(_column);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            if
                (MessageBox.Show("Do you want to delete all current client data and start with a fresh table select Yes", "Delete All Client Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                deleteClient();
            }
            

            string queryString = @"Insert into CUSTOMER_INFO (CUSTOMER_ID,CUSTOMER_FNAME,CUSTOMER_LNAME,SUSPENDED) values (@clientID, @firstName,@lastName,@suspended)";



            using (var connection = new SqlConnection(connectionString))
            {
                int clientID = 0;
                string firstName = null;
                string lastName = null;
                int suspended = 0;
                connection.Open();

                SqlCommand cmd2 = new SqlCommand(queryString, connection);


                cmd2.Parameters.Add("@clientID", SqlDbType.Int);
                cmd2.Parameters.Add("@firstName", SqlDbType.VarChar);
                cmd2.Parameters.Add("@lastName", SqlDbType.VarChar);
                cmd2.Parameters.Add("@suspended", SqlDbType.Bit);

                int rows = 0;
                for (int i = 0; i < clientData.Count; i++)
                {
                    clientID = 0;
                    firstName = null;
                    lastName = null;
                    suspended = 0;

                    String[] client = clientData[i];


                    clientID = int.Parse(client[0]);

                    String[] fullName = client[1].Split(new Char[] {' '});
                    firstName = fullName[0];
                    lastName = fullName[1];

                    if (client.Length == 3)
                    {
                        int.TryParse(client[2], out suspended);
                    }

                    cmd2.Parameters[0].Value = clientID;
                    cmd2.Parameters[1].Value = firstName;
                    cmd2.Parameters[2].Value = lastName;
                    cmd2.Parameters[3].Value = suspended;

                    cmd2.ExecuteNonQuery();
                    rows++;


                }
                connection.Close();
                MessageBox.Show(rows + " records were added to CUSTOMER_INFO table");
            }
        }


    }




}