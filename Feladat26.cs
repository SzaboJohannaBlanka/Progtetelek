using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat26
    {
        static void Main(string[] args)
        {
            Console.Write("Hány szó van a listában? ");
            int n = int.Parse(Console.ReadLine());
            List<string> szavak = new List<string>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. szó: ");
                szavak.Add(Console.ReadLine());
            }

            int db = 0;
            for (int i = 0; i < szavak.Count; i++)
            {
                if (!string.IsNullOrEmpty(szavak[i]))
                {
                    char kezdokarater = char.ToLower(szavak[i][0]);
                    if (kezdokarater == 'b')
                    {
                        db++;
                    }
                }
            }
            Console.WriteLine($"B betűvel kezdődő szavak száma: {db}");
        }
    }
}