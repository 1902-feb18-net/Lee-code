using System;
using System.Collections.Generic;

namespace Animals.Library
{
    public class Dog
    {
        public string Noise = "Bark!";
        
        public List<string> myList = new List<string>();
        public string getNoise()
        {
            return Noise;
        }

        public void SetNoise()
        {
            /*if (newNoise == null || newNoise.Length == 0)
            {
                throw new ArgumentException("New noise must not be null or empty.");
            }
            Noise = newNoise;*/
            myList.Add("Woof");
            myList.Add("Bark");
            myList.Add("Arf");

            Random rand = new Random();
            int num = rand.Next(0,1);
            Console.WriteLine(num);
            Noise = myList[num];
        }

        public int Id{ get; set; } = 0;

        public string Name { get; set; }

        public string Color { get; } = "brown";

        // properties have a shortcut of "'prop' + tab"
        
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