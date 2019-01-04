using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test48
{
    //Determine if the given character is a digit or not.
    //Example
    //For symbol = '0', the output should be
    //isDigit(symbol) = true;
    //For symbol = '-', the output should be
    //isDigit(symbol) = false.
    class Program
    {
        public static bool isDigit(char symbol)
        {
            string pattern = @"\d";
            return Regex.IsMatch(symbol.ToString(), pattern);
        }

        static void Main(string[] args)
        {
            char ch = '9';
            Console.WriteLine(isDigit(ch));
            Console.ReadKey();
        }
    }
}
