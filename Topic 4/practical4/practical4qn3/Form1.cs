using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical4qn3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            String Guest = GuestInput.Text;
            int rooms, nights;
            double price, total;

            price = 0;

            bool printable = false;

            rooms = int.Parse(RoomsInput.Text);
            nights = int.Parse(NightsInput.Text);

            if (GuestInput.Text == "")
            {
                MessageBox.Show("Please input the guest's name.");
            } else
            {
                printable = true;
            }

            if (SingleCheck.Checked == true)
            {
                price = 150;
                price *= rooms;
                printable = true;
            } else if (DoubleCheck.Checked == true)
            {
                price = 200;
                price *= rooms;
                printable = true;
            } else if (TwinCheck.Checked == true)
            {
                price = 210;
                price *= rooms;
                printable = true;
            } else
            {
                printable = false;
                MessageBox.Show("Please Check one of the room types.");
            }
            
            total = price * nights;

            if (firstTime.Checked == true)
            {
                total *= 0.85;
            }

            txtOutput.Text += "Booking Details : \r\n \r\n";

            dateInput.Format = DateTimePickerFormat.Custom;
            dateInput.CustomFormat = "dd-MM-yyyy";
            
            
            if (printable == true)
            {
                txtOutput.Text += "Guest Name : " + Guest + "\r\n";
                txtOutput.Text += "Arrive : " + dateInput.Value + "\r\n"; //bugged
                txtOutput.Text += "Depart : " + dateInput.Value.AddDays(nights) +"\r\n";
                txtOutput.Text += "Room Total : " + total;
            } else
            {
                MessageBox.Show("There was an error in your input.");
            }
             
        }
    }
}
