using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat16
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a versszak szövegét: ");
            string versszak = Console.ReadLine();

            List<char> maganhangzok = new List<char>() { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            int db = 0;

            for (int i = 0; i < versszak.Length; i++)
            {
                char karakter = char.ToLower(versszak[i]);
                if (maganhangzok.Contains(karakter))
                {
                    db++;
                }
            }

            Console.WriteLine($"A magánhangzók száma a versszakban: {db}");
        }
    }
}