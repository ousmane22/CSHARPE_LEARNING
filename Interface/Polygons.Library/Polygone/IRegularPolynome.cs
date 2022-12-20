using System;
using System.Collections.Generic;
using System.Text;

namespace Polygone
{
    interface IRegularPolynome
    {
        public int NumberOfSide { get; set; }
        public int SideLenght { get; set; }

        double GetPermeter();
        double GetArea();
    }
}
