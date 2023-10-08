using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const.Models
{
    internal class Person
    {
        public string name { get; set; }
        public string surename { get; set; }

        public override string ToString()
        {
            return name + " " + surename;
        }
    }
}
