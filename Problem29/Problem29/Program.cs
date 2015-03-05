using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Problem29
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<double> results = new List<double>();
            for (int i = 2; i < 101; i++)
            {
                for (int j = 2; j < 101; j++)
                {
                    results.Add(Math.Pow(i, j));
                }
            }
            sw.Stop();
            Console.WriteLine(results.Distinct().Count());
            Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms.");
            Console.Read();
        }
    }
}
