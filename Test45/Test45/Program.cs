using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test45
{
    class Program
    {

        public static string buildPalindrome(string st)
        {
            string polidrome = st;
            int count = 0;

            for (int i = 0; i < polidrome.Length / 2;)
            {
                if (polidrome[i] == polidrome[polidrome.Length - 1 - i])
                {
                    i++;
                    count++;
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        polidrome = polidrome.Insert(st.Length + j, $"{st[i - j]}");
                    }
                    //Console.WriteLine(polidrome);
                    count = 1;
                }
            }
            return polidrome;
        }
        static void Main(string[] args)
        {
            string st = "abcdckba";
            //st = st.Insert(4, "n");
            //Console.WriteLine(st);
            Console.WriteLine(buildPalindrome(st));
            Console.ReadKey();
        }
    }
}
