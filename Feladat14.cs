using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat14
    {
        static void Main(string[] args)
        {
            Console.Write("Hány szám legyen a sorban? ");
            int n = int.Parse(Console.ReadLine());
            List<double> szamok = new List<double>();
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. szám: ");
                szamok.Add(double.Parse(Console.ReadLine()));
            }
            Console.Write("Add meg a határértéket: ");
            double hatar = double.Parse(Console.ReadLine());

            int db = 0;
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] < hatar)
                {
                    db++;
                }
            }

            Console.WriteLine($"A megadott értéknél kisebb számok darabszáma: {db}");
        }
    }
}