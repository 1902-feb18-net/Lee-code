using System;

namespace Animals.Library
{
    public class Dog
    {
        public string Noise = "Bark!";
        public void GoTo(string location)
        {
            Console.WriteLine($"Walking to {location}");
        }

        public void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
}