using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Problem14
{
    class Program
    {
        static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int startNumber = 1000000;

            List<NumberFounder> listOfNumberFounders = new List<NumberFounder>();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                listOfNumberFounders.Add(new NumberFounder(startNumber));
                startNumber--;
            }

            List<Thread> ThreadsList = new List<Thread>();
            foreach (NumberFounder item in listOfNumberFounders)
            {
                ThreadsList.Add(new Thread(item.FoundNumber));
            }

            foreach (Thread thread in ThreadsList)
            {
                thread.Start();
            }

            foreach (Thread thread in ThreadsList)
            {
                thread.Join();
            }


            sw.Stop();
            Console.WriteLine("The answer is: " + NumberFounder.answerNumber);
            Console.WriteLine("Result was found in: " + sw.ElapsedMilliseconds + " ms.");
            Console.Read();
        }

    }
    

    public class NumberFounder
    {
        public static int answerNumber;
        public static long answerTerms;
        int startNumber;
        public NumberFounder(int startNumber)
        {
            this.startNumber = startNumber;
        }

        public void FoundNumber()
        {
            int maxTerms = 0;
            int anserw = 0;
            for (int i = startNumber; i > 500000; i = i - Environment.ProcessorCount)
            {
                int terms = CalculateTerms(i);
                if (terms > maxTerms)
                {
                    maxTerms = terms;
                    anserw = i;
                }
            }
            if (maxTerms > answerTerms)
            {
                answerTerms = maxTerms;
                answerNumber = anserw;
            }
        }

        int CalculateTerms(long number)
        {
            long oryginal = number;
            int terms = 1;
            while (number > 1)
            {
                if (number % 2 == 0) number = number / 2;
                else number = 3 * number + 1;
                terms++;
            }
            return terms;
        }
    }
}
