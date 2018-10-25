using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11
{
    class Program
    {
        static bool isLucky(int n)
        {
            int num = n;
            int length = Convert.ToString(n).Length;
            int[] digit = new int[length];
            for (int i = 0; i < length; i++)
            {
                digit[i] = num % 10;
                num /= 10;
               // Console.WriteLine(digit[i]);
            }
            int sumFirst = 0;
            int sumLast = 0;
            for (int i = 0; i < length / 2; i++)
            {
                sumLast += digit[i];
            }
            for (int i = length / 2; i < length; i++)
            {
                sumFirst += digit[i];
            }
            if (sumFirst == sumLast)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static void Main(string[] args)
        {
            int n = 1230;
            Console.WriteLine(isLucky(n));
            Console.ReadKey();
        }
    }
}
