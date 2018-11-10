using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test25
{
    class Program
    {
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
