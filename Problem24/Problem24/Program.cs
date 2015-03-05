using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4};
            Console.Write("Start array: ");
            foreach (int item in array)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            for (int i = 0; i < 12; i++)
            {
                array = GetNextPermutation(array);
                foreach (int item in array)
                {
                    Console.Write(item);
                }
                Console.WriteLine();               
            }

            Console.Read();
        }

        public static int[] GetNextPermutation(int[] array)
        {
            int lastGood = 0;
            int[] startArray = new int[array.Length];

            for (int j = 1; j < array.Length-2; j++)
            {
                if (array[j] < array[j-1] && array[j] < array[j+1] && array[j+1] > array[j+2])
                {
                    if (array[j] < array[j - 1] && array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[array.Length - 1];
                        array[array.Length - 1] = temp;
                        for (int k = j+1; k < array.Length-1; k++)
                        {
                                temp = array[k];
                                array[k] = array[k + 1];
                                array[k + 1] = temp;
                        }
                        return array;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                startArray[i] = array[i];
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    lastGood = i;
                    if (i==array.Length-2)
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                    else continue;
                }
                else
                {
                    for (int j = array.Length - 1; j > i; j--)
                    {
                        if (array[j] > array[j - 1])
                        {
                            int temp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = temp;
                            break;
                        }
                    }
                }
            }
            if (Enumerable.SequenceEqual(startArray,array))
            {
                int temp = array[lastGood];
                if (array[lastGood] > array[array.Length - 1])
                {
                    array[lastGood] = array[lastGood + 1];
                    array[lastGood + 1] = temp;
                }
                else
                {
                    array[lastGood] = array[array.Length - 1];
                    array[array.Length - 1] = temp;
                }
                for (int k = lastGood; k < array.Length - 1 - lastGood; k++)
                {
                    for (int j = lastGood + 1; j < array.Length - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int tempp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tempp;
                        }
                    }
                }
                
            }
            return array;
        }
    }
}
