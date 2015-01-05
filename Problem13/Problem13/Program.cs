using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddStrings("99999", "9"));
            string result = string.Empty;
            string file = "numbers.txt";
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (result.Equals(string.Empty)) result = line;
                    else result = AddStrings(result, line);
                    int a = result.Length;
                }
            }
            
            Console.WriteLine(result);
            int aa = result.Length;
            Console.Read();
        }

        public static string AddStrings(string first, string second)
        {
            List<int> result = new List<int>();
            if (first.Length >= second.Length)
            {
                result = AddStringsInOrder(first, second);
            }
            else
            {
                result = AddStringsInOrder(second, first);
            }

            StringBuilder anserw = new StringBuilder();
            foreach (int item in result)
            {
                anserw.Append(item.ToString());
            }
            return anserw.ToString();
        }

        private static List<int> AddStringsInOrder(string first, string second)
        {
            List<int> result = new List<int>();
            int overTen = 0;
            for (int i = 1; i <= second.Length; i++)
            {
                int a = int.Parse(second.ElementAt(second.Length - i).ToString());
                int b = int.Parse(first.ElementAt(first.Length - i).ToString());
                int sum = a + b + overTen;
                if (a + b + overTen >= 10)
                {
                    result.Insert(0, sum - 10);
                    overTen = 1;
                }
                else
                {
                    result.Insert(0, sum);
                    overTen = 0;
                }
            }
            //if (first.Length > second.Length) result.Insert(0, int.Parse(first.ElementAt(first.Length - second.Length-1).ToString()) + overTen);
            //if (first.Length == second.Length && overTen == 1) result.Insert(0, overTen);

            for (int i = 1; i <= first.Length - second.Length; i++)
            {
                if ((int.Parse(first.ElementAt(first.Length - second.Length - i).ToString())) + overTen >= 10)
                {
                    result.Insert(0, (int.Parse(first.ElementAt(first.Length - second.Length - i).ToString())) + overTen - 10);
                    overTen = 1;
                }
                else
                {
                    result.Insert(0, (int.Parse(first.ElementAt(first.Length - second.Length - i).ToString())) + overTen);
                    overTen = 0;
                }
                //if (i == (first.Length - second.Length)) result.Insert(0, (int.Parse(first.ElementAt(first.Length - second.Length - i).ToString())) + overTen);
                //else result.Insert(0, int.Parse(first.ElementAt(first.Length - second.Length -i).ToString()));

                //if ((int.Parse(first.ElementAt(first.Length - second.Length - i).ToString())) + overTen < 10) overTen = 0;
                /////else overTen = 1;
            }
            if (overTen == 1) result.Insert(0, overTen);
            return result;
        }
    }
}
