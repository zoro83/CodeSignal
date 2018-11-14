using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test43
{
    class Program
    {
        //A string is said to be beautiful if b occurs in it no more times than a; c occurs in it no more 
        //times than b; etc.
        //
        //Given a string, check whether it is beautiful.
        //Example
        //For inputString = "bbbaacdafe", the output should be
        //isBeautifulString(inputString) = true;
        //For inputString = "aabbb", the output should be
        //isBeautifulString(inputString) = false;
        //For inputString = "bbc", the output should be
        //isBeautifulString(inputString) = false.

        public static bool isBeautifulString(string inputString)
        {
            bool isBeautiful = true;
            int[] arr = new int[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                arr[i] = Convert.ToInt32(inputString[i]);
            }
            int count = 0;
            int temp = inputString.Length;
            for (int i = 97; i < 123; i++)
            {
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == i)
                    {
                        inputString = inputString.Remove(j, 1);
                        count++;
                        j--;
                    }
                }
                if (count == 0 && inputString.Length > 0)
                {
                    return false;
                }
                if (temp >= count)
                {
                    temp = count;
                    count = 0;
                }
                else return isBeautiful = false;
            }

            return isBeautiful;
        }
        static void Main(string[] args)
        {

            //Console.WriteLine(Convert.ToInt32('a'));
            //Console.WriteLine(Convert.ToInt32('a' + 25));
            Console.WriteLine(isBeautifulString("abcdefghijklmnopqrstuvwxyzqwertuiopasdfghjklxcvbnm"));
            Console.ReadKey();
        }
    }
}
