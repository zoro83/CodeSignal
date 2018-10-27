using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        //You are given an array of integers.On each move you are allowed to increase exactly one of its element 
        //by one.Find the minimal number of moves required to obtain a strictly increasing sequence from the input.
        //
        //Example
        //
        //For inputArray = [1, 1, 1], the output should be
        //arrayChange(inputArray) = 3.

        static int arrayChange(int[] inputArray)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] >= inputArray[i + 1])
                {
                    count += inputArray[i] - inputArray[i + 1] + 1;
                    inputArray[i + 1] = inputArray[i] + 1;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 1, 1, 1 };
            Console.WriteLine(arrayChange(a));
            Console.ReadKey();
        }
    }
}
