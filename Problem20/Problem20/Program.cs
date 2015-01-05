using System;
using System.Numerics;
using System.Diagnostics;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            Console.WriteLine(GetDigitSum(GetFactorial(100)));
            stopWatch.Stop();
            Console.WriteLine("Time: " + stopWatch.ElapsedMilliseconds + " ms.");
            Console.Read();
        }

        static BigInteger GetFactorial(int number)
        {
            BigInteger answer = 1;
            for (int i = 2; i <= number; i++)
            {
                answer *= i;
            }
            return answer;
        }

        static long GetDigitSum(BigInteger number)
        {
            string a = number.ToString();
            long result = 0;
            foreach (char item in a)
            {
                result += int.Parse(item.ToString());
            }
            return result;
        }
    }
}
