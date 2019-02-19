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
    }
}
