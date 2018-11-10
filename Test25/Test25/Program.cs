using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test25
{
    class Program
    {
        // Given an array of integers, replace all the occurrences of elemToReplace with 
        // substitutionElem.
        // Example
        // For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3, the output should be
        // arrayReplace(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].

        static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elemToReplace)
                {
                    inputArray[i] = substitutionElem;
                }
            }
            return inputArray;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1 };
            int[] replace = arrayReplace(arr, 1, 3);
            for (int i = 0; i < replace.Length; i++)
            {
                Console.WriteLine(replace[i]);
            }
            Console.WriteLine();
        }
    }
}
