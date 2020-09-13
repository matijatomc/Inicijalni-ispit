using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak7
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaC c = new KlasaC();
            int[] niz = new int[5];

            Console.WriteLine("Upišite 5 brojeva: ");
            for(int i = 0; i < 5; i++)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }

            int zbroj = c.Zbroj(niz);
            double prosjek = c.Prosjek(niz);

            Console.WriteLine("Zbroj niza brojeva je: " + zbroj);
            Console.WriteLine("Prosjek niza brojeva je: " + prosjek);

            Console.ReadKey();
        }
    }
}
