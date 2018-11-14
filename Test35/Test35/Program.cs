using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test35
{
    class Program
    {
    //Find the leftmost digit that occurs in a given string.
    //Example
    //For inputString = "var_1__Int", the output should be
    //firstDigit(inputString) = '1';
    //For inputString = "q2q-q", the output should be
    //firstDigit(inputString) = '2';
    //For inputString = "0ss", the output should be
    //firstDigit(inputString) = '0'.

        public static char firstDigit(string inputString)
        {
            char num = ' ';
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsNumber(inputString[i]))
                {
                    num = inputString[i];
                    break;
                }

            }
            return num;
        }

        static void Main(string[] args)
        {
            string inputString = "a a_933";
            Console.WriteLine(firstDigit(inputString));
            Console.ReadKey();
        }
    }
}
