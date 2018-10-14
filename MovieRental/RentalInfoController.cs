using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{

    class RentalInfoController
    {
        RentalInfoModel rentalInfoModel = new RentalInfoModel();
        internal int convertedText(string text)
        {
            int convertedText = 0;
            convertedText = rentalInfoModel.NewID(text);
            return convertedText;
        }

        public void addMovie(int id, String movietitle)
        {
            RentInfo newmovie = new RentInfo()
            {
                movieID = id,
                movieTitle = movietitle
            };
            if (id <= 0 || movietitle == "")
            {
                MessageBox.Show("ID and movie title are required");
            }
            else
            {
                RentalInfoModel.AddMovie(newmovie);
            }
        }
        
        internal void RentMovie(RentMovie rentMovie)
        {
            rentalInfoModel.RentMovie(rentMovie);
        }

        internal bool testToRent(RentMovie rentInfo)
        {
            bool rent1 = false;
            rent1 = rentalInfoModel.testToRent(rentInfo);
            return rent1;

        }

        internal void fillRentalHistoryDataGrid(DataGridView rentalHistoryDataGrid)
        {
            rentalInfoModel.fillRentalHistoryDataGrid(rentalHistoryDataGrid);
        }

        internal void returnMovie(RentMovie rentMovie)
        {
            RentalInfoModel.returnMovie(rentMovie);
        }

        internal void fillRentedOnly(DataGridView rentedOnly)
        {
            rentalInfoModel.fillRentedOnly(rentedOnly);
        }
    }
}
