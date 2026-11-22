using System;
using System.Collections.Generic;
using System.Text;

namespace Progtetelek
{
    internal class Feladat37
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg N értékét (N > 0): ");
            int n = int.Parse(Console.ReadLine());

            long faktorialis = 1;
            for (int i = 1; i <= n; i++)
            {
                faktorialis *= i;
            }

            Console.WriteLine($"A(z) {n} faktoriális értéke: {faktorialis}");
        }
    }
}