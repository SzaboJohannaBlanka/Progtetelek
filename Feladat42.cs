using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat42
    {
        static void Main(string[] args)
        {
            Console.Write("Hány eleme van a növekvően rendezett vektornak? ");
            int n = int.Parse(Console.ReadLine());
            List<double> a = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. elem: ");
                a.Add(double.Parse(Console.ReadLine()));
            }

            int kulonbozoDb = 0;
            if (n > 0)
            {
                kulonbozoDb = 1;
                for (int i = 1; i < n; i++)
                {
                    if (a[i] != a[i - 1])
                    {
                        kulonbozoDb++;
                    }
                }
            }

            Console.WriteLine($"Értékek száma: {kulonbozoDb}");
        }
    }
}