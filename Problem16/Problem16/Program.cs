using System;
using System.Numerics;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = 2;
            for (int i = 2; i <= 1000; i++)
            {
                result *= 2;
            }
            string sResult = result.ToString();
            int finalResult = 0;
            foreach (char item in sResult)
            {
                finalResult += int.Parse(item.ToString());
            }
            Console.WriteLine(finalResult);
            Console.Read();
        }
    }
}
