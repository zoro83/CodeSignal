using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test13
{
    class Program
    {
        //You have a string s that consists of English letters, punctuation marks, 
        //whitespace characters, and brackets. 
        //It is guaranteed that the parentheses in s form a regular bracket sequence.

        //Your task is to reverse the strings contained in each pair of matching parentheses, 
        //starting from the innermost pair.The results string should not contain any parentheses.
        // Example
       
       //For string s = "a(bc)de", the output should be
       //reverseParentheses(s) = "acbde".
        static string reverseParentheses(string s)
        {
            int count = 0;
            for (int n = 0; n < s.Length; n++)
            {
                if (s[n] == '(')
                {
                    count++;
                }
            }
            for (int repet = 0; repet < count; repet++)
            {
                bool flag = true;
                int i = 0;
                while (s[i] != ')')
                {
                    if (i < s.Length - 1)
                    {
                        i++;
                    }
                    else
                    {
                        flag = false;
                        return s;
                        break;
                    }

                }
                int j = i;
                while (s[j] != '(')
                {
                    if (j > 0)
                    {
                        j--;
                    }
                    else break;
                }
                for (int k = 0; k < (i - j - 1) / 2; k++)
                {
                    //Swap(rev, i - k - 1, j + k + 1);
                    char temp1 = s[i - k - 1];
                    char temp2 = s[j + k + 1];
                    s = s.Remove(i - k - 1, 1).Insert(i - k - 1, Convert.ToString(temp2));
                    s = s.Remove(j + k + 1, 1).Insert(j + k + 1, Convert.ToString(temp1));
                    // s =  s.Replace(s[j + k + 1], temp1);
                }
                //Console.WriteLine(s[i]);
                s = s.Remove(i, 1);
                //Console.WriteLine(s[j]);
                s = s.Remove(j, 1);
            }
            
           
            return  s;
        }
        static void Main(string[] args)
        {
            string res = reverseParentheses("((quick (brown) (fox) jumps over the lazy) dog)");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
