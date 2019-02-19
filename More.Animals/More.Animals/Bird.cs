using System;
using System.Collections.Generic;
using System.Text;

namespace More.Animals
{
    public class Bird : IAnimals
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void GoTo(string location)
        {
            Console.WriteLine($"Flying to {location}");
        }

        public void MakeNoise()
        {
            Console.WriteLine("CaCaw");
        }
    }
}
