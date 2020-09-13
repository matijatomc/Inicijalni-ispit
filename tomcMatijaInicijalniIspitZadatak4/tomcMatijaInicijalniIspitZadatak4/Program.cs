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

            for (int i = 0; i < 32; i++)
            {
                RandomGenerator generator = new RandomGenerator();
                tenisac1 = generator.RandomNumber(1, 32);
                tenisac2 = generator.RandomNumber(1, 32);

                
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
