﻿using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.GoTo("door");
            dog.SetNoise();
            dog.MakeNoise();
            dog.Name = "Scotch";
           
            Console.WriteLine(dog.Name);
        }
    }
}
