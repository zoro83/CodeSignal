using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test38
{
    class Program
    {
        public static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int days = 1;
            int height = 0;
            while (true)
            {
                height += upSpeed;
                if (height >= desiredHeight)
                {
                    break;
                }
                height -= downSpeed;
                days++;
            }
            return days;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(growingPlant(100, 10, 910));
            Console.ReadKey();
        }
    }
}
