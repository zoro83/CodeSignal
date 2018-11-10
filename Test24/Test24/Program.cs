using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test24
{
    class Program
    {
        static int[][] minesweeper(bool[][] matrix)
        {
            int[][] res = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                res[i] = new int[matrix[i].Length];
            }
            for (int i = 1; i < matrix.Length - 1; i++)
            {
                for (int j = 1; j < matrix[i].Length - 1; j++)
                {
                    if (matrix[i][j])
                    {
                        res[i - 1][j - 1]++;
                        res[i - 1][j]++;
                        res[i - 1][j + 1]++;
                        res[i][j - 1]++;
                        res[i][j + 1]++;
                        res[i + 1][j - 1]++;
                        res[i + 1][j]++;
                        res[i + 1][j + 1]++;
                    }

                }

            }
            if (matrix[0][0]) // dzax verevi ankyun@
            {
                res[0][1]++;
                res[1][0]++;
                res[1][1]++;
            }
            if (matrix[0][matrix[0].Length-1]) // aj verevi ankyun@
            {
                res[0][matrix[0].Length - 2]++;
                res[1][matrix[0].Length-1]++;
                res[1][matrix[0].Length - 2]++;
            }

            if (matrix[matrix.Length-1][matrix[0].Length-1]) //aj nerqevi ankyun@
            {
                res[matrix.Length-1][matrix[0].Length - 2]++;
                res[matrix.Length - 2][matrix[0].Length-1]++;
                res[matrix.Length - 2][matrix[0].Length - 2]++;
            }

            if (matrix[matrix.Length-1][0]) //dzax nerqevi ankyun@
            {
                res[matrix.Length-1][1]++;
                res[matrix.Length - 2][0]++;
                res[matrix.Length - 2][1]++;
            }
            for (int i = 1; i < matrix.Length - 1; i++)// arajin syunn e
            {
                if (matrix[i][0])
                {
                    res[i - 1][0]++;
                    res[i - 1][1]++;
                    res[i][1]++;
                    res[i + 1][0]++;
                    res[i + 1][1]++;
                }
            }
            for (int i = 1; i < matrix.Length - 1; i++) // verjin syunn e
            {
                if (matrix[i][matrix[0].Length-1])
                {
                    res[i - 1][matrix[0].Length-1]++;
                    res[i - 1][matrix[0].Length - 2]++;
                    res[i][matrix[0].Length - 2]++;
                    res[i + 1][matrix[0].Length-1]++;
                    res[i + 1][matrix[0].Length - 2]++;
                }
            }
            for (int j = 1; j < matrix[0].Length - 1; j++)// arajin toxn e
            {
                if (matrix[0][j])
                {
                    res[0][j - 1]++;
                    res[0][j + 1]++;
                    res[1][j - 1]++;
                    res[1][j]++;
                    res[1][j + 1]++;
                }
            }
            for (int j = 1; j < matrix[0].Length - 1; j++)// verjin toxn e
            {
                if (matrix[matrix.Length-1][j])
                {
                    res[matrix.Length-1][j - 1]++;
                    res[matrix.Length-1][j + 1]++;
                    res[matrix.Length - 2][j - 1]++;
                    res[matrix.Length - 2][j]++;
                    res[matrix.Length - 2][j + 1]++;
                }
            }


            return res;
        }
        static void Main(string[] args)
        {
            bool[][] jaggedArray =
                                { new bool[] { true, false, false},
                                  new bool[] { false, true, false },
                                  new bool[] { false, false, false} };
            int[][] test = new int[3][];
            test[0] = new int[3];
            test[1] = new int[3];
            test[2] = new int[3];

            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < test[0].Length; j++)
                {
                    Console.Write($"{minesweeper(jaggedArray)[i][j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
