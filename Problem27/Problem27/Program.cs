using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Problem27
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<int> primesBelow1000 = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                if (IsPrime(i)) primesBelow1000.Add(i);
            }
            int a=0, b=0;
            int hightestN = 0;
            for (int i = -999; i < 1000; i++)
            {
                for ( int j = primesBelow1000.First(); j <= primesBelow1000.Last(); j++)
                {
                    int n = 0;
                    while (IsPrime(Calculate(n, i, j))) n++;
                    if (n > hightestN)
                    {
                        a = i;
                        b = j;
                        hightestN = n;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine(a * b);
            Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms.");
            Console.Read();
        }

        private static bool IsPrime(long number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static long Calculate(int n, int b, int c)
        {
            return (n * n) + (n * b) + c;
        }
    }
}
