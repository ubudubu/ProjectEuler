using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> linesInFile = new List<string>();
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    linesInFile.Add(line); // Add to list.
                    //Console.WriteLine(line); // Write to console.
                }
            }

            List<List<int>> list = new List<List<int>>();
            foreach (string line in linesInFile)
            {
                List<int> numbers = new List<int>();
                string[] words = line.Split(' ');
                foreach (string number in words)
                {
                    numbers.Add(int.Parse(number));
                }
                list.Add(numbers);
            }
            //End of import date

            Stopwatch stopWatch = Stopwatch.StartNew();

            List<List<int>> answer = new List<List<int>>();
            for (int i = 0; i < list.Count; i++)
            {
                List<int> sumary = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        sumary.Add(list.ElementAt(i).ElementAt(j));
                    }
                    else if (j == i)
                    {
                        sumary.Add(list.ElementAt(i).ElementAt(j) + answer.ElementAt(i - 1).ElementAt(j - 1));
                    }
                    else if (j == 0)
                    {
                        sumary.Add(list.ElementAt(i).ElementAt(j) + answer.ElementAt(i - 1).ElementAt(j));
                    }
                    else
                    {
                        if (answer.ElementAt(i - 1).ElementAt(j - 1) >= answer.ElementAt(i - 1).ElementAt(j))
                        {
                            sumary.Add(list.ElementAt(i).ElementAt(j) + answer.ElementAt(i - 1).ElementAt(j - 1));
                        }
                        else
                        {
                            sumary.Add(list.ElementAt(i).ElementAt(j) + answer.ElementAt(i - 1).ElementAt(j));
                        }
                    }

                }
                answer.Add(sumary);
            }

            //foreach (List<int> lista in answer)
            //{
            //    foreach (int number in lista)
            //    {
            //        Console.Write(number + " ");
            //    }
            //    Console.WriteLine();
            //}
            stopWatch.Stop();
            Console.WriteLine("Anserw: " + answer.ElementAt(answer.Count - 1).Max() + " found in " + stopWatch.ElapsedMilliseconds + " ms.");
            Console.Read();
        }
    }
}
