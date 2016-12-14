using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical4qn2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int size, counter = 0;
            String symbol = "";
            bool canstart = false;

            if (int.TryParse(txtSize.Text, out size))
            {
                size = int.Parse(txtSize.Text);
                canstart = true;
            }
            else
            {
                MessageBox.Show("Invalid Input! Please try again.");
            }

            if (txtSymbol.TextLength > 1 || txtSymbol.TextLength < 1)
            {
                MessageBox.Show("Please enter only one character for your symbol.");
                canstart = false;
            }
            else
            {
                symbol = txtSymbol.Text;
                canstart = true;
            }

            if (canstart == true)
            {
                for (int i = 1; i <= size; i++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        txtOutput.Text += symbol;
                    }
                    txtOutput.Text += "\r\n"; //TextBox requires \r and \n to create a new line
                }

                for (int j = size; j > 0; j--)
                {
                    for (int l = 2; l <= j; l++)
                    {
                        txtOutput.Text += symbol;
                    }
                    txtOutput.Text += "\r\n";
                }
            }


        }
    }
}
