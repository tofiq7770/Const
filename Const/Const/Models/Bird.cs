using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const.Models
{
    internal class Bird : Animal
    {
        public int Id { get; set; }
        public override void Sound()
        {
            Console.WriteLine("bird sound");
        }
    }
}
