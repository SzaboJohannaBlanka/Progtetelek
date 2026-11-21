using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat22
    {
        static void Main(string[] args)
        {
            Console.Write("Hány egész szám van a sorban? ");
            int n = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. egész szám: ");
                szamok.Add(int.Parse(Console.ReadLine()));
            }

            int db1 = 0, db2 = 0, db3 = 0, db4 = 0;

            for (int i = 0; i < szamok.Count; i++)
            {
                int szam = Math.Abs(szamok[i]);
                if (szam >= 0 && szam <= 9) db1++;
                else if (szam >= 10 && szam <= 99) db2++;
                else if (szam >= 100 && szam <= 999) db3++;
                else if (szam >= 1000 && szam <= 9999) db4++;
            }

            Console.WriteLine($"1 jegyűek száma: {db1}");
            Console.WriteLine($"2 jegyűek száma: {db2}");
            Console.WriteLine($"3 jegyűek száma: {db3}");
            Console.WriteLine($"4 jegyűek száma: {db4}");
        }
    }
}