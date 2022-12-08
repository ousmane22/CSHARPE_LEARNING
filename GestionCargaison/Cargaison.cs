using System;
using System.Collections.Generic;
using System.Text;

namespace transport
{
    public  abstract class Cargaison
    {
        public int Distance { get; set; }
        private List<Marchandise> marchandises = new List<Marchandise>();
      
        public  Cargaison(int d)
        {
            this.Distance = d;
        }

        public  void AddMarchandise(Marchandise marchandise)
        {
            marchandises.Add(marchandise);
        }

        public  void DisplayMarchandise()
        {
            foreach(Marchandise m in marchandises)
            {
                Console.WriteLine(m.ToString());
            }
        }


        public Marchandise ConsulterMarchandise(int numero)
        {
            foreach(Marchandise m in marchandises)
            {
                if (m.Numero == numero) return m;
            }
            throw new Exception("La marchandise n'existe pas");
        }

        public double VolumeTotalMarchandise()
        {
            double sum = 0;

            foreach(Marchandise m in marchandises)
            {
                sum += m.Volume;
            }
            return sum;
        }


        public double PoidsTotalMarchandise()
        {
            double poidTotal = 0;

            foreach (Marchandise m in marchandises)
            {
                poidTotal += m.Poids;
            }
            return poidTotal;
        }

        public abstract double cout();

        public List<Marchandise> GetMarchandises()
        {
            return marchandises;
        }


    }
}
