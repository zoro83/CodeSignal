using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test28
{
    //Given a string, replace each its character by the next one in the English alphabet
    //(z would be replaced by a).
    //Example
    //For inputString = "crazy", the output should be
    //alphabeticShift(inputString) = "dsbaz".

    class Program
    {
        static string alphabeticShift(string inputString)
        {
            string res = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'z')
                {
                    res += "a";
                }
                else if (inputString[i] == 'Z')
                {

                    res += "A";
                }
                else
                {
                    res += Convert.ToChar((inputString[i]) + 1);
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            string inputString = "Zcradyz";
            Console.WriteLine(alphabeticShift(inputString));
            Console.ReadKey();
        }
    }
}
