using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test49
{
    //Given a string, return its encoding defined as follows:
    //First, the string is divided into the least possible number of disjoint substrings 
    //consisting of identical characters
    //for example, "aabbbc" is divided into["aa", "bbb", "c"]
    //Next, each substring with length greater than one is replaced with a concatenation of 
    //its length and the repeating character
    //for example, substring "bbb" is replaced by "3b"
    //Finally, all the new strings are concatenated together in the same order and a new string is returned.
    //Example
    //
    //For s = "aabbbc", the output should be
    //lineEncoding(s) = "2a3bc".
    class Program
    {
        public static string lineEncoding(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length - 1;)
            {
                int count = 1;
                while (i < s.Length - 1 && s[i] == s[i + 1])
                {
                    count++;
                    i++;
                }
                str += (count > 1) ? $"{count}{s[i].ToString()}" : s[i].ToString();
                i++;
            }
            if (s[s.Length - 1] != s[s.Length - 2])
            {
                str += s[s.Length - 1];
            }
            return str;
        }
        static void Main(string[] args)
        {
            string str = "ssiiggkooop";
            Console.WriteLine(lineEncoding(str));
            Console.ReadKey();

        }
    }
}
