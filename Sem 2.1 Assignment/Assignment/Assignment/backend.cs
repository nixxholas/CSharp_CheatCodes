using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class backend
    {

        //Product Information Loader from Text
        public void prodinfoText(String location)
        {
            string[] lineparsed = System.IO.File.ReadAllLines(@location);

            foreach (string line in lineparsed)
            {
                //Object Creation initializes here
            }
        }

        //
    }
}
