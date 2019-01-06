using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test58
{
    //You are taking part in an Escape Room challenge designed specifically for programmers.
    //In your efforts to find a clue, you've found a binary code written on the wall behind a vase, 
    //and realized that it must be an encrypted message. After some thought, your first guess is that 
    //each consecutive 8 bits of the code stand for the character with the corresponding extended ASCII code.
    //Assuming that your hunch is correct, decode the message.
    //Example
    //For code = "010010000110010101101100011011000110111100100001", the output should be
    //messageFromBinaryCode(code) = "Hello!".

    class Program
    {
        public static int BitStringToInt(string bits)
        {
            int num = 0;
            for (int i = bits.Length - 1; i >= 0; i--)
            {
                if (bits[i] == '1')
                {
                    num += (int)Math.Pow(2, bits.Length - 1 - i);
                }
            }
            return num;
        }
        public static string messageFromBinaryCode(string code)
        {
            char key;
            string msg = "";
            for (int i = 0; i < code.Length; i += 8)
            {
                key = Convert.ToChar(BitStringToInt(code.Substring(i, 8)));
                msg += key;
            }
            return msg;
        }

        static void Main(string[] args)
        {
            string str = "010010000110010101101100011011000110111100100001";
            //int num = BitStringToInt(str);
            //Console.WriteLine(num);
            //char ch = 'Q';
            //Console.WriteLine(Convert.ToInt32(ch));
            Console.WriteLine(messageFromBinaryCode(str));
            Console.ReadKey();
        }
    }
}
