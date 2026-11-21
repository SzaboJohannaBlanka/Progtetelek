using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat23
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a mondatot: ");
            string mondat = Console.ReadLine();

            int db = 0;
            for (int i = 0; i < mondat.Length; i++)
            {
                char c = char.ToLower(mondat[i]);
                if (c == 'e')
                {
                    db++;
                }
            }

            Console.WriteLine($"Az 'e' betűk száma a mondatban: {db}");
        }
    }
}