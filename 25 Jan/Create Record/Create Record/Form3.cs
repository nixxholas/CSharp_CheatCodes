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
    public partial class Form3 : Form
    {
        private const string connectionStr =
            "Data Source=KISH_AAR13\\SQLEXPRESS;" +
            "database=1B02APPD;" +
            "integrated security=true";
        private DataTable studentDataTable = new DataTable();
        private string currentStudentRecordId = String.Empty;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //setup the list view
            lvStudent.View = View.Details;
            lvStudent.Columns.Add("Student Name", 200);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadStudentData();
            displayListView();
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvStudent.SelectedItems.Count > 0)
            {
                //retrieve the record id from the tag property
                currentStudentRecordId = lvStudent.SelectedItems[0].Tag.ToString();
                lblMessage.Text = "Student record ID is " + currentStudentRecordId;

                //retrieve the student record based on the record id
                DataRow[] currentRow = studentDataTable.Select("StudentRecordId=" + currentStudentRecordId);

                //update the respectve textboxes
                txtFullName.Text = currentRow[0]["FullName"].ToString();
                txtMobile.Text = currentRow[0]["MobileContact"].ToString();
                txtEmail.Text = currentRow[0]["EmailAddress"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userMsg = String.Empty;
            //Create the connection and command objects
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    //set up the connection string
                    conn.ConnectionString = connectionStr;

                    //establish the relationship with the connection and command object
                    cmd.Connection = conn;

                    //set up the command object
                    cmd.CommandText = "Update Student set FUllName=@inFullName," +
                    "MobileContact=@inMobileContact, emailAddress=@inEmailAddress" +
                    " Where StudentRecordId=@inStudentRecordId";

                    //retrieve the values from the textboxes
                    cmd.Parameters.AddWithValue("@inFullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@inEmailAddress", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@inMobileContact", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@inStudentRecordId", currentStudentRecordId);

                    try
                    {
                        //open connection
                        conn.Open();
                        //execute commmand
                        cmd.ExecuteNonQuery();
                        userMsg = "Saved " + txtFullName.Text + "\'s information";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        //close connection
                        conn.Close();
                    }
                }
            }
            loadStudentData();
            displayListView();
            lblMessage.Text = userMsg;
        }

        private void displayListView()
        {
            //display data in te list view
            lvStudent.Items.Clear();
            foreach (DataRow row in studentDataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["FullName"].ToString();
                item.Tag = row["StudentRecordId"].ToString();
                //to capture thhe student record id
                lvStudent.Items.Add(item);
            }
        }
        private void loadStudentData()
        {
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
                            studentDataTable.Clear();
                            da.Fill(studentDataTable);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userMsg = String.Empty;
            //Create the connection and command objects
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    //set up the connection string
                    conn.ConnectionString = connectionStr;

                    //establish the relationship with the connection and command object
                    cmd.Connection = conn;

                    //set up the command object
                    cmd.CommandText = "Delete Student " +
                        "WHERE StudentRecordId=@inStudentRecordId";

                    //retrieve the values from the textboxes
                    cmd.Parameters.AddWithValue("@inStudentRecordId", currentStudentRecordId);

                    try
                    {
                        //open connection
                        conn.Open();
                        //execute commmand
                        cmd.ExecuteNonQuery();
                        userMsg = "Deleted " + txtFullName.Text + "\'s information";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        //close connection
                        conn.Close();
                    }
                }
            }
            loadStudentData();
            displayListView();
            lblMessage.Text = userMsg;
            txtEmail.Clear();
            txtFullName.Clear();
            txtMobile.Clear();
        }
    }
}
