
namespace _6laba
{
    internal class Animal
    {

        string name;
        public string Name { get => name; }
        string food;
        public string Food { get => food; }
        string location;
        public string Location { get => location; }

        public Animal(string name, string food, string location)
        {
            this.name = name;
            this.food = food;
            this.location = location;
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("Животное издает звук");
        }

        public virtual void eat()
        {
            Console.WriteLine("Животное ест");

        }
        public virtual void sleep()
        {
            Console.WriteLine("Животное спит");

        }
    }
}
