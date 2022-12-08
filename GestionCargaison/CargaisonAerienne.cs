using System;
using System.Collections.Generic;
using System.Text;

namespace transport
{
    class CargaisonAerienne:Cargaison
    {
        public CargaisonAerienne(int d):base(d)
        {
        }

        public override double cout()
        {
            if (VolumeTotalMarchandise() < 38000)
            {
                return 10 * Distance * PoidsTotalMarchandise();
            }
            else
                return 12 * Distance * PoidsTotalMarchandise();
        }


        public override string ToString()
        {
            return "Cargaison Aérienne distance " + Distance;
        }
    }
}
