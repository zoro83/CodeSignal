using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test30
{
    class Program
    {
        //Consider integer numbers from 0 to n - 1 written down along the circle in such a way 
        //that the distance between any two neighboring numbers is equal(note that 0 and n - 1 are neighboring, too).
        //Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber.
        //Example
        //For n = 10 and firstNumber = 2, the output should be
        //circleOfNumbers(n, firstNumber) = 7.
        //integer n a positive even integer
        static public int circleOfNumbers(int n, int firstNumber)
        {
            int res = 0;
            if (firstNumber < n / 2 && firstNumber > 0)
            {
                res = firstNumber + n / 2;
            }
            else if (firstNumber > n / 2 && firstNumber > 0)
            {
                res = firstNumber - n / 2;
            }
            else if (firstNumber == 0)
            {
                res = n / 2;
            }
            else
            {
                res = 0;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(circleOfNumbers(12, 7));
            Console.ReadKey();
        }
    }
}
