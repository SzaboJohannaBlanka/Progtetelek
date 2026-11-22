using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat41
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az értelmes szöveget: ");
            string szoveg = Console.ReadLine();

            char[] mondatZarok = { '.', '!', '?' };
            string[] mondatok = szoveg.Split(mondatZarok);
            int mondatSzam = mondatok.Length;

            char[] szeparatorok = { ' ', '.', ',', '!', '?', ';', ':', '-' };
            string[] szavak = szoveg.Split(szeparatorok);
            int szoSzam = szavak.Length;
            Console.WriteLine($"A szöveg mondatainak száma: {mondatSzam}");
            Console.WriteLine($"A szöveg szavainak összes száma: {szoSzam}");
            if (mondatSzam > 0)
            {
                Console.WriteLine($"Átlagosan {(double)szoSzam / mondatSzam:F2} szó jut egy mondatra");
            }
        }
    }
}