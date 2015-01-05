using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            //long result = 36*9*10;
            //int andWord = 3 * 890;
            //int hundredWord = 7 * 899;
            //int hundreds = 36 * 100;
            //int tys = 49 * 10;
            //int tens = 71 * 10;
            //Console.WriteLine(result+andWord+hundredWord+hundreds+tys+tens+11);
            //Console.Read();
            int a = 36 * 9 + 70 + 460;
            int andWord = 3 * 99 * 9;
            int hundredWord = 7 * 900;
            int hundreds = 36 * 100;
            Console.WriteLine(a * 10 + andWord + hundredWord + hundreds + 11);
            Console.Read();
            //StringBuilder final = new StringBuilder("");
            //for (int i = 10; i < 20; i++)
            //{
            //    Console.WriteLine(first(i));
            //    final.Append(first(i));
            //}
            //Console.WriteLine(final.Length);
            //Console.Read();
        }

        public static string first(int number)
        {
            string answer = "";
            if (number == 1) return "one";
            if (number == 2) return "two";
            if (number == 3) return "three";
            if (number == 4) return "four";
            if (number == 5) return "five";
            if (number == 6) return "six";
            if (number == 7) return "seven";
            if (number == 8) return "eight";
            if (number == 9) return "nine";
            if (number == 10) return "ten";
            if (number == 11) return "eleven";
            if (number == 12) return "twelve";
            if (number == 13) return "thirteen";
            if (number == 14) return "fourteen";
            if (number == 15) return "fifteen";
            if (number == 16) return "sixteen";
            if (number == 17) return "seventeen";
            if (number == 18) return "eighteen";
            if (number == 19) return "nineteen";
            if (number == 20) return "twenty";
            if (number == 30) return "thirty";
            if (number == 40) return "forty";
            if (number == 50) return "fifty";
            if (number == 60) return "sixty";
            if (number == 70) return "seventy";
            if (number == 80) return "eighty";
            if (number == 90) return "ninety";
            else return "ERROR";
        }
    }
}
