using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem26
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Dictionary<int, string> fractions = new Dictionary<int, string>();
            Parallel.For(1, 1000, j =>
            {
                fractions.Add(j, GetRecurringCycle(1, j));
            });
            int maxLength = 0;
            int k = 0;
            foreach (var item in fractions)
            {
                if (item.Value.Length > maxLength)
                {
                    maxLength = item.Value.Length;
                    k = item.Key;
                }
            }
            sw.Stop();
            Console.WriteLine(k);
            Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms.");
            Console.Read();
        }

        public static string GetRecurringCycle(int a, int b)
        {
            List<int> results = new List<int>();
            List<int> digits = new List<int>();

            int result = a;

            while (results.Contains(result * 10) == false)
            {
                result *= 10;
                results.Add(result);
                digits.Add(result / b);
                result = result - (result / b) * b;
                if (result == 0) return "0";
                var test = results.Contains(result * 10);
            }

            StringBuilder answer = new StringBuilder();
            for (int i = results.IndexOf(result * 10); i < results.Count; i++)
            {
                answer.Append(digits.ElementAt(i));
            }
            return answer.ToString();
        }
    }
}
