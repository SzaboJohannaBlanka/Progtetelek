using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat7
    {
        static void Main(string[] args)
        {
            Console.Write("Hány eleme legyen a sorozatnak? ");
            int n = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. szám: ");
                szamok.Add(int.Parse(Console.ReadLine()));
            }
            int i = 0;
            while (szamok[i] % 9 != 0)
            {
                i++;
            }
            Console.WriteLine($"Az első 9-cel osztható elem: {szamok[i]}");
        }
    }
}
