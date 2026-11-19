using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat19
    {
        static void Main(string[] args)
        {
            Console.Write("Hány tanuló van az osztályban? ");
            int n = int.Parse(Console.ReadLine());

            List<string> nevek = new List<string>();
            List<int> magassagok = new List<int>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. tanuló neve: ");
                nevek.Add(Console.ReadLine());
                Console.Write($"{j + 1}. tanuló magassága (cm): ");
                magassagok.Add(int.Parse(Console.ReadLine()));
            }

            int minIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (magassagok[i] < magassagok[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine($"A legalacsonyabb tanuló: {nevek[minIndex]} ({magassagok[minIndex]} cm)");
        }
    }
}