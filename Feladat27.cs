using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat27
    {
        static void Main(string[] args)
        {
            int napokSzama = 30;
            List<double> homersekletek = new List<double>();

            for (int j = 0; j < napokSzama; j++)
            {
                Console.Write($"Múlt hónap {j + 1}. napi dduna hőmérséklet: ");
                homersekletek.Add(double.Parse(Console.ReadLine()));
            }

            int i = 0;
            while (i < homersekletek.Count - 1 && homersekletek[i] < homersekletek[i + 1])
            {
                i++;
            }

            bool igen = (i >= homersekletek.Count - 1);
            Console.WriteLine(igen ? "A víz hőmérséklete emelkedett." : "A víz hőmérséklete nem emelkedett");
        }
    }
}