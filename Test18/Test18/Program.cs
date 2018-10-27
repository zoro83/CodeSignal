using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test18
{
    class Program
    {
        //Given a string, find out if its characters can be rearranged to form a palindrome.
        //A palindrome is a string that reads the same left-to-right and right-to-left.
        //
        //Example
        //
        //For inputString = "aabb", the output should be
        //palindromeRearranging(inputString) = true.
        //
        //We can rearrange "aabb" to make "abba", which is a palindrome.

        static bool palindromeRearranging(string inputString)
        {
            string clone = inputString;
            int count = 0;
            start:
            for (int i = 0; i < clone.Length-1; i++)
            {
                for (int j = i+1; j < clone.Length; j++)
                {
                    if (clone[i] == clone[j])
                    {
                        clone = clone.Remove(j, 1);
                        clone = clone.Remove(i, 1);
                        goto start;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            //Console.WriteLine(clone);
            if (clone.Length == 0 || clone.Length == 1)
            {
                return true;
            }
            else
                return false;
        }

        static void Main(string[] args)
        {
            string str = "aaddu";
            Console.WriteLine(palindromeRearranging(str));
            Console.ReadKey();

        }
    }
}
