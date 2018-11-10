using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test26
{
    class Program
    {
        bool evenDigitsOnly(int n)
        {
            int num = n;
            bool flag = true;
            for (int i = 0; i < Convert.ToString(n).Length; i++)
            {
                if (num % 10 % 2 == 0)
                {
                    num /= 10;
                }
                else
                    flag = false;
            }

            return flag;
        }
        static void Main(string[] args)
        {
        }
    }
}
