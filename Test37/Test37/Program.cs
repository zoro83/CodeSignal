using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test37
{
    class Program
    {
    //Given array of integers, find the maximal possible sum of some of its k consecutive elements.
    //Example
    //For inputArray = [2, 3, 5, 1, 6] and k = 2, the output should be
    //arrayMaxConsecutiveSum(inputArray, k) = 8.
    //All possible sums of 2 consecutive elements are:
    //2 + 3 = 5;
    //3 + 5 = 8;
    //5 + 1 = 6;
    //1 + 6 = 7.
    //Thus, the answer is 8.

        public static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int sumOfkElements = 0;
            for (int j = 0; j < k; j++)
            {
                sumOfkElements += inputArray[0 + j];
            }
            int maxSum = sumOfkElements;
            for (int i = 0; i < inputArray.Length - k; i++)
            {
                sumOfkElements = sumOfkElements - inputArray[i] + inputArray[i + k];
                if (sumOfkElements >= maxSum)
                {
                    maxSum = sumOfkElements;
                }
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
            int[] arr = { 13, 3, 2, 4, 6, 9 };
            Console.WriteLine(arrayMaxConsecutiveSum(arr, 3));
            Console.ReadKey();
        }
    }
}
