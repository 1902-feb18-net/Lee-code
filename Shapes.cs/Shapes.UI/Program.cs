using System;
using Shapes.cs;

namespace Shapes.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hex1 = new Hexagon()
            {
                Sides = 6,
                Name = "Future Hexagonal Prism"
            };
            var Tri1 = new Triangle()
            {
                Sides = 3,
                Name = "Triangle RolePlaying a Circle"
            };

            Console.WriteLine($"Hello! My name is {Hex1.Name} and I have {Hex1.Sides} sides but I really want to be 3D." +
                $" For now I have {Hex1.Corners} corners but I'll have more soon!");

            Console.WriteLine($"Hi, I'm {Tri1.Name} and I don't like having {Tri1.Sides} solid sides." +
                $" I really want to be free of my {Tri1.Corners} corners too and be able to roll free.");
        }
    }
}
