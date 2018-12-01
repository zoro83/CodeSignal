using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test45
{
    class Program
    {
        public static bool ChackPalindrome(string str, out int count)
        {
            count = 0;
            bool flag = true;
            if (str.Length > 1)
            {
                for (int i = 0; i < str.Length / 2; )
                {
                    if (str[i] == str[str.Length-1-i])
                    {
                        i++;
                        count++;
                    }
                    else
                    {
                        flag = false;
                        return flag;
                    }
                }
            }
            return flag;
        }

        public static string buildPalindrome(string st)
        {
            string palidrome = st;
            while (!ChackPalindrome(palidrome, out int count))
            {

                for (int i = count; i >= 0; i--)
                {
                    palidrome = st + palidrome.Insert(st.Length+count-i, $"{st[i]}"); 
                }
            }

            return palidrome;
        }
        static void Main(string[] args)
        {
            string st = "abcdc";
            //Console.WriteLine(st.Substring(0,2));
            //Console.WriteLine(ChackPalindrome(st));
            //st = st.Insert(4, "n");
            //Console.WriteLine(st);
            Console.WriteLine(buildPalindrome(st));
            Console.ReadKey();
        }
    }
}
