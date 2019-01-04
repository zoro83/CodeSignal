using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test54
{
    //CodeMaster has just returned from shopping.He scanned the check of the items he bought and gave 
    //the resulting string to Ratiorg to figure out the total number of purchased items. Since Ratiorg 
    //is a bot he is definitely going to automate it, so he needs a program that sums up all the numbers 
    //which appear in the given input.
    //Help Ratiorg by writing a function that returns the sum of numbers that appear in the given inputString.
    //Example
    //For inputString = "2 apples, 12 oranges", the output should be
    //sumUpNumbers(inputString) = 14.
    class Program
    {
        public static int sumUpNumbers(string inputString)
        {
            int sum = 0;
            foreach (var item in Regex.Matches(inputString, @"\d+"))
            {
                sum += Convert.ToInt32(item.ToString());
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string inputString = "there are some (12) digits 5566 in this 770 string 239";
            Console.WriteLine(sumUpNumbers(inputString));
            Console.ReadKey();
        }
    }
}
