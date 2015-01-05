using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fib = StworzCiagFib(4000000);
            int sum = 0;
            foreach (int number in fib)
            {
                if(number%2 == 0)
                sum += number;
            }
            Console.WriteLine(sum);
            Console.Read();
        }

        private static List<int> StworzCiagFib(int maxNumber)
        {
            List<int> fib = new List<int>();
            fib.Add(1);
            fib.Add(2);
            while(fib.Last() < maxNumber)
            {
                fib.Add(fib.Last() + fib.ElementAt(fib.Count - 2));
            }

            if (fib.Last() > maxNumber) fib.RemoveAt(fib.Count - 1);
            return fib;
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
