using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat30
    {
        static void Main(string[] args)
        {
            Console.Write("Hány hegy adatait adod meg? ");
            int n = int.Parse(Console.ReadLine());
            List<string> hegyNevek = new List<string>();
            List<double> magassagok = new List<double>();
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. hegy neve: ");
                hegyNevek.Add(Console.ReadLine());
                Console.Write($"{j + 1}. hegy magassága (m): ");
                magassagok.Add(double.Parse(Console.ReadLine()));
            }

            int max = 0;
            for (int i = 1; i < n; i++)
            {
                if (magassagok[i] > magassagok[max])
                {
                    max = i;
                }
            }

            Console.WriteLine($"A legmagasabb hegy: {hegyNevek[max]} ({magassagok[max]} m)");
        }
    }
}