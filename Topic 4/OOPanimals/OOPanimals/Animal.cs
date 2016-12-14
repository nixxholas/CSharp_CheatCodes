using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPanimals
{
    class Animal
    {
        private int m_age;
        private double m_weight;
        public Animal () { }
        public Animal (int a, double w)
        {
            m_age = a;
            m_weight = w;
        }

        public double Weight
        {
            get { return m_weight; }
            set { m_weight = value; }
        }

        public string GetInfo ()
        {
            string str = string.Empty;
            return "Species: " + this.GetType().Name;
            str += "\r\nAge: " + m_age;
            str += "\r\nWeight: " + m_weight;
            return str;
        }
    }
}
