using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat2
    {
        static void Main(string[] args)
        {
            List<char> betukList = new List<char>() { 'S', 'z', 'i', 'a' };
            string szoveg = "";
            for (int i = 0; i < betukList.Count; i++)
                szoveg += betukList[i];
            Console.WriteLine(szoveg);
        }
    }
}