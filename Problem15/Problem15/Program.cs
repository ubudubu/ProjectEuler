using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 21;
            long[,] array = new long[x,x];
            array[x-1, x-1] = 0;
            
            for (int i = 0; i < x-1; i++)
            {
                array[x-1, i] = 1;
                array[i, x-1] = 1;
            }

            for (int i = x-2; i >= 0; i--)
            {
                for (int j = x-2; j >= 0; j--)
                {
                    array[i, j] = array[i + 1, j] + array[i, j + 1];
                }
            }

            Console.WriteLine(array[0,0]);
            Console.Read();
        }
    }
}
