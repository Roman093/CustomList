using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Notebook
    {

        public Notebook(int serialnumber, string name)
        {
            Name = name;
            SerialNumber = serialnumber;
        }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
    }
}


