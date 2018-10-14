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
    class RentInfo
    {
        public int movieID { get; set; }
        public string movieTitle { get; set; }
        public string dateRented { get; set; }
        public string dateReturned { get; set; }
        public bool rented { get; set; }

    }

    class RentMovie
    {
        public int customerID { get; set; }
        public int movieID { get; set; }
        public string movieTitle { get; set; }
        public string dateRented { get; set; }
        public string dateReturned { get; set; }
        public bool rented { get; set; }
    }

    

    class RentalInfoModel

    {
        internal static void AddMovie(RentInfo newmovie)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            //string queryString0 = @"Delete from MOVIE_INFO where MOVIE_ID = @MOVIE_ID";
            string queryString = @"Insert into MOVIE_INFO (MOVIE_ID,MOVIE_TITLE)
                                    values(@MOVIE_ID,@MOVIE_TITLE)";

            using (var connection = new SqlConnection(connectionString))
            {


                connection.Open();
                SqlCommand cmd2 = new SqlCommand();

                try
                {
                    cmd2 = new SqlCommand(queryString, connection);

                    cmd2.Parameters.AddWithValue("@MOVIE_ID", newmovie.movieID);
                    cmd2.Parameters.AddWithValue("@MOVIE_TITLE", newmovie.movieTitle);
                    
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Movie " + newmovie.movieID + ": " + newmovie.movieTitle +
                        " was successfully added.");
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                    }
                
            }
        }

        internal DataGridView fillRentedOnly(DataGridView rentedOnly)
        {
            DataTable dt = new DataTable();
            RentMovie rentMovie = new RentMovie();

            {
                string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        List<String> data = new List<string>();
                        SqlCommand cmd = new SqlCommand(@"SELECT    RENTAL.RENTAL_ID,
                                                                    RENTAL.CUSTOMER_ID,
                                                                    CUSTOMER_INFO.CUSTOMER_FNAME,
                                                                    CUSTOMER_INFO.CUSTOMER_LNAME,
                                                                    RENTAL.MOVIE_ID,
                                                                    MOVIE_INFO.MOVIE_TITLE,
                                                                    RENTAL.DATE_RENTED,
                                                                    RENTAL.DATE_RETURNED
                                                        FROM    RENTAL INNER JOIN
                                                                CUSTOMER_INFO ON RENTAL.CUSTOMER_ID = CUSTOMER_INFO.CUSTOMER_ID
                                                                INNER JOIN MOVIE_INFO ON RENTAL.MOVIE_ID = MOVIE_INFO.MOVIE_ID
                                                       WHERE    (RENTAL.DATE_RENTED IS NOT NULL) AND (RENTAL.DATE_RETURNED IS NULL)", connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        rentedOnly.AutoGenerateColumns = true;
                        rentedOnly.AutoResizeRows();
                        rentedOnly.AutoResizeColumns();
                        rentedOnly.DataSource = dt;
                        //rentedOnly.DataMember = dt.TableName;
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

            }
            return rentedOnly;
        }

        internal static void returnMovie(RentMovie rentMovie)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
            string queryString = @"UPDATE MOVIE_INFO set RENTED = @RENTED
                                   WHERE MOVIE_ID = @MOVIE_ID";

            using (var connection = new SqlConnection(connectionString))
            {


                connection.Open();
                SqlCommand cmd2 = new SqlCommand(queryString, connection);
                try
                {
                    bool rented = false;

                    cmd2.Parameters.AddWithValue("@MOVIE_ID", rentMovie.movieID);
                    cmd2.Parameters.AddWithValue("@RENTED", rented);
                    cmd2.ExecuteNonQuery();

                }
                catch
                {
                    MessageBox.Show("Did not add back to inventory");
                }

                try
                {
                    string queryString1 = @"UPDATE RENTAL SET DATE_RETURNED = @DATE_RETURNED
                                            WHERE MOVIE_ID = @MOVIE_ID AND CUSTOMER_ID = @CUSTOMER_ID";
                    cmd2 = new SqlCommand(queryString1, connection);

                    cmd2.Parameters.AddWithValue("@DATE_RETURNED", rentMovie.dateReturned);
                    cmd2.Parameters.AddWithValue("@MOVIE_ID", rentMovie.movieID);
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ID", rentMovie.customerID);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Movie " + rentMovie.movieID + ": " + rentMovie.movieTitle +
                        " was successfully returned.");
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }

        }

        internal DataGridView fillRentalHistoryDataGrid(DataGridView rentalHistoryDataGrid)
        {
            DataTable dt = new DataTable();
            RentMovie rentMovie = new RentMovie();


            {
                string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        List<String> data = new List<string>();
                        SqlCommand cmd = new SqlCommand(@"SELECT RENTAL.CUSTOMER_ID, 
                                                           CUSTOMER_INFO.CUSTOMER_FNAME, 
		                                                    CUSTOMER_INFO.CUSTOMER_LNAME,
		                                                    RENTAL.MOVIE_ID,
		                                                    MOVIE_INFO.MOVIE_TITLE,
		                                                    RENTAL.DATE_RENTED,
		                                                    RENTAL.DATE_RETURNED
		                                                    FROM	RENTAL,  
				                                                    MOVIE_INFO,
				                                                    CUSTOMER_INFO
		                                                    WHERE	RENTAL.CUSTOMER_ID = CUSTOMER_INFO.CUSTOMER_ID
				                                                    AND RENTAL.MOVIE_ID = MOVIE_INFO.MOVIE_ID
				                                                    ORDER BY RENTAL.MOVIE_ID, RENTAL.DATE_RENTED DESC", connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        dt.Load(reader);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        
                        adapter.Fill(dt);
                        rentalHistoryDataGrid.AutoGenerateColumns = true;
                        rentalHistoryDataGrid.AutoResizeRows();
                        rentalHistoryDataGrid.AutoResizeColumns();
                        rentalHistoryDataGrid.DataSource = dt;
                        rentalHistoryDataGrid.DataMember = dt.TableName;
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

            }
            return rentalHistoryDataGrid;

        }

        internal int NewID(string movieID)
        {
            int newNumber;
            try
            {
                newNumber = int.Parse(movieID);
            }
            catch (Exception e)
            {
                newNumber = -1;
            }
            return newNumber;
            
        }

        internal void RentMovie(RentMovie rentMovie)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;

            string queryString1 = @"UPDATE Movie_INFO set RENTED = @RENTED
                                    WHERE MOVIE_ID = @MOVIEID";
            string queryString2 = @"INSERT INTO RENTAL (CUSTOMER_ID, MOVIE_ID,DATE_RENTED)
                                    VALUES (@CUSTOMERID,@MOVIEID,@DATE_RENTED)";
            string queryString3 = @"SELECT MOVIE_TITLE FROM MOVIE_INFO WHERE MOVIE_ID = @MOVIE_ID";

            using (var connection = new SqlConnection(connectionString))
            {


                connection.Open();
                SqlCommand cmd2 = new SqlCommand(queryString1, connection);

                try
                {
                    cmd2.Parameters.AddWithValue("@RENTED", rentMovie.rented);
                    cmd2.Parameters.AddWithValue("@MOVIEID", rentMovie.movieID);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand(queryString2, connection);

                    cmd3.Parameters.AddWithValue("@CUSTOMERID", rentMovie.customerID);
                    cmd3.Parameters.AddWithValue("@MOVIEID", rentMovie.movieID);
                    cmd3.Parameters.AddWithValue("@DATE_RENTED", rentMovie.dateRented);
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand(queryString3, connection);
                    cmd4.Parameters.AddWithValue("@MOVIE_ID", rentMovie.movieID);

                    MessageBox.Show(rentMovie.movieID + ": " + rentMovie.movieTitle + " has been rented by " + rentMovie.customerID);


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        internal bool testToRent(RentMovie rent)
        {
            bool canRent = true;
            bool movieAllreadyCheckedOut = false;
            int numberOfRentals = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;

            string queryString1 = @"SELECT COUNT (*) FROM  RENTAL 
                                   WHERE CUSTOMER_ID  = @CUSTOMER_ID 
                                   AND DATE_RENTED IS NOT NULL 
                                   AND DATE_RETURNED IS NULL
                                   OR  DATE_RETURNED LIKE ' '";

            string queryString2 = @"SELECT RENTED FROM MOVIE_INFO 
                                     WHERE MOVIE_ID = @MOVIE_ID";

            using (var connection = new SqlConnection(connectionString))
            {                
                SqlCommand cmd2 = new SqlCommand(queryString1,connection);
                SqlCommand cmd3 = new SqlCommand(queryString2,connection);
                try
                {
                    connection.Open();
                    
                    cmd2.Parameters.AddWithValue("@CUSTOMER_ID", rent.customerID);

                    numberOfRentals = (int)cmd2.ExecuteScalar();                    

                    if (numberOfRentals >= 3)
                    {
                        canRent = false;
                    }
                    
                    cmd3.Parameters.AddWithValue("@MOVIE_ID",rent.movieID);

                    movieAllreadyCheckedOut = (bool) (cmd3.ExecuteScalar());

                    if (movieAllreadyCheckedOut == true)
                    {
                        canRent = false;
                    }

                }

                catch (Exception e)
                {
                    MessageBox.Show("Caught this exception: " + e.Message);
                }
                finally
                {
                    connection.Close();
                }
                return canRent;
            }
        }




    }
}

    

