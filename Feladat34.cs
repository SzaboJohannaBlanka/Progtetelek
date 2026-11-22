using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat34
    {
        static void Main(string[] args)
        {
            Console.Write("Hány lottószámot húztak ki? ");
            int n = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. lottószám: ");
                szamok.Add(int.Parse(Console.ReadLine()));
            }

            int i = 0;
            while (i < n && szamok[i] != 55)
            {
                i++;
            }

            bool kihuztak = (i < n);
            Console.WriteLine(kihuztak ? "Kihúzták az 55-ös számot" : "Nem húzták ki az 55-ös számot");
        }
    }
}
