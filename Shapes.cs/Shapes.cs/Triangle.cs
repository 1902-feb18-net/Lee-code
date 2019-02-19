using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.cs
{
    public class Triangle : IShapes
    {
        public int Sides { get; set; }
        public string Name { get; set; }
        public int Corners { get; } = 3;
        public int ang1 { get; set; }
        public int ang2 { get; set; }
        public int ang3 { get; set; }
        public bool isRight { get; set; }
    }
}
