using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test33
{
    class Program
    {
        public static int diferentByOneCharacter(string str1, string str2)
        {
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    count++;
                }
            }
            return count;
        }
        public static bool stringsRearrangement(string[] inputArray)
        {
            bool res = false;
            int count = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (diferentByOneCharacter(inputArray[i], inputArray[j]) == 1)
                    {
                        count++;
                    }
                }
            }

            return (count > inputArray.Length - 1) ? true : false;
        }
        static void Main(string[] args)
        {
        }
    }
}
