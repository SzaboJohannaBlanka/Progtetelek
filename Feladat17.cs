using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat17
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az 1. versszakot: ");
            string v1 = Console.ReadLine();
            Console.Write("Add meg a 2. versszakot: ");
            string v2 = Console.ReadLine();

            List<char> maganhangzok = new List<char>() { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };

            int db1 = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                if (maganhangzok.Contains(char.ToLower(v1[i]))) db1++;
            }

            int db2 = 0;
            for (int i = 0; i < v2.Length; i++)
            {
                if (maganhangzok.Contains(char.ToLower(v2[i]))) db2++;
            }

            if (db1 > db2)
            {
                Console.WriteLine("Az első versszakban van több magánhangzó");
            }
            else
            {
                Console.WriteLine("A második versszakban van több magánhangzó");
            }
        }
    }
}