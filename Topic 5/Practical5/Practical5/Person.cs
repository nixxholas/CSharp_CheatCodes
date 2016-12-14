using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    class Person
    {
        private string m_name;
        private int m_age;
        private char m_gender;

        public Person()
        {
            m_name = "Unknown";
            m_age = 0;
            m_gender = 'M';
        }
        
        public Person(string name, int age, char gender)
        {
            this.m_name = name;
            this.m_age = age;
            this.m_gender = gender;
        }

        public string M_name
        {
            get { return this.m_name; }
            set { this.m_name = value; }
        }

        public int M_age
        {
            get { return this.m_age; }
            set { this.m_age = value; }
        }

        public char M_gender
        {
            get { return this.m_gender; }
            set { this.m_gender = value; }
        }

        public int GetYearOfBirth()
        {
            return DateTime.Now.Year - this.m_age;
        }
    }
}
