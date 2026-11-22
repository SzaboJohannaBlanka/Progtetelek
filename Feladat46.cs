using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat46
    {
        static void Main(string[] args)
        {
            Console.Write("Hány mérést (N) végeztünk 5 km-enként? ");
            int n = int.Parse(Console.ReadLine());
            List<double> magassagok = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. mérés magassága (tengerszint felett m): ");
                magassagok.Add(double.Parse(Console.ReadLine()));
            }
            int i = 0;
            while (i < n && magassagok[i] >= 0)
            {
                i++;
            }
            bool jartTengerFelett = (i < n);
            bool sziget = false;
            if (jartTengerFelett)
            {
                int k = 0;
                while (k < n && magassagok[k] >= 0) k++;
                while (k < n && magassagok[k] < 0) k++; 
                int tengerutan = k;
                while (tengerutan < n && magassagok[tengerutan] <= 0) tengerutan++;

                if (tengerutan < n) sziget = true;
            }

            Console.WriteLine(jartTengerFelett ? "a) Jártunk a tenger felett" : "a) Nem jártunk a tenger felett");
            Console.WriteLine(sziget ? "b) Átrepültünk sziget felett" : "b) Nem repültünk át sziget felett");
        }
    }
}