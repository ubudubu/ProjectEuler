using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics;

namespace Problem25
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<BigInteger> fibSequence = new List<BigInteger>();
            fibSequence.Add(1);
            fibSequence.Add(1);
            while(fibSequence.ElementAt(fibSequence.Count-1).ToString().Length<1000)
            {
                fibSequence.Add(fibSequence.ElementAt(fibSequence.Count - 1) + fibSequence.ElementAt(fibSequence.Count - 2));
            }
            sw.Stop();
            Console.WriteLine(fibSequence.Count);
            Console.WriteLine(fibSequence.ElementAt(fibSequence.Count-1));
            Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms.");
            Console.Read();
        }

    }
}
