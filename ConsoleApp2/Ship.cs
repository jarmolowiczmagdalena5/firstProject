using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ship
    {
        public int hp = 360000;
        public int shield = 400000;
        public int generations = 16;
        public int lasers = 30;
        public int speed = 360;

        public virtual void Move()
        {
            Console.WriteLine("Lece");
        }
        public virtual void Attack()
        {
            Console.WriteLine("Zniszcze cie");
        }
    }
}
