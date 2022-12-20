using System;
using System.Collections.Generic;
using System.Text;

namespace Polygone
{
   public abstract class AbstractRegularPolynome
    {
        public int NumberOfSide { get; set; }
        public int SideLenght { get; set; }

        public AbstractRegularPolynome(int NumofSide, int SideLenght)
        {
            this.NumberOfSide = NumberOfSide;
            this.SideLenght = SideLenght;
        }

        public double getPerimetre()
        {
            return NumberOfSide * SideLenght;
        }

        public abstract double GetArea();


    }
}
