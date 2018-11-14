using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test41
{
    class Program
    {
        //Let's define digit degree of some positive integer as the number of times we need to replace 
        //this number with the sum of its digits until we get to a one digit number.
        //Given an integer, find its digit degree.
        //Example
        //For n = 5, the output should be digitDegree(n) = 0;
        //
        //For n = 100, the output should be digitDegree(n) = 1.
        //1 + 0 + 0 = 1.
        //
        //For n = 91, the output should be
        //digitDegree(n) = 2. 9 + 1 = 10 -> 1 + 0 = 1.

        public static int digitDegree(int n)
        {
            int num = n;
            int sum;
            int digitDegree = 0;
            while (num > 9)
            {
                sum = 0;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                digitDegree++;
                num = sum;
            }
            return digitDegree;
        }
        static void Main(string[] args)
        {
            int num = 91;
            Console.WriteLine(digitDegree(num));
            Console.ReadKey();
        }
    }
}
