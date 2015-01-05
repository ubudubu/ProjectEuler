using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> grid = new List<List<int>>();
            string file = "grid.txt";
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    List<int> linee = new List<int>();
                    foreach (var item in words)
                    {
                        linee.Add(int.Parse(item));
                    }
                    grid.Add(linee);
                }
            }

            int rowMax = 0;
            foreach (var row in grid)
            {
                for (int i = 0; i < 17; i++)
                {
                    int result = row.ElementAt(i) * row.ElementAt(i + 1) * row.ElementAt(i + 2) * row.ElementAt(i + 3);
                    if (result > rowMax) rowMax = result;
                }
            }
            Console.WriteLine("RMax " + rowMax);

            int columnMax = 0;
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int result = grid.ElementAt(i).ElementAt(j) * grid.ElementAt(i + 1).ElementAt(j) * grid.ElementAt(i + 2).ElementAt(j) * grid.ElementAt(i + 3).ElementAt(j);
                    if (result > columnMax)
                    {
                        columnMax = result;
                        Console.WriteLine(grid.ElementAt(i).ElementAt(j) + " " + grid.ElementAt(i + 1).ElementAt(j) + " " + grid.ElementAt(i + 2).ElementAt(j) + " " + grid.ElementAt(i + 3).ElementAt(j));
                    }
                }
            }
            Console.WriteLine("CMax: " + columnMax);

            int diagMax = 0;
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    int result = grid.ElementAt(i).ElementAt(j) * grid.ElementAt(i + 1).ElementAt(j+1) * grid.ElementAt(i + 2).ElementAt(j+2) * grid.ElementAt(i + 3).ElementAt(j+3);
                    if (result > diagMax)
                    {
                        diagMax = result;
                        Console.WriteLine(grid.ElementAt(i).ElementAt(j) + " " + grid.ElementAt(i + 1).ElementAt(j + 1) + " " + grid.ElementAt(i + 2).ElementAt(j + 2) + " " + grid.ElementAt(i + 3).ElementAt(j + 3));
                    }
                }
            }
            Console.WriteLine("DiagMax: " + diagMax);

            int diag2Max = 0;
            for (int i = 0; i < 17; i++)
            {
                for (int j = 3; j < 20; j++)
                {
                    int result = grid.ElementAt(i).ElementAt(j) * grid.ElementAt(i + 1).ElementAt(j - 1) * grid.ElementAt(i + 2).ElementAt(j - 2) * grid.ElementAt(i + 3).ElementAt(j - 3);
                    if (result > diag2Max)
                    {
                        diag2Max = result;
                        Console.WriteLine(grid.ElementAt(i).ElementAt(j) + " " + grid.ElementAt(i + 1).ElementAt(j - 1) + " " + grid.ElementAt(i + 2).ElementAt(j - 2) + " " + grid.ElementAt(i + 3).ElementAt(j - 3));
                    }
                }
            }
            Console.WriteLine("diag2Max: " + diag2Max);
            Console.Read();
        }
    }
}
