using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test46
{
    class Program
    {
        public static int electionsWinners(int[] votes, int k)
        {
            int maxCandidateCount = 0; // who can win
            int currenMaxVotes = 0;    // current win
            int votesMax = votes.Max();


            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] + k > votesMax)
                {
                    maxCandidateCount++;
                }
                if (votes[i] == votesMax)
                {
                    currenMaxVotes++;
                }
            }

            if (currenMaxVotes == 1 && k == 0)
            {
                maxCandidateCount = 1;
            }
            return maxCandidateCount;
        }

        static void Main(string[] args)
        {
            int[] arr = { 9, 9, 3, 4, 1 };
            Console.WriteLine(electionsWinners(arr, 0));
            Console.ReadKey();
        }
    }
}
