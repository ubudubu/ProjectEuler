using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> divisors = GetDivisors(28);
            long i = 9900;
            long triangle = GetTriangleNumber(i);
            /*while (divisors.Count < 501)
            {
                i++;
                triangle += i;
                divisors = GetDivisors(triangle);
                if (divisors.Count > 200) Console.WriteLine(triangle + ": " + divisors.Count);
            }*/
            long divis = 0;
            while (divis < 501)
            {
                i++;
                triangle += i;
                divis = NumberOfDivisors(triangle);
                if (divis > 200) Console.WriteLine(triangle + ": " + divis);
            }

            Console.Read();
        }

        private static List<long> GetDivisors(long number)
        {
            List<long> divisors = new List<long>();
            for (long i = 1; i <= number; i++)
            {
                if (number % i == 0) divisors.Add(i);
            }
            return divisors;
        }

        private static long NumberOfDivisors(long number)
        {
            long nod = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    nod += 2;
                }
            }
            //Correction if the number is a perfect square
            if (sqrt * sqrt == number)
            {
                nod--;
            }

            return nod;
        }

        private static long GetTriangleNumber(long number)
        {
            long triangle = 0;
            for (int i = 1; i <= number; i++)
            {
                triangle += i;
            }
            return triangle;
        }
    }
}
