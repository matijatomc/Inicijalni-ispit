using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            int br;

            Console.WriteLine("Upišite neki broj: ");
            br = Convert.ToInt32(Console.ReadLine());

            if(br % 4 == 0 && br % 6 == 0)
            {
                Console.WriteLine("Broj je dijeljiv sa 4 i sa 6");
            }else if (br % 4 == 0)
            {
                Console.WriteLine("Broj je dijeljiv sa 4 ");
            }
            else if (br % 6 == 0)
            {
                Console.WriteLine("Broj je dijeljiv sa 6 ");
            }
            else
            {
                Console.WriteLine("Broj nije dijeljiv sa 4 ni sa 6");
            }

            Console.ReadKey();
        }
    }
}
