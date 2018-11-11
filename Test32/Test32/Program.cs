using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test32
{
    class Program
    {
    //Given a sorted array of integers a, find an integer x from a such that the value of
    //
    //abs(a[0] - x) + abs(a[1] - x) + ... + abs(a[a.length - 1] - x)
    //is the smallest possible(here abs denotes the absolute value).
    //If there are several possible answers, output the smallest one.
    //Example
    //For a = [2, 4, 7], the output should be
    //absoluteValuesSumMinimization(a) = 4.

        static public int absoluteValuesSumMinimization(int[] a)
        {
            int minValue = 0;
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    sum += Math.Abs(a[j] - a[i]);
                }
                arr[i] = sum;
            }
            minValue = arr.ToList().IndexOf(arr.Min());
            return a[minValue];
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 7 };
            Console.WriteLine(absoluteValuesSumMinimization(a));
            Console.ReadKey();
        }
    }
}
