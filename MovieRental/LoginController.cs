using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace MovieRental
{
    public class LoginController
    {
        string userId;
        string password;
        string connectionString;


        public void exitApp() {
            Application.Exit();
        }


        public Boolean login(String userId, String password)
        {
            bool status;
            MovieModel m1 = new MovieModel();
            status = m1.checkLogin(userId, password);
            return status;
        }//end of login code*/

        public void loadPanel2()
        {

            MovieModel m1 = new MovieModel();
            m1.loadpanel();

        }


    }
}
