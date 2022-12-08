using System;
using System.Collections.Generic;
using System.Text;

namespace transport
{
     class CargaisonRoutiere:Cargaison
    {
       public CargaisonRoutiere(int d):base(d)
        {
        }

        public override double cout()
        {
            if (VolumeTotalMarchandise() < 38000)
            {
                return 4 * Distance * PoidsTotalMarchandise();
            }
            else
                return 6 * Distance * PoidsTotalMarchandise();
        }

        public override string ToString()
        {
            return "Cargaison Routiére Distance " + Distance;
        }
    }
}
