using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double mst, asgn1, asgn2, gp, result;

            mst = double.Parse(txtMST.Text);
            asgn1 = double.Parse(txtAsgn1.Text);
            asgn2 = double.Parse(txtAsgn2.Text);
            gp = double.Parse(txtGP.Text);

            result = (mst * 0.2) + (asgn1 * 0.25) + (asgn2 * 0.35) + (gp * 0.2);

            lblAverage.Text = "Weighted Average Score : " + Convert.ToString(result);


        }
    }
}
