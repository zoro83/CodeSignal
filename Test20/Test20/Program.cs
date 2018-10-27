using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test20
{
    class Program
    {
        //Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
        //
        //Example
        //
        //For inputArray = [2, 4, 1, 0], the output should be
        //arrayMaximalAdjacentDifference(inputArray) = 3.

        static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            int difference = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (Math.Abs(inputArray[i] - inputArray[i + 1]) > difference)
                {
                    difference = Math.Abs(inputArray[i] - inputArray[i + 1]);
                }
            }
            return difference;
        }

        static void Main(string[] args)
        {
        }
    }
}
