using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat1
    {
        static void Main(string[] args)
        {
            List<double> eredmenyekList = new List<double>() { 1,2,3,4,5,6 };
            double osszEredmeny = 0;
            for (int i = 0; i < eredmenyekList.Count; i++)
            {
                osszEredmeny += eredmenyekList[i];
            }
            double atlag = osszEredmeny / eredmenyekList.Count;
            Console.WriteLine(atlag);
        }
    }
}
