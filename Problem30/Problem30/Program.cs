using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem30
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 2; i < 360000; i++)
            {
                if (sumOfPoWDigits(i) == i) sum += i;
            }
            Console.WriteLine(sum);
            Console.Read();
        }

        static double sumOfPoWDigits(int number)
        {
            double sum = 0;
            string numb = number.ToString();
            foreach (char item in numb)
            {
                sum += Math.Pow(int.Parse(item.ToString()), 5);
            }
            return sum;
        }
    }
}
