using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat3
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg N értékét: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;
            for (int i = 1; i <= n; i++)
            {
                osszeg += i;
            }
            Console.WriteLine($"Az első {n} természetes szám összege: {osszeg}");
        }
    }
}