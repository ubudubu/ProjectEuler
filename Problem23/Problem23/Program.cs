using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Problem23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<int> numbers = new List<int>();
            for (int i = 1; i < 28123; i++)
            {
                numbers.Add(i);
            }

            List<int> abudants = new List<int>();
            for (int i = 12; i < 28123; i++)
            {
                if (IsAbundant(i)) abudants.Add(i);
            }

            Parallel.For(1, abudants.Count, i =>
            {
                Parallel.For(i, abudants.Count, j =>
                {
                    numbers.Remove(abudants.ElementAt(i) + abudants.ElementAt(j));
                });
            });
       
            sw.Stop();
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("time: " + sw.ElapsedMilliseconds + " ms, " + sw.ElapsedTicks + " ticks.");
            Console.Read();
        }

        public static Boolean IsAbundant(int number)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i < number/2+1; i++)
            {
                if (number % i == 0) divisors.Add(i);
            }
            if (divisors.Sum() > number) return true;
            else return false;
        }
    }
}
