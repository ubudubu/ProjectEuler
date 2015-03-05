using System;
using System.Collections.Generic;
using System.Linq;
using Combinatorics.Collections;
using System.Diagnostics;

namespace Problem24_with_Combinatorics_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var integers = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            var p = new Permutations<int>(integers);
            var a = p.ElementAt(999999);
            sw.Stop();
            foreach (int digit in a)
            {
                Console.Write(digit.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Time: " + sw.ElapsedMilliseconds);
            Console.Read();
        }
    }
}
