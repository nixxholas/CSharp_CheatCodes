using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Record
{
    public partial class Form2 : Form
    {
        private DataTable studentDataTable;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //setup the data table
            studentDataTable = new DataTable();
            studentDataTable.Columns.Add("FullName");
            studentDataTable.Columns.Add("MobileContact");

            //setup the list view
            lvStudent.View = View.Details;
            lvStudent.Columns.Add("Student Name", 200);
            lvStudent.Columns.Add("Contact Number", 200);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Hard code data in data table
            studentDataTable.Rows.Clear();
            studentDataTable.Rows.Add("Rodger", "91111111");
            studentDataTable.Rows.Add("David", "92222222");
            studentDataTable.Rows.Add("John", "93333333");

            displayListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //select the second row in the data table
            DataRow studentRow = studentDataTable.Rows[1];

            //Update the full name
            studentRow["FullName"] = "Johnny";

            displayListView();
        }
        private void displayListView()
        {
            //display data in te list view
            lvStudent.Items.Clear();
            foreach (DataRow row in studentDataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["FullName"].ToString();
                item.SubItems.Add(row["mobileContact"].ToString());
                lvStudent.Items.Add(item);
            }
        }
    }
}
