using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int unos;
            int min;
            int sek;

            Console.WriteLine("Unesite broj sekundi, a program će ispisati koliko je to minuta: ");
            unos = Convert.ToInt32(Console.ReadLine());

            min = unos / 60;
            sek = unos % 60;

            Console.WriteLine(unos + " sekundi je: " + min + " minuta i " + sek + " sekundi");

            Console.ReadKey();
        }
    }
}
