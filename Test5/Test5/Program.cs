using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Program
    {
        static int ShapeArea(int n)
        {
            int sum = 2 * n - 1;
            for (int i = 2 * n - 3; i > 0; i -= 2)
            {
                sum = sum + 2 * i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int res = ShapeArea(5);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
