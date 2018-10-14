using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    class EmployeeController
    {
        MovieModel movieModel = new MovieModel();
        EmployeeModel employeemodel = new EmployeeModel();
        EmployeeAdd employee1 = new EmployeeAdd();

        int id;
        string password;
        string fname;
        string lname;
        string secret;
        string answer;
        

        public void addEmployee(String password, String fname, String lname, String secret, String answer)
            {

                EmployeeAdd employees1  = new EmployeeAdd()
                {
                    
                    password = password,
                    FirstName = fname,
                    LastName = lname,
                    SecretQuestion = secret,
                    Answer = answer                    
                };



                if (fname == "" || lname == "" || secret == "" || answer == "" || password =="")
                {
                    MessageBox.Show(" First Name, Last Name, Secret Question, Answer, and Password are required. Employee was not added.");
                }
                
                else
                {
                    employeemodel.AddEmployee(employees1);
                }
            }

        internal int newID(string eID)
        {
            int newNumber = 0;
            newNumber = employeemodel.newID(eID);
            return newNumber;
        }

        internal void deleteEmployee(int newEID)
        {
            int id = newEID;
            employeemodel.DeleteEmployee(id);

        }

        public int getUserCount() {
            
            return employeemodel.count();
        }


        internal void update(int newEID, string pw, string secret, string a)
        {
            
            employeemodel.UpdateEmployee(newEID, pw, secret,a);
        }
    }
}
