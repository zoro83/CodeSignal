using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static bool checkPalindrome(string inputString)
        {
            bool flag = true;
            char[] arr = new char[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                arr[i] = inputString[i];
            }
            for (int i = 0; i < (int)inputString.Length / 2; i++)
            {
                if (arr[i] == arr[inputString.Length - 1 - i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            return flag;
        }



        static void Main(string[] args)
        {
            bool temp = checkPalindrome("aaabaaag");
            Console.WriteLine(temp);
            temp = checkPalindrome("aaabaaa");
            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}
