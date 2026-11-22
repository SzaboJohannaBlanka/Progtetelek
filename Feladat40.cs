using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat40
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a szöveget: ");
            string szoveg = Console.ReadLine();
            string[] szavak = szoveg.Split(new char[] { ' ', '.', ',', '!', '?' });
            int db = 0;
            for (int i = 0; i < szavak.Length; i++)
            {
                string szo = szavak[i].ToLower();
                if (szo == "a" || szo == "az")
                {
                    db++;
                }
            }

            Console.WriteLine($"Az a/az száma a szövegben: {db}");
        }
    }
}