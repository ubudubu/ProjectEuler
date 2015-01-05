using System;
using System.Diagnostics;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            int counter = 0;
            int month = 1;
            int day = 2;
            int year = 1901;
            while(year < 2001)
            {
                if(month==2)
                {
                    if(year%4==0) day = day + (29 % 7);
                    else day = day + (28 % 7);
                }
                else if(month == 4 || month == 6 || month == 9 || month == 11)
                {
                    day = day + (30 % 7);
                }
                else
                {
                    day = day + (31 % 7);
                    if (month == 12)
                    {
                        year++;
                    }
                }

                month++;
                if (month > 12) month -= 12;
                if (day % 7 == 0) counter++;
                if (day > 7) day -= 7;
            }
            stopWatch.Stop();
            Console.WriteLine("Answer: " + counter + " founded in: " + stopWatch.ElapsedMilliseconds + " ms.");
            Console.Read();
        }
    }
}
