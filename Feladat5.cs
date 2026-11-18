using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat5
    {
        static void Main(string[] args)
        {
            List<string> napok = new List<string>() { "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap" };
            Console.Write("Adj meg egy szót: ");
            string szo = Console.ReadLine().ToLower();

            int i = 0;
            while (i < napok.Count && napok[i] != szo) { i++; }
            bool van = (i < napok.Count);
            Console.WriteLine(van ? "Ez egy nap neve." : "Ez nem egy nap neve.");
        }
    }
}