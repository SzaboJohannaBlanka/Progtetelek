using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat31
    {
        static void Main(string[] args)
        {
            List<double> homersekletek = new List<double>() { -12, -8, 2, -2, -3, 4, 2, -2, 6, 3, 1, -5 };
            Console.Write("Szeretnéd saját adatokkal megadni a hőmérsékleteke (igen/nem): ");
            if (Console.ReadLine().ToLower() == "igen")
            {
                homersekletek.Clear();
                Console.Write("Hány mérés van? ");
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{j + 1}. hőmérséklet: ");
                    homersekletek.Add(double.Parse(Console.ReadLine()));
                }
            }

            int db = 0;
            for (int i = 0; i < homersekletek.Count; i++)
            {
                if (homersekletek[i] < 0)
                {
                    db++;
                }
            }

            Console.WriteLine($"Fagypont alatt mért adatok száma: {db}");
        }
    }
}