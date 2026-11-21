using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat28
    {
        static void Main(string[] args)
        {
            Console.Write("Hány dolgozat eredménye van? ");
            int n = int.Parse(Console.ReadLine());
            List<int> jegyek = new List<int>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. diák jegye: ");
                jegyek.Add(int.Parse(Console.ReadLine()));
            }
            int i = 0;
            while (i < n && jegyek[i] != 5)
            {
                i++;
            }

            if (i < n)
            {
                Console.WriteLine($"Találtunk egy ötös dolgozatot a(z) {i + 1}. helyen");
            }
            else
            {
                Console.WriteLine("Nincs ötös dolgozat az adatok között");
            }
        }
    }
}