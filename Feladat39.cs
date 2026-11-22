using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat39
    {
        static void Main(string[] args)
        {
            Console.Write("Hány eleme legyen a vektornak? ");
            int n = int.Parse(Console.ReadLine());
            List<double> v = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. elem: ");
                v.Add(double.Parse(Console.ReadLine()));
            }
            int i = 0;
            while (i < n && v[i] != 0)
            {
                i++;
            }
            int db = 0;
            if (i < n)
            {
                for (int k = i + 1; k < n; k++)
                {
                    if (v[k] < 0)
                    {
                        db++;
                    }
                }
                Console.WriteLine($"Az első nulla utáni negatív elemek száma: {db}");
            }
            else
            {
                Console.WriteLine("Nincs nulla értékű elem a vektorban");
            }
        }
    }
}