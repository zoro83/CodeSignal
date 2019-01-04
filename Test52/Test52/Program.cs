using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test52
{
    //Define a word as a sequence of consecutive English letters.Find the longest word from the 
    //given string.
    //Example
    //For text = "Ready, steady, go!", the output should be
    //longestWord(text) = "steady"
    class Program
    {
        public static string longestWord(string text)
        {
            string pattern = @"[a-zA-Z]+";
            Regex rx = new Regex(pattern);
            MatchCollection match = rx.Matches(text);
            string str = "";
            int length = 0;
            foreach (var item in match)
            {
                if (item.ToString().Length > length)
                {
                    length = item.ToString().Length;
                    str = item.ToString();
                }
            }
            return str;

        }
        static void Main(string[] args)
        {
            string str = "Ready, steady, go!";
            Console.WriteLine(longestWord(str));
            Console.ReadKey();
        }
    }
}
