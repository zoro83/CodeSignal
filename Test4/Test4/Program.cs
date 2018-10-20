using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
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
