using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class Solace : Ship
    {
        int lasers = 31;
        public void Healing()
        {
            Console.WriteLine("Lecze sie");
        }
        public void GetStatistics()
        {
            Console.WriteLine(lasers+ " " + hp + " " + shield + " " + generations);
        }
    }
}
