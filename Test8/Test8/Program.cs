using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8
{
    class Program
    {
        static int matrixElementsSum(int[][] matrix)
        {
            int coastSum = 0;
            int row = matrix.Length;
            int column = matrix[0].Length;

            for (int j = 0; j < column; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (matrix[i][j] == 0)
                    {
                        for (int k = i; k < row; k++)
                        {
                            matrix[k][j] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    coastSum += matrix[i][j];
                }
            }

            return coastSum;
        }

        static void Main(string[] args)
        {
        }
    }
}
