using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat12
    {
        static void Main(string[] args)
        {
            Console.Write("Hány nap adatait adod meg? ");
            int n = int.Parse(Console.ReadLine());
            List<double> bevetelek = new List<double>();
            List<double> kiadasok = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. nap bevétele: ");
                bevetelek.Add(double.Parse(Console.ReadLine()));
                Console.Write($"{j + 1}. nap kiadása: ");
                kiadasok.Add(double.Parse(Console.ReadLine()));
            }

            int i = 0;
            while (i < n && bevetelek[i] >= kiadasok[i])
            {
                i++;
            }

            if (i < n)
            {
                Console.WriteLine($"A(z) {i + 1}. nap nem volt nyereséges.");
            }
            else
            {
                Console.WriteLine("Minden nap nyereséges volt.");
            }
        }
    }
}
