using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test53
{
    //Check if the given string is a correct time representation of the 24-hour clock.
    //Example
    //For time = "13:58", the output should be
    //validTime(time) = true;
    //For time = "25:51", the output should be
    //validTime(time) = false;
    //For time = "02:76", the output should be
    //validTime(time) = false.
    class Program
    {
        public static bool validTime(string time)
        {
            DateTime dt;
            bool isvaliddate = DateTime.TryParse(time, out dt);
            return isvaliddate;
        }
        static void Main(string[] args)
        {
            string time = "53:58";
            Console.WriteLine(validTime(time));
            Console.ReadKey();
        }
    }
}
