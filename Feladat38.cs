using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat38
    {
        static void Main(string[] args)
        {
            Console.Write("Hányféle hozzávalóból áll az étel? ");
            int n = int.Parse(Console.ReadLine());

            List<double> mennyisegek = new List<double>();
            List<double> egysegarak = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. hozzávaló mennyisége: ");
                mennyisegek.Add(double.Parse(Console.ReadLine()));
                Console.Write($"{j + 1}. hozzávaló egységára: ");
                egysegarak.Add(double.Parse(Console.ReadLine()));
            }

            double osszkoltseg = 0;
            for (int i = 0; i < n; i++)
            {
                osszkoltseg += mennyisegek[i] * egysegarak[i];
            }

            Console.WriteLine($"Az étel teljes költsége: {osszkoltseg} Ft");
        }
    }
}