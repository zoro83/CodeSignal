using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    class Program
    {
        // Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, 
        //each statue having an non-negative integer size.Since he likes to make things perfect, 
        //he wants to arrange them from smallest to largest so that each statue will be bigger than the 
        //previous one exactly by 1. He may need some additional statues to be able to accomplish that.
        //Help him figure out the minimum number of additional statues needed.
        //
        //Example
        //
        //For statues = [6, 2, 3, 8], the output should be
        //makeArrayConsecutive2(statues) = 3.
        //
        //Ratiorg needs statues of sizes 4, 5 and 7.
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
