using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test47
{

    //A media access control address(MAC address) is a unique identifier assigned to network interfaces 
    //for communications on the physical network segment.
    //The standard (IEEE 802) format for printing MAC-48 addresses in human-friendly form is six groups 
    //of two hexadecimal digits(0 to 9 or A to F), separated by hyphens(e.g. 01-23-45-67-89-AB).
    //
    //Your task is to check by given string inputString whether it corresponds to MAC-48 address or not.
    //Example
    //For inputString = "00-1B-63-84-45-E6", the output should be
    //isMAC48Address(inputString) = true;
    //For inputString = "Z1-1B-63-84-45-E6", the output should be
    //isMAC48Address(inputString) = false;
    //For inputString = "not a MAC-48 address", the output should be
    //isMAC48Address(inputString) = false.
    class Program
    {
        public static bool isMAC48Address(string inputString)
        {
            if (inputString.Length != 17)
            {
                return false;
            }
            string str = inputString + "-";
            for (int i = 0; i < 17;)
            {
                if (str[i] >= 'A' && str[i] <= 'F' || str[i] >= '0' && str[i] <= '9'
                    && str[i + 1] >= 'A' && str[i + 1] <= 'F' || str[i + 1] >= '0' && str[i + 1] <= '9'
                    && str[i + 2] == '-')
                    i += 3;
                else
                    return false;
                
            }
            return true;
        }

        static void Main(string[] args)
        {
            string str = "00-1B-63-84-45-E6";
            Console.WriteLine(isMAC48Address(str));
            Console.ReadKey();
        }
    }
}
