using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Aegis : Ship
    {
        int hp = 300000;
        int shield = 220000;

        public void Healer()
        {
            Console.WriteLine("Lecze cie");
        }
    }
}
