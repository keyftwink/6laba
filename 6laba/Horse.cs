using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6laba
{
    internal class Horse : Animal
    {

        string snort = "ржет";
        public Horse(string name, string food, string location) : base(name, food, location)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Лошадь " + snort);
        }

        public override void eat()
        {
            Console.WriteLine("Лошадь ест");

        }
        public override void sleep()
        {
            Console.WriteLine("Лошадь спит");

        }
    }
}
