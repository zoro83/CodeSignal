using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test55
{
    //Given a rectangular matrix containing only digits, calculate the number of different 
    //2 × 2 squares in it.
    //Example
    //For
    //matrix = [[1, 2, 1],
    //          [2, 2, 2],
    //          [2, 2, 2],
    //          [1, 2, 3],
    //          [2, 2, 1]]
    //the output should be
    //differentSquares(matrix) = 6.
    //Here are all 6 different 2 × 2 squares:
    //1 2    2 1    2 2    2 2    2 2    2 3
    //2 2    2 2    2 2    1 2    2 3    2 1   
    class Program
    {
        public static int differentSquares(int[][] matrix)
        {
            if (matrix.Length <= 2 && matrix[0].Length <= 2)
            {
                return 0;
            }
            string[] arr = new string[(matrix.Length - 1) * (matrix[0].Length - 1)];
            int arrIndex = 0;
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[0].Length - 1; j++)
                {
                    arr[arrIndex] = $"{matrix[i][j]}{matrix[i][j + 1]}" +
                        $"{matrix[i + 1][j]}{matrix[i + 1][j + 1]}";
                    arrIndex++;
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[j] = "";
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    sum++;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][]
            {
                new int[] { 1, 2, 1 },
                new int[] { 2, 2, 2},
                new int[] { 2, 2, 2 },
                new int[] { 1, 2, 3},
                new int[] { 2, 2, 1 }
            };
            Console.WriteLine(differentSquares(matrix));
            Console.ReadKey();
        }
    }
}
