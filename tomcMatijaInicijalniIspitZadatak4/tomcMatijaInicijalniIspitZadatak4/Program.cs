using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kandidati> kandidati = new List<Kandidati>();
            int tenisac1;
            int tenisac2;
            int brUtakmice=1;

            RandomGenerator generator = new RandomGenerator();
            tenisac1 = generator.RandomNumber(1, 32);
            kandidati.Add(new Kandidati() { redniBroj = tenisac1 });

            do
            {
                tenisac2 = generator.RandomNumber(1, 32);
            } while (tenisac2 == tenisac1);
            kandidati.Add(new Kandidati() { redniBroj = tenisac2 });

            Console.WriteLine($"{brUtakmice}. utakmica je između: Tenisaca {}");
            for (int i = 0; i < 30; i++)
            {
                
                
            }
        }

        public class RandomGenerator
        {
            public int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
        }
    }
}
