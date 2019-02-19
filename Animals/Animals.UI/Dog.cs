using System;

namespace Animals.UI
{
    public class Dog
    {
        public string Noise = "Bark";
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