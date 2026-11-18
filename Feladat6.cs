using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat6
    {
        static void Main(string[] args)
        {
            int napokSzama = 30;
            List<double> homersekletek = new List<double>();
            for (int j = 0; j < napokSzama; j++)
            {
                Console.Write($"Szeptember {j + 1}. napi hőmérséklet: ");
                homersekletek.Add(double.Parse(Console.ReadLine()));
            }
            int i = 0;
            while (i < homersekletek.Count - 1 && homersekletek[i] >= homersekletek[i + 1])
            {
                i++;
            }
            bool monotonFogyo = (i >= homersekletek.Count - 1);
            Console.WriteLine(monotonFogyo ? "Monoton fogyó." : "Nem monoton fogyó.");
        }
    }
}