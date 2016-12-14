using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical5
{
    public partial class Form1 : Form
    {
        PersonCollection collection = new PersonCollection();
        public Form1()
        {
            InitializeComponent();
            setView();
        }

        public void setView()
        {
            Person p = collection.getCurrentPerson();
            txtName.Text = p.M_name;
            txtAge.Text = p.M_age.ToString();
            txtGender.Text = p.M_gender.ToString();
            txtBirthYr.Text = p.GetYearOfBirth().ToString();
            grpPerson.Text = (collection.Current + 1) + " / " + collection.getTotalNoOfPersons();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            collection.Current = 0;
            setView();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (collection.Current >= 1)
            {
                collection.Current -= 1;
                setView();
            } else
            {
                MessageBox.Show("Nothing else to show here.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (collection.Current < 7)
            {
                collection.Current += 1;
                setView();
            }
            else
            {
                MessageBox.Show("Nothing else to show here.");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            collection.Current = 7;
            setView();
        }
    }
}
