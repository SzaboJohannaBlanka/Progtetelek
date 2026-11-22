using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat48
    {
        static void Main(string[] args)
        {
            Console.Write("Hány mélységi mérést végeztünk? ");
            int n = int.Parse(Console.ReadLine());
            List<double> melysegek = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. mélység: ");
                melysegek.Add(double.Parse(Console.ReadLine()));
            }
            int maxMerlegIndex = 0;
            double maxMeredekseg = 0;

            if (n > 1)
            {
                maxMeredekseg = Math.Abs(melysegek[1] - melysegek[0]);
                for (int i = 1; i < n - 1; i++)
                {
                    double kulonbseg = Math.Abs(melysegek[i + 1] - melysegek[i]);
                    if (kulonbseg > maxMeredekseg)
                    {
                        maxMeredekseg = kulonbseg;
                        maxMerlegIndex = i;
                    }
                }
            }

            Console.WriteLine($"A legmeredekebb szakasz a(z) {maxMerlegIndex + 1}. és {maxMerlegIndex + 2}. mérés között van különbség {maxMeredekseg} m");
        }
    }
}