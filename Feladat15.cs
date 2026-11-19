using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat15
    {
        static void Main(string[] args)
        {
            Console.Write("Hány diák futotta le a versenyt? ");
            int n = int.Parse(Console.ReadLine());
            List<bool> ötösSzint = new List<bool>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"Elérte a(z) {j + 1}. diák az 5-ös szintet? (igen/nem): ");
                string valasz = Console.ReadLine().ToLower();
                ötösSzint.Add(valasz == "igen" || valasz == "i");
            }

            int db = 0;
            for (int i = 0; i < ötösSzint.Count; i++)
            {
                if (ötösSzint[i])
                {
                    db++;
                }
            }

            double szazalek = (double)db / n * 100;
            Console.WriteLine($"A diákok {szazalek:F2}%-a teljesítette az 5-ös szintet.");
        }
    }
}