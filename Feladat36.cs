using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat36
    {
        static void Main(string[] args)
        {
            Console.Write("Hányan adtak vért a mai napon? ");
            int n = int.Parse(Console.ReadLine());
            List<string> nevek = new List<string>();

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{j + 1}. donor neve: ");
                nevek.Add(Console.ReadLine());
            }

            int i = 0;
            while (i < n && nevek[i] != "Nagy József")
            {
                i++;
            }

            bool szerepel = (i < n);
            Console.WriteLine(szerepel ? "Nagy József szerepel a listán" : "Nagy József nem szerepel a listán");
        }
    }
}