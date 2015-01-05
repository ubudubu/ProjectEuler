using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int j = 20;
            while(result == 0)
            {
                bool possible = true;
                for (int i = 3; i <= 20; i++)
                {
                    if (j % i != 0) possible = false;
                    if (i == 20 && possible == true) result = j;
                    
                }
                j +=20;
            }
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
