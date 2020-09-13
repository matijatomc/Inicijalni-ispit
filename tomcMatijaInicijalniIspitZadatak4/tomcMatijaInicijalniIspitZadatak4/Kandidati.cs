using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak4
{
    class Kandidati
    {
        public int redniBroj;

        public override string ToString()
        {
            string kandidat;
            kandidat = "Tenisac " + redniBroj;
            
            return kandidat;
        }
    }
}
