using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Animal animal1 = new Animal(50, 55.5);
            txtInfo.Text = animal1.GetInfo();
        }

        private void btnAddCow_Click(object sender, EventArgs e)
        {
            Cow cow1 = new Cow(3, 100, "ABC");
            txtInfo.Text = cow1.GetInfo();
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            Dog dog1 = new Dog(3, 100, "ABC", "Labrador");
            txtInfo.Text = dog1.GetInfo();
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            Animal[] animalArr = new Animal[4];
            animalArr[0] = new Cow(3, 100, "Tag 3");
            animalArr[1] = new Cow(1, 300, "Tag 1");
            animalArr[2] = new Dog(8, 30, "Shityou", "");
            animalArr[3] = new Dog(5, 54, "Tag 1", "");

            string str = string.Empty;
            foreach (Animal a in animalArr)
            {
                str += a.GetInfo() + "\r\n\r\n";
            }
            txtInfo.Text = str;
        }
    }
}
