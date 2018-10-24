using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test9
{
    class Program
    {
        string[] allLongestStrings(string[] inputArray)
        {
            int maxLength = inputArray[0].Length;
            int maxlengthCount = 0;
            string[] inputArrayOnlyMaxLength = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > maxLength)
                {
                    maxLength = inputArray[i].Length;
                }
            }
            int k = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == maxLength)
                {
                    
                    maxlengthCount++;
                    inputArrayOnlyMaxLength[k] = inputArray[i];
                    k++;

                }
            }
            string[] outputArray = new string[maxlengthCount];
            for (int i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = inputArrayOnlyMaxLength[i];
            }

            return outputArray;
        }

        static void Main(string[] args)
        {
        }
    }
}
