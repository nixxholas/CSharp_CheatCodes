using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    class PersonCollection
    {
        private const string connectionStr = "Data Source=NIXH\\SQLEXPRESS;" +
                       "database=1B02APPD;" +
                       "integrated security=true";

        private DataTable personDataTable = new DataTable();
        private int current;
        Person[] persons = new Person[8];

        public PersonCollection()
        {
            current = 0;
            persons = new Person[8];
            persons[0] = new Person("Mr A", 20, 'M');
            persons[1] = new Person("Mr B", 30, 'M');
            persons[2] = new Person("Miss C", 25, 'F');
            persons[3] = new Person("Mrs D", 19, 'F');
            persons[4] = new Person("Mr E", 45, 'M');
            persons[5] = new Person("Mr F", 22, 'M');
            persons[6] = new Person("Ms G", 76, 'F');
            persons[7] = new Person("Miss H", 66, 'F');


            string userMsg = String.Empty;
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        //Set up the connection string
                        conn.ConnectionString = connectionStr;
                        //set up the relationship between the connecetion and command objects
                        cmd.Connection = conn;
                        //set up the sql statement
                        cmd.CommandText = "Select * from Student";
                        try
                        {
                            conn.Open();
                            da.SelectCommand = cmd;
                            personDataTable.Clear();
                            da.Fill(personDataTable);
                            displayListView();
                            userMsg = "All student information loaded";
                        }
                        catch (Exception ex)
                        {
                            userMsg = ex.Message;
                        }
                        finally
                        {
                            conn.Close();
                        }
                        lblMessage.Text = userMsg;
                    }
                }
            }
        }

        public Person getCurrentPerson()
        {
            return persons[current];
        }

        public int getTotalNoOfPersons()
        {
            return persons.Length;
        }

        public int Current
        {
            get { return this.current; }
            set { this.current = value; }
        }
    }
}
