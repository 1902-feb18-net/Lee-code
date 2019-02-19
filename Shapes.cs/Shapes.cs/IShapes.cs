using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.cs
{
    public interface IShapes
    {
        int Sides { get; set; }
        string Name { get; set; }
        int Corners{ get; }
    }
}
