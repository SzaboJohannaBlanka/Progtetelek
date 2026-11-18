using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat4
    {
        static void Main(string[] args)
        {
            Console.Write("Hány tantárgya van a tanulónak? ");
            int n = int.Parse(Console.ReadLine());
            List<int> jegyek = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. jegy: ");
                jegyek.Add(int.Parse(Console.ReadLine()));
            }

            int idx = 0;
            while (idx < jegyek.Count && jegyek[idx] == 5)
            {
                idx++;
            }

            bool kituno = (idx >= jegyek.Count);
            Console.WriteLine(kituno ? "A tanuló kitűnő." : "A tanuló nem kitűnő.");
        }
    }
}