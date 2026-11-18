using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat10
    {
        static void Main(string[] args)
        {
            Console.Write("Hány évszámot adsz meg? ");
            int n = int.Parse(Console.ReadLine());
            List<int> evszamok = new List<int>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. évszám: ");
                evszamok.Add(int.Parse(Console.ReadLine()));
            }

            int i = 0;
            while (evszamok[i] != 1222)
            {
                i++;
            }
            Console.WriteLine($"Az Aranybulla kiadásának évszáma (1222) a(z) {i + 1}. elem.");
        }
    }
}