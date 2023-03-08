using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6laba
{
    internal class Cat : Animal
    {
        string meow = "мяукает";
        public Cat(string name, string food, string location) : base(name, food, location)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Кошка " + meow);
        }

        public override void eat()
        {
            Console.WriteLine("Кошка ест");

        }
        public override void sleep()
        {
            Console.WriteLine("Кошка спит");

        }
    }
}
