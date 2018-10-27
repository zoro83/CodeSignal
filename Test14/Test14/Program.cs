using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test14
{
    class Program
    {
        // Several people are standing in a row and need to be divided into two teams.
        //The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, 
        //the fourth into team 2, and so on.
        //
        //You are given an array of positive integers - the weights of the people.
        //Return an array of two integers, where the first element is the total weight of team 1, 
        //and the second element is the total weight of team 2 after the division is complete.
        //
        //Example
        //
        //For a = [50, 60, 60, 45, 70], the output should be
        //alternatingSums(a) = [180, 105].

        static int[] alternatingSums(int[] a)
        {
            int[] weight = new int[2];
            for (int i = 0; i < a.Length; i += 2)
            {
                weight[0] += a[i];
            }

            for (int i = 1; i < a.Length; i += 2)
            {
                weight[1] += a[i];
            }

            return weight;
        }

        static void Main(string[] args)
        {
            int[] res = { 50, 60, 60, 45, 70 };
            res = alternatingSums(res);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.ReadKey();
        }
    }
}
