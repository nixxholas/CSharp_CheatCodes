using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Dog : Animal
    {
        private string name, breed;

        public Dog(int a, double w, string n, string b) : base(a, w)
        {
            name = n;
            breed = b;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string GetInfo()
        {
            string info = string.Empty;
            info = base.GetInfo();
            info += "\r\nName: " + name;
            info += "\r\nBreed: " + breed;
            return info;
        }
    }
}
