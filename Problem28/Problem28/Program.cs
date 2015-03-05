using System;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
namespace Problem28
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            BigInteger sum = new BigInteger();
            object _lock = new object();
            Parallel.For(1, 1002, j =>
             {
                 if (j % 2 != 0)
                 {
                     lock (_lock)
                     {
                         sum += GetSumOfCorners(j);
                     }
                 }
             });
            sw.Stop();
            Console.WriteLine(sum);
            Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms.");
            Console.Read();
        }

        static BigInteger GetSumOfCorners(int dimension)
        {
            if (dimension == 1) return 1;
            return (dimension * dimension * 4) - (6 * (dimension - 1));
        }
    }
}
