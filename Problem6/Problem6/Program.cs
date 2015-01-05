using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumOfTheSquares = 0;
            long squaresOfTheSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfTheSquares += i * i;
                squaresOfTheSum += i;
            }
            Console.WriteLine(squaresOfTheSum*squaresOfTheSum - sumOfTheSquares);
            Console.Read();
        }
    }
}
