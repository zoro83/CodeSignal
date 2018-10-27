using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitRootSort
{
    class Program
    {

        //Digit root of some positive integer is defined as the sum of all of its digits.
        //
        //You are given an array of integers.Sort it in such a way that if a comes before b then
        //the digit root of a is less than or equal to the digit root of b.If two numbers have the same digit root, 
        //the smaller one (in the regular sense) should come first.For example 4 and 13 have the same digit root, 
        //however 4 < 13 thus 4 comes before 13 in any digitRoot sorting where both are present.
        //
        //Example
        //
        //For a = [13, 20, 7, 4], the output should be[20, 4, 13, 7].
        static void Swap0(int[,] arr, int index1, int index2)
        {
            if (index1 != index2)
            {
                int temp = arr[0,index1];
                arr[0,index1] = arr[0,index2];
                arr[0,index2] = temp;

            }

        }
        static void Swap1(int[,] arr, int index1, int index2)
        {
            if (index1 != index2)
            {
                int temp = arr[1, index1];
                arr[1, index1] = arr[1, index2];
                arr[1, index2] = temp;

            }

        }
        static int[] DigitRootSort(int[] a)
        {
            int[,] digitArr = new int[a.Length, a.Length];
           
            for (int i = 0; i < a.Length; i++)
            {
                int num = a[i];
                while (num !=0)
                {
                    digitArr[0, i] += num % 10;
                    digitArr[1, i] = a[i];
                    num /= 10;
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 1; j < a.Length - i; j++)
                {
                    if (digitArr[0,j - 1] > digitArr[0,j])
                    {
                        Swap0(digitArr, j - 1, j);
                        Swap1(digitArr, j - 1, j);
                        //PrintArray(cloneArr);
                    }
                    if (digitArr[0, j - 1] == digitArr[0, j] && digitArr[1, j - 1] > digitArr[1, j])
                    {
                        Swap0(digitArr, j - 1, j);
                        Swap1(digitArr, j - 1, j);
                    }

                }
            }
            int[] returnRoot = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                returnRoot[i] = digitArr[1, i];
            }
            return returnRoot;
        }
        static void Main(string[] args)
        {
            int[] a = { 13, 20, 7, 4 };
            a = DigitRootSort(a);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
