using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11
{
    class Program
    {
        //Ticket numbers usually consist of an even number of digits.
        //A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the 
        //second half.
        //
        //Given a ticket number n, determine if it's lucky or not.
        //
        //Example
        //For n = 1230, the output should be
        //isLucky(n) = true;
        //        For n = 239017, the output should be
        //        isLucky(n) = false.

        static bool isLucky(int n)
        {
            int num = n;
            int length = Convert.ToString(n).Length;
            int[] digit = new int[length];
            for (int i = 0; i < length; i++)
            {
                digit[i] = num % 10;
                num /= 10;
               // Console.WriteLine(digit[i]);
            }
            int sumFirst = 0;
            int sumLast = 0;
            for (int i = 0; i < length / 2; i++)
            {
                sumLast += digit[i];
            }
            for (int i = length / 2; i < length; i++)
            {
                sumFirst += digit[i];
            }
            if (sumFirst == sumLast)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static void Main(string[] args)
        {
            int n = 1230;
            Console.WriteLine(isLucky(n));
            Console.ReadKey();
        }
    }
}
