using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat13
    {
        static void Main(string[] args)
        {
            Console.Write("Hány érkezési adat van? ");
            int n = int.Parse(Console.ReadLine());
            List<int> percek = new List<int>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. érkezés: ");
                percek.Add(int.Parse(Console.ReadLine()));
            }
            int i = 0;
            while (i < n && !(percek[i] >= 450 && percek[i] <= 465))
            {
                i++;
            }

            if (i < n)
            {
                int ora = percek[i] / 60;
                int perc = percek[i] % 60;
                Console.WriteLine($"Találtunk megfelelő időpontot: {ora}:{perc:D2}");
            }
            else
            {
                Console.WriteLine("Nincs érkezés 1/2 8 és 3/4 8 között.");
            }
        }
    }
}