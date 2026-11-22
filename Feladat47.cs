using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat47
    {
        static void Main(string[] args)
        {
            Console.Write("Hány tanuló van az osztály névsorában? ");
            int n = int.Parse(Console.ReadLine());
            List<string> nevek = new List<string>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. tanuló neve: ");
                nevek.Add(Console.ReadLine());
            }
            int maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (nevek[i].Length > nevek[maxIndex].Length)
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"A leghosszabb nevű tanuló: {nevek[maxIndex]} {nevek[maxIndex].Length} karakter");
        }
    }
}