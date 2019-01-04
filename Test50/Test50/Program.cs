using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test50
{
    // Given a position of a knight on the standard chessboard, find the number of different moves the 
    //knight can perform.
    //The knight can move to a square that is two squares horizontally and one square vertically, 
    //or two squares vertically and one square horizontally away from it.The complete move therefore 
    //looks like the letter L.Check out the image below to see all valid moves for a knight piece 
    //that is placed on one of the central squares.
    //For cell = "a1", the output should be chessKnight(cell) = 2
    //For cell = "c2", the output should be chessKnight(cell) = 6.
    class Program
    {
        public static int chessKnight(string cell)
        {
            int index1 = Convert.ToInt32(cell[0]) - 97;
            int index2 = Convert.ToInt32(cell[1]) - 49;
            if ((index1 >= 2 && index1 <= 5) &&
                (index2 >= 2 && index2 <= 5))
                return 8;
            else if ((index1 >= 2 && index1 <= 5) &&
               (index2 == 1 || index2 == 6))
                return 6;
            else if ((index2 >= 2 && index2 <= 5) &&
               (index1 == 1 || index1 == 6))
                return 6;
            else if ((index1 == 1 || index1 == 6) &&
               (index2 == 1 || index2 == 6))
                return 4;
            else if ((index1 >= 2 && index1 <= 5) &&
               (index2 == 0 || index2 == 7))
                return 4;
            else if ((index2 >= 2 && index2 <= 5) &&
               (index1 == 0 || index1 == 7))
                return 4;
            else if ((index1 == 0 || index2 == 7) &&
               (index2 == 0 || index2 == 7))
                return 2;
            else
                return 3;
        }

        static void Main(string[] args)
        {
            string cell = "h8";
            Console.WriteLine(chessKnight(cell));
            Console.ReadKey();
        }
    }
}
