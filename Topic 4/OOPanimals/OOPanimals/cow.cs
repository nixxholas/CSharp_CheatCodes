using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPanimals
{
    class cow : Animal
    {
        private string m_tagId;

        public cow (int a, double w, string t) : base (a, w)
        {
            m_tagId = t;
        }

        public cow(string t)
        {
            m_tagId = t;
        }
        public string TagId
        {
            get { return m_tagId; }
            set { m_tagId = value; }
        }
        public string getCowInfo()
        {
            string info = string.Empty;
            info = base.GetInfo();
            info += "\r\nTagId: " + m_tagId;
            return info;
        }
    }
}
