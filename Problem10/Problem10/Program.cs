using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 0;
            List<int> primes = new List<int>();
            for (int i = 0; i < 2000000; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                    result += i;
                }
            }
            
            Console.WriteLine(result);
            Console.Read();
        }

        private static bool IsPrime(long number)
        {
            if(number == 0 || number == 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
