using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6laba
{
    internal class Veterinarian
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine("Приём у ветеринара");
            Console.WriteLine($"\tЖивотное: {animal.Name} \tЕда: {animal.Food} \tРасположение: {animal.Location}");
        }
    }   
}
