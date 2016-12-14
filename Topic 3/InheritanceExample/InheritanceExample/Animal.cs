using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Animal
    {
        private int m_age;
        private double m_weight;

        public double lol;
        public int test;
        public string outter = "2";

        test = Double.Parse(outter);


        public Animal()
        {

        }

        public Animal(int a, double w)
        {
            m_age = a;
            m_weight = w;
        }

        public int Age
        {
            get { return m_age; }
            set { m_age = value; }
        }

        public double Weight
        {
            get { return m_weight; }
            set { m_weight = value; }
        }

        public virtual string GetInfo()
        {
            string str = string.Empty;
            str = "Species: " + this.GetType().Name; //returns the class name
            str += "\r\nAge: " + m_age;
            str += "\r\nWeight: " + m_weight;
            return str;
        }
    }
}
