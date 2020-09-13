using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;        
            string sVelika;
            string sMala;
            string sPrvaTri;
            string sZadnjihPet;
            string s8_11;

            Console.WriteLine("Unišite neki niz znakova: ");
            s = Console.ReadLine();

            sVelika = s.ToUpper();
            sMala = s.ToLower();
            sPrvaTri = s.Substring(0, 3);

            if (s.Length < 5)
            {
                sZadnjihPet = "Nema 5 znakova";
            }
            else
            {
                sZadnjihPet = s.Substring(s.Length - 5);
            }

            if (s.Length > 10)
            {
                s8_11 = s.Substring(7, 4);
            }
            else
            {
                s8_11 = "Nema 11 znakova";
            }

            Console.WriteLine("\nSve velikim: " + sVelika + "\nSve malim: " + sMala + "\nPrva tri: " + sPrvaTri + "\nZadnjih pet: " + sZadnjihPet + "\nOd 8 do 11: " + s8_11);
            Console.ReadKey();
        }
    }
}
