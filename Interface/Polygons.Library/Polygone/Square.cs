using System;
using System.Collections.Generic;
using System.Text;

namespace Polygone
{
    class Square:AbstractRegularPolynome
    {
        public Square(int SideLenght) :base(4, SideLenght)
        {

        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
