using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const.Models
{
    internal class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string SureName { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
    }
}
