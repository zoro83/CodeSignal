using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test16
{
    class Program
    {
        // Two arrays are called similar if one can be obtained from another by swapping at most one 
        // pair of elements in one of the arrays.
        //
        // Given two arrays a and b, check whether they are similar.
        //
        // Example
        //
        // For a = [1, 2, 3] and b = [1, 2, 3], the output should be
        // areSimilar(a, b) = true.
        // 
        // The arrays are equal, no need to swap any elements.
        //
        // For a = [1, 2, 3] and b = [2, 1, 3], the output should be
        // areSimilar(a, b) = true.
        //
        // We can obtain b from a by swapping 2 and 1 in b.
        //
        // For a = [1, 2, 2] and b = [2, 1, 1], the output should be
        // areSimilar(a, b) = false.

        static bool areSimilar(int[] a, int[] b)
        {
            bool flag = false;
            int index1 = 0;
            int index2 = 0;
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    count++;
                    if (count == 1)
                    {
                        index1 = i;
                    }
                    if (count == 2)
                    {
                        index2 = i;
                    }
                }

            }
            if (count == 2 && a[index1] == b[index2] && a[index2] == b[index1])
            {
                flag = true;
                return flag;
            }
            else if (count == 0)
            {
                flag = true;
                return flag;
            }
            else
            {
                flag = false;
                return flag;
            }
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 1, 4 };
            int[] b = { 1, 2, 3 };
            bool fl = areSimilar(a, b);
            Console.WriteLine(fl);
            Console.ReadKey();
        }
    }
}
