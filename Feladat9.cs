using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat9
    {
        static void Main(string[] args)
        {
            List<string> nevnapok = new List<string>()
            {
                "Malvin", "Petra", "Helga", "Ferenc", "Aurél", "Brúnó", "Amália", "Koppány", "Dénes", "Gedeon",
                "Brigitta", "Miksa", "Kálmán", "Helén", "Teréz", "Gál", "Hedvig", "Lukács", "Nándor", "Vendel",
                "Orsolya", "Előd", "Gyöngyi", "Salamon", "Blanka", "Dömötör", "Szabina", "Simon", "Nárcisz", "Alfonz", "Farkas"
            };

            int i = 0;
            while (nevnapok[i] != "Lukács")
            {
                i++;
            }

            Console.WriteLine($"Lukács névnapja október {i + 1}-én van.");
        }
    }
}