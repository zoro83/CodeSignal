using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Program
    {
        // Below we will define an n-interesting polygon.Your task is to find the area of a polygon for a given n.
        //
        //A 1-interesting polygon is just a square with a side of length 1. 
        //An n-interesting polygon is obtained by taking the n - 1-interesting polygon and 
        //appending 1-interesting polygons to its rim, side by side.
        //You can see the 1-, 2-, 3- and 4-interesting polygons in the picture below.
        //
        //Example
        //
        //For n = 2, the output should be
        //shapeArea(n) = 5;
        //For n = 3, the output should be
        //shapeArea(n) = 13.
        static int ShapeArea(int n)
        { 
            int sum = 2 * n - 1;
            for (int i = 2 * n - 3; i > 0; i -= 2)
            {
                sum = sum + 2 * i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int res = ShapeArea(5);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
