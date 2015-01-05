using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long max = 600851475143;
            List<long> primes = new List<long>();
            for (long i = (long)Math.Sqrt(max); i > 2; i--)
            {
                if (IsPrime(i))
                {
                    if(max % i == 0)
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPrime(long number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
