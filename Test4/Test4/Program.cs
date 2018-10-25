using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        //Given an array of integers, find the pair of adjacent elements that has the largest product and 
        //return that product.

        //  Example
        //  
        //  For inputArray = [3, 6, -2, -5, 7, 3], the output should be
        //  adjacentElementsProduct(inputArray) = 21.
        //  
        //  7 and 3 produce the largest product.
        static int adjacentElementsProduct(int[] inputArray)
        {
            int max = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                if ((int)(inputArray[i] * inputArray[i+1]) > max)
                {
                    max = inputArray[i] * inputArray[i + 1];
                }
            }
            return max;
        }
            static void Main(string[] args)
        {
            int[] res = { 5, 1, 2, 5, 1, 4 };
            int prod = adjacentElementsProduct(res);
            Console.WriteLine(prod);
            Console.ReadKey();

        }
    }
}
