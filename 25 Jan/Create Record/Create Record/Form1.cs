using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Create_Record
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userMsg;

            //Create the connection and command objects
            using (SqlConnection conn = new SqlConnection())
            {
                ;
                using (SqlCommand cmd = new SqlCommand())
                {
                    ;

                    //set up the connection string
                    conn.ConnectionString = "Data Source=KISH_AAR13\\SQLEXPRESS;" +
                        "database=1B02APPD;" +
                        "integrated security=true";

                    //establish the relationship with the connection and commnad object
                    cmd.Connection = conn;

                    //set up the command object
                    cmd.CommandText = "Insert into Student (FullName, AdmissionId, HomeAddress, PostalCode, EmailAddress, MobileContact)"
                    + "Values('Suresh', '2321234', 'Blk 111 #08-77 Dover Road', '234459', 'suresh@hotmail.com', '91234567')";

                    try
                    {
                        //open connection
                        conn.Open();
                        //execute command
                        cmd.ExecuteNonQuery();
                        userMsg = "You have reated a new student record";
                    }
                    catch (Exception ex)
                    {
                        userMsg = ex.Message;
                    }
                    finally
                    {
                        //close connection
                        conn.Close();
                    }
                }
            }
            lblMessage.Text = userMsg;
        }
    }
}
