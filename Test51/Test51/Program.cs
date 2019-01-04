using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test51
{
    //Given some integer, find the maximal number you can obtain by deleting exactly one digit of 
    //the given number.
    //Example
    //For n = 152, the output should be
    //deleteDigit(n) = 52;
    //For n = 1001, the output should be
    //deleteDigit(n) = 101.
    class Program
    {
        public static int deleteDigit(int n)
        {
            int num = n;
            string str = $"{n}";
            int[] arr = new int[str.Length];
            for (int i = str.Length - 1; i >= 0; i--)
            {
                string output = "";
                for (int j = 0; j < arr.Length;)
                {
                    if (j != i)
                    {
                        output += str[j];
                        j++;
                    }
                    else
                        j++;
                }
                arr[i] = Convert.ToInt32(output);
            }
            return arr.Max();
        }

        static void Main(string[] args)
        {
            //deleteDigit(45600);
            Console.WriteLine(deleteDigit(898998));
            Console.ReadKey();
        }
    }
}
