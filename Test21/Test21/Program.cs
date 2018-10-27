using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test21
{
    class Program
    {
        // An IP address is a numerical label assigned to each device(e.g., computer, printer) 
        //participating in a computer network that uses the Internet Protocol for communication.
        //There are two versions of the Internet protocol, and thus two versions of addresses.
        //One of them is the IPv4 address.
        //
        //IPv4 addresses are represented in dot-decimal notation, which consists of four decimal numbers, 
        //each ranging from 0 to 255 inclusive, separated by dots, e.g., 172.16.254.1.
        //
        //Given a string, find out if it satisfies the IPv4 address naming rules.
        //
        //Example
        //
        //For inputString = "172.16.254.1", the output should be
        //isIPv4Address(inputString) = true;
        //
        //For inputString = "172.316.254.1", the output should be
        //isIPv4Address(inputString) = false.
        //
        //316 is not in range[0, 255].
        //
        //For inputString = ".254.255.0", the output should be
        //isIPv4Address(inputString) = false.
        //
        //There is no first number.

        static bool isIPv4Address(string inputString)
        {
            //bool flag = false;
            int[] a = new int[3];
            int count = 0;
            int[] num = new int[4];
            string str = inputString;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    count++;
                    switch (count)
                    {
                        case 1:
                            a[0] = i;
                            break;
                        case 2:
                            a[1] = i;
                            break;
                        case 3:
                            a[2] = i;
                            break;
                        default:
                            return false;
                    }
                }

            }
            if (count != 3)
            {
                return false;
            }

            string temp = "";
            if (a[0] > 0 && a[1] > a[0] + 1 && a[2] > a[1] + 1)
            {
                for (int i = 0; i < a[0]; i++)
                {
                    temp += inputString[i];

                }
                //Int32.TryParse(temp, out num[0])
                if (Int32.TryParse(temp, out num[0]))
                {
                    num[0] = Convert.ToInt32(temp);
                }
                else
                {
                    return false;
                }
                //Console.WriteLine(num[0]);
                temp = "";

                for (int i = a[0] + 1; i < a[1]; i++)
                {
                    temp += inputString[i];
                }
                if (Int32.TryParse(temp, out num[1]))
                {
                    num[1] = Convert.ToInt32(temp);
                }
                else
                {
                    return false;
                }
                //Console.WriteLine(num[1]);
                temp = "";

                for (int i = a[1] + 1; i < a[2]; i++)
                {
                    temp += inputString[i];
                }
                if (Int32.TryParse(temp, out num[2]))
                {
                    num[2] = Convert.ToInt32(temp);
                }
                else
                {
                    return false;
                }
                //Console.WriteLine(num[2]);
                temp = "";

                for (int i = a[2] + 1; i < inputString.Length; i++)
                {
                    temp += inputString[i];
                }
                if (Int32.TryParse(temp, out num[3]))
                {
                    num[3] = Convert.ToInt32(temp);
                }
                else
                {
                    return false;
                }
                //Console.WriteLine(num[3]);
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] > 255)
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            string inputString = "172.16.254.1";
            Console.WriteLine(isIPv4Address(inputString));
            Console.ReadKey();
        }
    }
}
