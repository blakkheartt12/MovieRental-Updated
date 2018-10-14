using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class rentForm : Form
    {
        RentalInfoController rentalController = new RentalInfoController();
        MovieModel movieModel = new MovieModel();
        RentInfo rentinfo = new RentInfo();
        public rentForm()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            customer_IDTextBox.Clear();
            movie_IDTextBox.Clear();
            movieTitleTextBx.Clear();
            rentedChkBx.Checked = false;
            newdateRentedTxtBx.Clear();
            dateReturnedTextBx.Clear();
            allMovies.Visible = false;
            rentalHistoryBtn.Visible = false;
            rentedOnlyBtn.Visible = false;
            rentedOnly.Visible = false;
            rentalHistoryDataGrid.Visible = false;

        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            


            int convertedRentalID = rentalController.convertedText(movie_IDTextBox.Text);
            rentalController.addMovie(convertedRentalID, movieTitleTextBx.Text);




            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet1.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.MOVIE_INFO' table. You can move, or remove it, as needed.
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.mOVIESDataSet.RENTAL);

            clearAll();
            
            


        }

        private void rentBtn_Click_1(object sender, EventArgs e)
        {
            bool requiredFieldsFilled = false;


            
            while (requiredFieldsFilled == false)
            {
                if (movie_IDTextBox.Text.Equals("") ||customer_IDTextBox.Text.Equals(""))
                {

                    MessageBox.Show("You have stated the movie is being checked out. Either the Customer ID or" +
                    "Date Rented fields are blank. Please fill in both fields to continue.");

                    requiredFieldsFilled = false;
                    return;

                }
                else
                {
                    requiredFieldsFilled = true;
                }
            }

            int convertedRentalID = rentalController.convertedText(movie_IDTextBox.Text);
            int convertedClientID = rentalController.convertedText(customer_IDTextBox.Text);
            bool ischecked = false;
            if (rentedChkBx.Checked)
            { ischecked = true; }

            RentMovie rentMovie = new RentMovie()
            {
                customerID = convertedClientID,
                movieID = convertedRentalID,
                movieTitle = movieTitleTextBx.Text,
                dateRented = newdateRentedTxtBx.Text,
                rented = ischecked
            };

            bool canRent = false;
            canRent = rentalController.testToRent(rentMovie);
            if (canRent == false)
            {
                MessageBox.Show("The movie is already rented or the customer " +
                                  "already has 3 movies rented. They cannot rent this title.");
            }
            else {
                rentalController.RentMovie(rentMovie);
                rentedChkBx.Checked = true;
            }
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet1.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.MOVIE_INFO' table. You can move, or remove it, as needed.
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.mOVIESDataSet.RENTAL);

            //clearAll();



        }

        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            allMovies.Visible = true;
            rentalHistoryBtn.Visible = true;
            rentedOnlyBtn.Visible = true;
            rentedOnly.Visible = false;
            rentalHistoryDataGrid.Visible = false;
            hideMovieBtn.Visible = true;
            showAllBtn.Visible = false;


            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet1.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.MOVIE_INFO' table. You can move, or remove it, as needed.
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.mOVIESDataSet.RENTAL);


        }

        private void rENTALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rENTALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mOVIESDataSet);

        }

        private void dateRentedTxtBx_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIESDataSet1.MOVIE_INFO' table. You can move, or remove it, as needed.
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet1.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.MOVIE_INFO' table. You can move, or remove it, as needed.
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.mOVIESDataSet.RENTAL);

        }

        private void rentalHistoryBtn_Click_1(object sender, EventArgs e)
        {
            RentalInfoController rentalController = new RentalInfoController();
            rentalController.fillRentalHistoryDataGrid(rentalHistoryDataGrid);
            rentalHistoryDataGrid.Visible = true;
            allMovies.Visible = false;
            rentedOnly.Visible = false;
            showMovie3Btn.Visible = false;
            showMovie2Btn.Visible = true;

            if(this.rentalHistoryDataGrid.SelectedRows.Count > 0)
            {

                DataGridViewRow row = this.rentalHistoryDataGrid.SelectedRows[0];
                movie_IDTextBox.Text = row.Cells[0].Value.ToString();
                movieTitleTextBx.Text = row.Cells[1].Value.ToString();
                rentedChkBx.Checked = (bool)row.Cells[2].Value ? true : false;


            }

            //this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet1.MOVIE_INFO);
            //// TODO: This line of code loads data into the 'mOVIESDataSet.MOVIE_INFO' table. You can move, or remove it, as needed.
            //this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet.MOVIE_INFO);
            //// TODO: This line of code loads data into the 'mOVIESDataSet.RENTAL' table. You can move, or remove it, as needed.
            //this.rENTALTableAdapter.Fill(this.mOVIESDataSet.RENTAL);


        }

        private void rentedOnlyBtn_Click(object sender, EventArgs e)
        {
            RentalInfoController rentalController = new RentalInfoController();
            rentalController.fillRentedOnly(rentedOnly);
            rentedOnly.Visible = true;
            allMovies.Visible = false;
            showMovie3Btn.Visible = true;
            showMovie2Btn.Visible = false;
            rentalHistoryDataGrid.Visible = false;
            

        }

        private void customerMenuBtn_Click(object sender, EventArgs e)
        {
            MainPageView mainpage = new MainPageView();
            mainpage.Visible = true;
            mainpage.loadFilePanel.Visible = false;
            mainpage.mainPnl.Visible = true;
            this.Visible = false;
        }

        private void returnMovieBtn_Click(object sender, EventArgs e)
        {
            bool allEntered = false;
            while (allEntered == false) {


                if (customer_IDTextBox.Text.Equals("") || dateReturnedTextBx.Text.Equals("") || movie_IDTextBox.Text.Equals(""))
                {

                    MessageBox.Show("You are returning a movie but either the Customer ID, " +
                        "Movie ID or Date Returned fields are blank. Please fill in all fields to continue.");
                    allEntered = false;
                    return;
                }
                else {
                    allEntered = true;
                }
            }

            int convertedRentalID = rentalController.convertedText(movie_IDTextBox.Text);
            int convertedClientID = rentalController.convertedText(customer_IDTextBox.Text);
            bool ischecked = false;



                RentMovie rentMovie = new RentMovie()
                {
                    customerID = convertedClientID,
                    movieID = convertedRentalID,
                    movieTitle = movieTitleTextBx.Text,
                    dateRented = newdateRentedTxtBx.Text,
                    dateReturned = dateReturnedTextBx.Text,
                    rented = ischecked
                };

                rentalController.returnMovie(rentMovie);            

            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet1.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.MOVIE_INFO' table. You can move, or remove it, as needed.
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.mOVIESDataSet.RENTAL);

            clearAll();

        }

        private void rentalHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieModel.saveFileRentalHistory();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieModel.movieList();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieModel.saveClientList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void rentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void allMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (allMovies.Rows.Count > 0)
            {
                if (this.allMovies.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.allMovies.SelectedRows[0];
                    
                    movie_IDTextBox.Text = row.Cells[0].Value.ToString();
                    movieTitleTextBx.Text = row.Cells[1].Value.ToString();
                    rentedChkBx.Checked = (bool)row.Cells[2].Value ? true : false;


                }

            }
        }

        private void showMovie3Btn_Click(object sender, EventArgs e)
        {
            MoviesGrid();            

        }

        private void MoviesGrid()
        {
            allMovies.Visible = true;
            rentalHistoryBtn.Visible = true;
            rentedOnlyBtn.Visible = true;
            rentedOnly.Visible = false;
            showMovie2Btn.Visible = false;
            showMovie3Btn.Visible = false;
            rentalHistoryDataGrid.Visible = false;
            hideMovieBtn.Visible = true;
            showAllBtn.Visible = false;


            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet1.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.MOVIE_INFO' table. You can move, or remove it, as needed.
            this.mOVIE_INFOTableAdapter.Fill(this.mOVIESDataSet.MOVIE_INFO);
            // TODO: This line of code loads data into the 'mOVIESDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.mOVIESDataSet.RENTAL);

        }

        private void showMovie2Btn_Click(object sender, EventArgs e)
        {
            MoviesGrid();
        }

        private void hideMovieBtn_Click(object sender, EventArgs e)
        {
            allMovies.Visible = false;
            rentalHistoryBtn.Visible = false;
            rentedOnlyBtn.Visible = false;
            rentedOnly.Visible = false;
            rentalHistoryDataGrid.Visible = false;
            showMovie3Btn.Visible = false;
            showMovie2Btn.Visible = false;
            hideMovieBtn.Visible = false;
            showAllBtn.Visible = true;
        }

        private void employeeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employee employee = new Employee();
            employee.Show();
        }
    }
}


