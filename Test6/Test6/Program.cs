using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    class Program
    {
        static int MakeArrayConsecutive2(int[] statues)
        {
            int count = 0;
            int min = statues.Min();
            int max = statues.Max();
            count = max - min + 1 - statues.Length;
            return count;
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 9, 6, 1 };
            int neded = MakeArrayConsecutive2(arr);
            Console.WriteLine(neded);
            Console.ReadKey();
        }
    }
}
