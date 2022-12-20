using System;
using System.Collections.Generic;
using System.Text;

namespace Polygone
{
    class ConcreteRegularPolynome
    {
        public int NumberOfSide { get; set; }
        public int SideLenght { get; set; }

        public ConcreteRegularPolynome(int NumofSide ,int SideLenght)
        {
            this.NumberOfSide = NumberOfSide;
            this.SideLenght = SideLenght;
        }

        public double getPerimetre()
        {
            return NumberOfSide * SideLenght;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
