using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test27
{
    class Program
    {
        // Correct variable names consist only of English letters, 
        // digits and underscores and they can't start with a digit.
        // 
        // Check if the given string is a correct variable name.
        // Example
        // For name = "var_1__Int", the output should be
        // variableName(name) = true;
        //         For name = "qq-q", the output should be
        //         variableName(name) = false;
        // For name = "2w2", the output should be
        // variableName(name) = false.

        static bool variableName(string name)
        {
            bool res = true;
            if (name[0] >= '0' && name[0] <= '9')
            {
                res = false;
                return res;
            }
            for (int i = 0; i < name.Length;)
            {
                if (name[i] >= '0' && name[i] <= '9'
                    || name[i] >= 'a' && name[i] <= 'z'
                    || name[i] >= 'A' && name[i] <= 'Z'
                    || name[i] == '_')
                {
                    i++;
                }
                else
                {
                    res = false;
                    return res;
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            string name = "var_1__Int";
            Console.WriteLine(variableName(name));
            //Console.WriteLine(Convert.ToInt32('1'));
            //Console.WriteLine(Convert.ToInt32('0'));
            //Console.WriteLine(Convert.ToInt32('9'));
            //Console.WriteLine(Convert.ToInt32('_'));
            //Console.WriteLine(Convert.ToInt32('Q'));
            //Console.WriteLine(Convert.ToInt32('P'));
            //Console.WriteLine(Convert.ToInt32('q'));
            //Console.WriteLine(Convert.ToInt32('p'));
            Console.WriteLine(Convert.ToInt32('-'));

            Console.ReadKey();
        }
    }
}
