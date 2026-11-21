using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat29
    {
        static void Main(string[] args)
        {
            List<string> januarNevnapok = new List<string>(){"Újév", "Makariusz", "Genovéva", "Telma", "Simon", "Boldizsár", "Attila", "Gyöngyvér", "Marcell", "Melánia", "Ágota", "Ernő", "Veronika", "Bódog", "Boglárka", "Gusztáv", "Antal", "Piroska", "Sára", "Fábián", "Ágnes", "Vince", "Zelma", "Timót", "Pál", "Vanda", "Angelika", "Károly", "Adél", "Martina", "Marcella"};
            int i = 0;
            while (i < januarNevnapok.Count && januarNevnapok[i] != "Mária")
            {
                i++;
            }
            if (i < januarNevnapok.Count)
            {
                Console.WriteLine($"Januárban Mária napja van január {i + 1}-én");
            }
            else
            {
                Console.WriteLine("Nincs Mária nevű névnap ekkor");
            }
        }
    }
}