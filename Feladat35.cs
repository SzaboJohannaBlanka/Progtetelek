using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat35
    {
        static void Main(string[] args)
        {
            Console.Write("Hány könyv van a nyilvántartásban? ");
            int n = int.Parse(Console.ReadLine());
            List<string> konyvek = new List<string>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. könyv címe: ");
                konyvek.Add(Console.ReadLine());
            }

            int i = 0;
            while (i < n && konyvek[i].ToLower() != "egri csillagok")
            {
                i++;
            }

            bool bentVan = (i < n);
            Console.WriteLine(bentVan ? "Az Egri Csillagok bent van a könyvtárban" : "Az Egri Csillagok nincs bent a könyvtárban");
        }
    }
}