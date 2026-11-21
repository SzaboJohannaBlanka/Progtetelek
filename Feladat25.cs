using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat25
    {
        static void Main(string[] args)
        {
            Console.Write("Hány kutya indult a versenyen? ");
            int n = int.Parse(Console.ReadLine());
            List<double> pontszamok = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"A(z) {j + 1}. kutya pontszáma az 1. fordulóban: ");
                pontszamok.Add(double.Parse(Console.ReadLine()));
            }
            int db = 0;
            for (int i = 0; i < pontszamok.Count; i++)
            {
                if (pontszamok[i] < 20)
                {
                    db++;
                }
            }

            Console.WriteLine($"A kizárt kutyák száma: {db}");
        }
    }
}