using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combinatorics;
using Combinatorics.Collections;

namespace Problem31
{
    class Program
    {
        static void Main(string[] args)
        {
            double ways = 0;
            int[] inputSet = { 1, 2, 5, 10, 20, 50, 100, 200 };
            object _lock = new object();
            for (int i = 1; i <= 200; i++)
            {
                Variations<int> variations = new Variations<int>(inputSet, i, GenerateOption.WithRepetition);
                Parallel.ForEach(variations, item =>
                //foreach (var item in variations)
                {
                    if (item.Sum() == 200)
                    {
                        lock (_lock)
                        {
                            ways++;
                        }
                    }
                });
            }
            Console.WriteLine(ways);
            Console.Read();
        }
    }
}
