using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat44
    {
        static void Main(string[] args)
        {
            Console.Write("Hány szó van az R szósorozatban? ");
            int n = int.Parse(Console.ReadLine());
            List<string> szavak = new List<string>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. szó: ");
                szavak.Add(Console.ReadLine());
            }
            char[] magas = { 'e', 'é', 'i', 'í', 'ö', 'ő', 'ü', 'ű' };
            char[] mely = { 'a', 'á', 'o', 'ó', 'u', 'ú' };

            int magasDb = 0, melyDb = 0, vegyesDb = 0;
            for (int i = 0; i < n; i++)
            {
                string szo = szavak[i].ToLower();
                bool vanMagas = false;
                bool vanMely = false;

                for (int k = 0; k < szo.Length; k++)
                {
                    char c = szo[k];
                    if (Array.Exists(magas, m => m == c)) vanMagas = true;
                    if (Array.Exists(mely, m => m == c)) vanMely = true;
                }

                if (vanMagas && !vanMely) magasDb++;
                else if (!vanMagas && vanMely) melyDb++;
                else if (vanMagas && vanMely) vegyesDb++;
            }

            Console.WriteLine($"Magas hangrendű szavak száma: {magasDb}");
            Console.WriteLine($"Mély hangrendű szavak száma: {melyDb}");
            Console.WriteLine($"Vegyes hangrendű szavak száma: {vegyesDb}");
        }
    }
}