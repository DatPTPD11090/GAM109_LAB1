using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bai2
{

    public class Maps
    {
        public string ID;
        public string Name;


        public Maps() { }

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
        }


        public string ShowData()
        {
            return "ID" + ID + " | Name " + Name;
        }
    }
}