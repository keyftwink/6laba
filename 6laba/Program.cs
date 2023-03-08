namespace _6laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Собака", "Мясо", "Будка");
            Cat cat = new Cat("Кот", "Кошачий корм", "Дом");
            Horse horse = new Horse("Лошадь", "Сено", "Конюшня");

            dog.makeNoise();
            cat.makeNoise();
            horse.makeNoise();

            Veterinarian veterinarian = new Veterinarian();
            veterinarian.treatAnimal(dog);
            veterinarian.treatAnimal(cat);
            veterinarian.treatAnimal(horse);
        }
    }
}