using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test36
{
    class Program
    {
        //Given a string, find the number of different characters in it.
        //Example
        //For s = "cabca", the output should be
        //differentSymbolsNaive(s) = 3.
        //There are 3 different characters a, b and c.

        public static int differentSymbolsNaive(string s)
        {
            string clone = s;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        s = s.Remove(j, 1);
                        j = j - 1;
                    }
                }
            }
            return s.Length;
        }
        static void Main(string[] args)
        {
            string s = "ccctyb";
            //s = s.Remove(1,1);
            //Console.WriteLine(s);
            Console.WriteLine(differentSymbolsNaive(s));
            Console.ReadKey();
        }
    }
}
