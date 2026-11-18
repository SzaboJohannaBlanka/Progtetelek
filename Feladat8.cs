using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat8
    {
        static void Main(string[] args)
        {
            List<string> honapok = new List<string>()
            {
                "január", "február", "március", "április", "május", "június",
                "július", "augusztus", "szeptember", "október", "november", "december"
            };

            Console.Write("Add meg a hónap nevét: ");
            string keresettHonap = Console.ReadLine().ToLower();
            int i = 0;
            while (honapok[i] != keresettHonap)
            {
                i++;
            }
            int sorszam = i + 1;
            Console.WriteLine($"A hónap sorszáma: {sorszam}");
        }
    }
}