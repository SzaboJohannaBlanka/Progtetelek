using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat21
    {
        static void Main(string[] args)
        {
            Console.Write("Hány szám legyen a sorozatban? ");
            int n = int.Parse(Console.ReadLine());
            List<double> szamok = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. szám: ");
                szamok.Add(double.Parse(Console.ReadLine()));
            }

            double min = szamok[0];
            double max = szamok[0];

            for (int i = 1; i < szamok.Count; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"A legkisebb szám: {min}");
            Console.WriteLine($"A legnagyobb szám: {max}");
        }
    }
}