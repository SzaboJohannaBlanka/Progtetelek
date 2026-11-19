using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat18
    {
        static void Main(string[] args)
        {
            Console.Write("Hány család adatait adod meg? ");
            int n = int.Parse(Console.ReadLine());

            List<int> letszamok = new List<int>();
            List<double> jovedelmek = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. család létszáma: ");
                letszamok.Add(int.Parse(Console.ReadLine()));
                Console.Write($"{j + 1}. család összes jövedelme: ");
                jovedelmek.Add(double.Parse(Console.ReadLine()));
            }

            Console.Write("Add meg az egy főre jutó létminimum összegét: ");
            double letminimum = double.Parse(Console.ReadLine());

            int db = 0;
            for (int i = 0; i < n; i++)
            {
                double egyForraJuto = jovedelmek[i] / letszamok[i];
                if (egyForraJuto < letminimum)
                {
                    db++;
                }
            }

            Console.WriteLine($"Létminimum alatt élők családok száma: {db}");
        }
    }
}