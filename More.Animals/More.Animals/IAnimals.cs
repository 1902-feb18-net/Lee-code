using System;
using System.Collections.Generic;
using System.Text;

namespace More.Animals
{
    public interface IAnimals
    {
        int Id{ get; set; }
        string Name { get; set; }
        void MakeNoise();
        void GoTo(string location);
    }
}
