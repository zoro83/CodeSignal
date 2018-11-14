using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test34
{
    class Program
    {
        //Given array of integers, remove each kth element from it.
        //Example
        //For inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] and k = 3, the output should be
        //extractEachKth(inputArray, k) = [1, 2, 4, 5, 7, 8, 10].

        public static int[] extractEachKth(int[] inputArray, int k)
        {
            int[] outputArray = new int[inputArray.Length - inputArray.Length / k];
            int count = 1;
            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i + count - 1 == count * k - 1)
                {
                    count++;
                }
                outputArray[i] = inputArray[i + count - 1];
            }
            return outputArray;
        }

        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] res = extractEachKth(test, 3);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]}, ");
            }
            Console.ReadKey();
        }
    }
}
