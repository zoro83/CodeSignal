using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test59
{
    //Construct a square matrix with a size N × N containing integers from 1 to N * N in a spiral order, 
    //starting from top-left and in clockwise direction.
    //Example
    //For n = 3, the output should be
    //spiralNumbers(n) = [[1, 2, 3],
    //                    [8, 9, 4],
    //                    [7, 6, 5]]
    class Program
    {
        public static int[][] spiralNumbers(int n)
        {
            int[][] sp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                sp[i] = new int[n];
            }
            bool temp = true;
            int num = 0;
            int step1 = 0;
            int step2 = 0;
            for (int k = n; k > 0; k--)
            {
                if (temp)
                {

                    for (int j = step1; j < n - step1; j++)
                    {
                        sp[step1][j] += ++num;
                        //num++;
                    }
                    for (int i = step1 + 1; i < n - step1; i++)
                    {
                        sp[i][n - step1 - 1] += ++num;
                    }
                    temp = false;
                    step2++;
                }
                else
                {
                    for (int j = n - step2 - 1; j >= step2 - 1; j--)
                    {
                        sp[n - step2][j] += ++num;
                        //num++;
                    }
                    for (int i = n - step2 - 1; i >= step2; i--)
                    {
                        sp[i][step2 - 1] += ++num;
                    }
                    temp = true;
                    step1++;

                }

            }
            return sp;
        }
        static void Main(string[] args)
        {
            int[][] spiral = spiralNumbers(6);
            for (int i = 0; i < spiral.Length; i++)
            {
                for (int j = 0; j < spiral[i].Length; j++)
                {
                    Console.WriteLine(spiral[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
