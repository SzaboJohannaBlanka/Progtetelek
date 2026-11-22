using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat33
    {
        static void Main(string[] args)
        {
            Console.Write("Hány CPU ára szerepel a listában? ");
            int n = int.Parse(Console.ReadLine());
            List<double> arak = new List<double>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. CPU ára (Ft): ");
                arak.Add(double.Parse(Console.ReadLine()));
            }

            int i = 0;
            while (i < n && arak[i] >= 20000)
            {
                i++;
            }

            bool van = (i < n);
            Console.WriteLine(van ? "Van 20 ezer Ft-nál olcsóbb CPU." : "Nincs 20 ezer Ft-nál olcsóbb CPU.");
        }
    }
}
