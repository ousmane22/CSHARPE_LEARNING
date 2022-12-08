using System;
using System.Collections.Generic;
using System.Text;

namespace transport
{
    public class Marchandise
    {
        public int Numero { get; set; }
        public double Poids { get; set; }

        public double Volume { get; set; }


        public Marchandise(int Numero , int Poids , int Volume)
        {
            this.Numero = Numero;
            this.Poids = Poids;
            this.Volume = Volume;
        }

        public override string ToString()
        {
            return "Numéro = " + Numero + "Poids = " + Poids + "Volume = " + Volume;
        }
    }
}
