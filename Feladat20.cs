using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat20
    {
        static void Main(string[] args)
        {
            List<string> honapok = new List<string>()
            {
                "január", "február", "március", "április", "május", "június",
                "július", "augusztus", "szeptember", "október", "november", "december"
            };

            List<double> megtakaritasok = new List<double>();

            for (int j = 0; j < honapok.Count; j++)
            {
                Console.Write($"{honapok[j]} havi megtakarítás: ");
                megtakaritasok.Add(double.Parse(Console.ReadLine()));
            }

            int maxIndex = 0;
            for (int i = 1; i < megtakaritasok.Count; i++)
            {
                if (megtakaritasok[i] > megtakaritasok[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"A legtöbbet {honapok[maxIndex]} hónapban tudtak megtakarítani ({megtakaritasok[maxIndex]} Ft-ot)");
        }
    }
}