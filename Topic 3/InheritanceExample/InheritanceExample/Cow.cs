using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Cow : Animal //subclass of Animal
    {
        private string m_tagID;

        public Cow(int a, double w, string t) : base(a,w)
        {
            m_tagID = t;
        }

        public Cow(string t)
        {
            m_tagID = t;
        }

        public string TagID
        {
            get { return m_tagID; }
            set { m_tagID = value; }
        }

        public override string GetInfo()
        {
            string info = string.Empty;
            info = base.GetInfo();
            info += "\r\nTag ID: " + m_tagID;
            return info;
        }
    }
}
