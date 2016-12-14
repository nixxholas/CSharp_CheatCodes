using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class person
    {
        //properties
        private string name;
        private int age;

        //methods
        //default constructor
        public person()
        {
            name = "?";
            age = -1;
        }

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        /*
        public int getAge() {
            return age;
        }


        public void setAge(int age)
        {
            this.age = age;
        }*/

        public string getInfo()
        {
            return String.Format("Name : {0}\nAge: {1}", name, age);
        }
    }
}
