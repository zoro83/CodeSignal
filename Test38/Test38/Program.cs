using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test38
{
    class Program
    {
        //Each day a plant is growing by upSpeed meters.Each night that plant's height decreases by 
        //downSpeed meters due to the lack of sun heat. Initially, plant is 0 meters tall. 
        //We plant the seed at the beginning of a day. We want to know when the height of the plant will 
        //reach a certain level.
        //Example
        //For upSpeed = 100, downSpeed = 10, and desiredHeight = 910, the output should be
        //growingPlant(upSpeed, downSpeed, desiredHeight) = 10.

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
