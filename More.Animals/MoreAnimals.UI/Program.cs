using System;
using More.Animals;


namespace MoreAnimals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var scotch = new Dog();
            scotch.Id = 1;
            scotch.Name = "Scotch";
            scotch.Breed = "Labrodoodle";

            var badge = new Dog()
            {
                Id = 2,
                Name = "badge",
                Breed = "Airedale"
            };

            scotch.GoTo("Window");
            scotch.MakeNoise();

            IAnimals animal = scotch;

            var animals = new IAnimals[4];
            animals[0] = scotch;
            animals[1] = badge;
            animals[2] = new Bird
            {
                Name = "Olive",
                Id = 3
            };
            animals[3] = new Dog
            {
                Name = "Sam",
                Id = 4
            };

            foreach(IAnimals item in animals)
            {
                Console.WriteLine(item.Name);
                item.MakeNoise();
            }
            //MakeNoise(animals[3]);
        }
    }
}
