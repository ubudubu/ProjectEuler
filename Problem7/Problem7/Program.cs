using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> primes = new List<long>();
            long i = 2;
            while(primes.Count < 10001)
            {
                if (IsPrime(i)) primes.Add(i);
                i++;
            }
            Console.WriteLine(primes.Last());
            Console.Read();
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
