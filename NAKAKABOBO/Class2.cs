using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAKAKABOBO
{
    class Class2
    {
        public static string ID;
        public static string LastName
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
