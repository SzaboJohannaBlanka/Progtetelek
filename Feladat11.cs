using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat11
    {
        static void Main(string[] args)
        {
            Console.Write("Hány eleme legyen a számsornak? ");
            int n = int.Parse(Console.ReadLine());
            List<double> szamok = new List<double>();
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. szám: ");
                szamok.Add(double.Parse(Console.ReadLine()));
            }

            int i = 0;
            while (i < szamok.Count && szamok[i] >= -5)
            {
                i++;
            }

            if (i < szamok.Count)
            {
                Console.WriteLine($"Található -5-nél kisebb elem, e a(z) {i + 1}. elem: {szamok[i]}");
            }
            else
            {
                Console.WriteLine("Nincs -5-nél kisebb elem a sorban");
            }
        }
    }
}