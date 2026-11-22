using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat49
    {
        static void Main(string[] args)
        {
            Console.Write("Hány versenyző indult? ");
            int n = int.Parse(Console.ReadLine());

            List<string> nevek = new List<string>();
            List<int> idok = new List<int>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. versenyző neve: ");
                nevek.Add(Console.ReadLine());
                Console.Write($"{j + 1}. versenyző összes futási ideje (percben): ");
                idok.Add(int.Parse(Console.ReadLine()));
            }
            int minIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (idok[i] < idok[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine($"A verseny győztese: {nevek[minIndex]} {idok[minIndex]} perc alatti idővel");
        }
    }
}