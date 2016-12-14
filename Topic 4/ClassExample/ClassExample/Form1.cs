using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExample
{
    public partial class Form1 : Form
    {
        private person me;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add a person
            person me = new person("Kish Choy Wai Kit", 17);

            //Display a person
            lblMessage.Text = me.getInfo();
        }

        private void btnYounger_Click(object sender, EventArgs e)
        {
            me.Age = me.Age - 1;
            lblMessage.Text = me.getInfo();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            person[] personArr = new person[3];
            personArr[0] = new person("Jas", 18);
            personArr[1] = new person("Suresh", 18);
            personArr[2] = new person("Ivan", 18);

            string str = String.Empty; //""
            foreach (person p in personArr)
            {
                str += p.getInfo() + "\n";
            }
            lblMessage.Text = str;
        }
    }
}
