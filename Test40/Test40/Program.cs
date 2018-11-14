using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test40
{
    class Program
    {
        //Given a string, output its longest prefix which contains only digits.
        //Example
        //For inputString = "123aa1", the output should be
        //longestDigitsPrefix(inputString) = "123".
        //STRING PREFIX-A substring of a string is called a prefix if it starts at the string’s first character.
        public static string longestDigitsPrefix(string inputString)
        {
            string digits = "";
            string longestDigits = "";
            int maxDigitLength = 0;
            int digitLength = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                digits = "";
                digitLength = 0;
                while (char.IsDigit(inputString[0]) && i < inputString.Length && char.IsDigit(inputString[i]))
                {
                    digits += $"{inputString[i]}";
                    digitLength++;
                    i++;
                }
                if (digitLength > maxDigitLength)
                {
                    maxDigitLength = digitLength;
                    longestDigits = digits;
                }
            }

            return longestDigits;
        }
        static void Main(string[] args)
        {
            string inputString = " 94";
            Console.WriteLine(longestDigitsPrefix(inputString));
            Console.ReadKey();
        }
    }
}
