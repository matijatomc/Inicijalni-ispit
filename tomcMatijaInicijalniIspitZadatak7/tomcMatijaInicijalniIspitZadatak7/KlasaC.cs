using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak7
{
    class KlasaC
    {
        public int Zbroj(int[] niz)
        {
            int zbroj = 0;

            for(int i = 0; i < 5; i++)
            {
                zbroj = zbroj + niz[i];
            }

            return zbroj;
        }
        
        public double Prosjek(int[] niz)
        {
            double zbroj = Convert.ToDouble(Zbroj(niz));
            double projek = zbroj / 5;

            return projek;
        }
    }
}
