using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat32
    {
        static void Main(string[] args)
        {
            Console.Write("Hány vízállás mérés adata van? ");
            int n = int.Parse(Console.ReadLine());
            List<double> vizallasok = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. vízállás (m): ");
                vizallasok.Add(double.Parse(Console.ReadLine()));
            }

            int i = 0;
            while (i < n && vizallasok[i] != 9.2)
            {
                i++;
            }

            bool volt = (i < n);
            Console.WriteLine(volt ? "Volt 9.2 méteres mérés" : "Nem volt 9.2 méteres mérés");
        }
    }
}