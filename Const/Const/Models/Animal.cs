using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const.Models
{
    internal class Animal
    {
        public int id { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
