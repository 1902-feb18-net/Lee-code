using System;
using System.Collections.Generic;
using System.Text;

namespace More.Animals
{
    public class Dog : IAnimals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine("Woof");
        }

        public void GoTo(string location)
        {
            Console.WriteLine($"Moving to {location}");
        }
    }
}
