using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat24
    {
        static void Main(string[] args)
        {
            int napokSzama = 30;
            List<double> vasarlasok = new List<double>();

            for (int j = 0; j < napokSzama; j++)
            {
                Console.Write($"Múlt hónap {j + 1}. napi vásárlás összege (Ft): ");
                vasarlasok.Add(double.Parse(Console.ReadLine()));
            }

            int db = 0;
            for (int i = 0; i < vasarlasok.Count; i++)
            {
                if (vasarlasok[i] > 5000)
                {
                    db++;
                }
            }

            Console.WriteLine($"5000 Ft felett hányszor vásárolt: {db} alkalommal");
        }
    }
}