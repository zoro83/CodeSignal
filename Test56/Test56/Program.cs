using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test56
{
    //Given an integer product, find the smallest positive(i.e.greater than 0) integer the product 
    //of whose digits is equal to product.If there is no such integer, return -1 instead.
    //Example
    //For product = 12, the output should be
    //digitsProduct(product) = 26;
    //For product = 19, the output should be
    //digitsProduct(product) = -1.
    class Program
    {
        public static int digitsProduct(int product)
        {
            bool flag = false;
            int num = product;
            string str = "";
            if (num == 0)
            {
                return 10;
            }
            if (num == 1)
            {
                return 1;
            }
            if (num < 10)
            {
                return num;
            }
            for (int i = 9; i > 1; i--)
            {
                while (num % i == 0)
                {
                    str += i;
                    num /= i;
                }
            }
            if (num > 9)
            {
                return -1;
            }
            string reversStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversStr += str[i];
            }
            Console.WriteLine(reversStr);
            return Convert.ToInt32(reversStr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(digitsProduct(600));
            Console.ReadKey();
        }
    }
}
