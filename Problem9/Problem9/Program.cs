using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int a = 100; a < 500; a++)
            {
                int c = 150;
                for (int b = 100; b < 500; b++)
                {
                    while (a * a + b * b > c * c) c++;
                    if (a * a + b * b == c * c && a + b + c == 1000) Console.WriteLine(a + " " + b + " " + c);                    
                }
            }
            Console.WriteLine("koniec");
            Console.Read();
        }
    }
}
