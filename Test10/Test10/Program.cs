using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    class Program
    {
        static int commonCharacterCount(string s1, string s2)
        {
            int count = 0;
            int count1 = 1;
            int count2 = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = i + 1; j < s1.Length - 1; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        s1 = s1.Remove(j, 1);
                        count1++;

                    }
                }
                for (int k = 0; k < s2.Length; k++)
                {
                    if (s1[i] == s2[k])
                    {
                        s2 = s2.Remove(k, 1);
                        count2++;
                    }
                }
                count += Math.Min(count1, count2);
                count1 = 1;
                count2 = 0;
            }

            return count;
        }
    

        static void Main(string[] args)
        {
            string s1 = "aabcc", s2 = "adcaa";
            Console.WriteLine(commonCharacterCount(s1,s2));
            Console.ReadKey();
        }
    }
}
