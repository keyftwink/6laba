using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6laba
{
    internal class Dog : Animal
    {

        string bark = "гавкает";
        public Dog(string name, string food, string location) : base(name, food, location)
        {
          
        }
        public override void makeNoise()
        {
            Console.WriteLine("Собака " + bark);
        }

        public override void eat()
        {
            Console.WriteLine("Собака ест");

        }
        public override void sleep()
        {
            Console.WriteLine("Собака спит");

        }

    }
}
