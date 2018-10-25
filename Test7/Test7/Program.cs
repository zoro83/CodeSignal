using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    class Program
    {
        // Given a sequence of integers as an array, determine whether it is possible to obtain a strictly 
        //increasing sequence by removing no more than one element from the array.
        //
        //Example
        //
        //For sequence = [1, 3, 2, 1], the output should be
        //almostIncreasingSequence(sequence) = false.
        //
        //There is no one element in this array that can be removed in order to get a strictly increasing sequence.
        //
        //For sequence = [1, 3, 2], the output should be
        //almostIncreasingSequence(sequence) = true.
        //
        //You can remove 3 from the array to get the strictly increasing sequence[1, 2]. Alternately, 
        //you can remove 2 to get the strictly increasing sequence[1, 3].
        static bool almostIncreasingSequence(int[] sequence)
        {
            bool flag = false;
            bool flag2 = false;
            int[] increasingSeq1 = new int[sequence.Length - 1];
            int[] increasingSeq2 = new int[sequence.Length - 1];
            if (sequence.Length > 2)
            {
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] < sequence[i + 1])
                    {
                        flag = true;

                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            increasingSeq1[j] = sequence[j];
                        }
                        for (int j = i; j < (sequence.Length - 1); j++)
                        {
                            increasingSeq1[j] = sequence[j + 1];
                        }
                        for (int l = 0; l < i + 1; l++)
                        {
                            increasingSeq2[l] = sequence[l];
                        }
                        for (int l = i + 1; l < (sequence.Length - 1); l++)
                        {
                            increasingSeq2[l] = sequence[l + 1];
                        }


                    }
                }
                for (int i = 0; i < sequence.Length - 2; i++)
                {
                    if (increasingSeq1[i] < increasingSeq1[i + 1])
                    {
                        flag = true;
                    }
                    else { flag = false; break; }
                }
                for (int i = 0; i < sequence.Length - 2; i++)
                {
                    if (increasingSeq2[i] < increasingSeq2[i + 1])
                    {
                        flag2 = true;
                    }
                    else { flag2 = false; break; }
                }
            }
            else flag = true;
            return (flag || flag2) ? true : false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 1 };
            Console.WriteLine(almostIncreasingSequence(arr));
            Console.ReadKey();
        }
    }
}
