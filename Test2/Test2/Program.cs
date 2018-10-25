using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        //Given a year, return the century it is in. The first century spans from the year 1 up to and 
        //including the year 100, the second - from the year 101 up to and including the year 200, etc.
        static int centuryFromYear(int year)
        {
            int result = 1 + (int)(year - 1) / 100;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(centuryFromYear(2000));
            Console.ReadKey();
        }
    }
}
