using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sukces = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    int result = i * j;
                    //Console.WriteLine(result);
                    if(isPalindrome(result.ToString()))
                    {
                        if (result > sukces)
                        {
                            sukces = result;
                            Console.WriteLine("sukces: " + result);
                        }
                    }
                }
                
            }
            Console.WriteLine(sukces);
            Console.Read();
        }

        private static bool isPalindrome(string text)
        {
            StringBuilder reverse = new StringBuilder();
            for (int i = text.Length; i > 0; i--)
            {
                reverse.Append(text.ElementAt(i - 1));
            }
            if (reverse.ToString().Equals(text)) return true;
            else return false;
        }
    }
}
