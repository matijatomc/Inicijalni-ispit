using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaInicijalniIspitZadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            int brc = 0;

            Console.WriteLine("Sve moguce kominacije LOTO 7/39: ");

            for (int i = 1; i<  40; i++)
            {
                for(int j=1; j<40; j++)
                {
                    if (j == i) { j++; }

                    for(int k = 1; k < 40; k++)
                    {
                        if(k != i && k != j)
                        {
                            for(int l = 1; l < 40; l++)
                            {
                                if (l != i && l != j && l != k)
                                {
                                    for (int o = 1;o < 40; o++)
                                    {
                                        if (o != i && o != j && o != k && o != l)
                                        {
                                            for(int p=1; p < 40; p++)
                                            {
                                                if (p != i && p != j && p != k && p != l && p != o)
                                                {
                                                    for(int r = 1; r < 40; r++)
                                                    {
                                                        if (r != i && r != j && r != k && r != l && r != o && r != p)
                                                        {
                                                            Console.WriteLine($"{i} {j} {k} {l} {o} {p} {r}");
                                                            brc++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Broj kombinacija: {brc}");
            Console.ReadKey();
        }
    }
}
