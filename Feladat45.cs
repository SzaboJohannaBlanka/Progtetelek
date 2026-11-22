using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat45
    {
        static void Main(string[] args)
        {
            Console.Write("Hány ülőhely van összesen a vonaton? ");
            int osszesHely = int.Parse(Console.ReadLine());

            Console.Write("Hány helyjegyet adtak ki eddig? ");
            int kiadott = int.Parse(Console.ReadLine());

            List<bool> helyek = new List<bool>(osszesHely);
            for (int j = 0; j < osszesHely; j++)
            {
                helyek.Add(j < kiadott);
            }

            int i = 0;
            while (i < osszesHely && helyek[i] == true)
            {
                i++;
            }

            bool vanSzabad = (i < osszesHely);
            Console.WriteLine(vanSzabad ? "Van még szabad hely a vonaton." : "A vonat teljesen telt házas (nincs szabad hely).");
        }
    }
}