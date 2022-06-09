using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Diminisher : Ship
    {
        public override void Attack()
        {
            Console.WriteLine("Atakuje cie inaczej");
        }

    }
}
