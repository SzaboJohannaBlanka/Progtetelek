using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat43
    {
        static void Main(string[] args)
        {
            Console.Write("Hány eleme legyen az A vektornak? ");
            int n = int.Parse(Console.ReadLine());
            List<double> a = new List<double>();
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. elem: ");
                a.Add(double.Parse(Console.ReadLine()));
            }
            int negativDb = 0;
            int nullaDb = 0;
            int pozitivDb = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0) negativDb++;
                else if (a[i] == 0) nullaDb++;
                else pozitivDb++;
            }

            Console.WriteLine($"Negatív elemek száma: {negativDb}");
            Console.WriteLine($"Nulla értékű elemek száma: {nullaDb}");
            Console.WriteLine($"Pozitív elemek száma: {pozitivDb}");
        }
    }
}