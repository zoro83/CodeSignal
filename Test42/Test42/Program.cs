using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test42
{
    class Program
    {
        //Given the positions of a white bishop and a black pawn on the standard chess board, 
        //determine whether the bishop can capture the pawn in one move.
        //
        //The bishop has no restrictions in distance for each move, but is limited to diagonal movement. 
        //Check out the example below to see how it can move:
        //
        //Example
        //
        //For bishop = "a1" and pawn = "c3", the output should be
        //bishopAndPawn(bishop, pawn) = true.
        //For bishop = "h1" and pawn = "h3", the output should be
        //bishopAndPawn(bishop, pawn) = false.

        public static int PairCoordinate(char index)
        {
            switch (index)
            {
                case 'a': return 0;
                case 'b': return 1;
                case 'c': return 2;
                case 'd': return 3;
                case 'e': return 4;
                case 'f': return 5;
                case 'g': return 6;
                case 'h': return 7;
                case '1': return 0;
                case '2': return 1;
                case '3': return 2;
                case '4': return 3;
                case '5': return 4;
                case '6': return 5;
                case '7': return 6;
                case '8': return 7;
                default: return 0; // never use
            }
        }
        public static bool bishopAndPawn(string bishop, string pawn)
        {
            bool capture = false;
            bool[,] chessboard = new bool[8, 8];
            int ind1, ind2;
            int ind3, ind4;
            ind1 = PairCoordinate(bishop[0]);
            ind2 = PairCoordinate(bishop[1]);
            ind3 = PairCoordinate(pawn[0]);
            ind4 = PairCoordinate(pawn[1]);
            chessboard[ind1, ind2] = true;

            for (int k = 0; k < 8; k++)
            {
                for (int l = 0; l < 8; l++)
                {
                    chessboard[k, l] = false;
                }
            }
            int i = ind1;
            int j = ind2;
            while (i >= 0 && j >= 0)
            {
                chessboard[i, j] = true;
                i--;
                j--;
            }
            i = ind1;
            j = ind2;
            while (i >= 0 && j < 8)
            {
                chessboard[i, j] = true;
                i--;
                j++;
            }
            i = ind1;
            j = ind2;
            while (i < 8 && j >= 0)
            {
                chessboard[i, j] = true;
                i++;
                j--;
            }
            i = ind1;
            j = ind2;
            while (i < 8 && j < 8)
            {
                chessboard[i, j] = true;
                i++;
                j++;
            }
            capture = (chessboard[ind1, ind2] == chessboard[ind3, ind4]) ? capture = true : capture = false;
            return capture;
        }

        static void Main(string[] args)
        {
            string bishop = "a1";
            string pawn = "c3";
            Console.WriteLine(bishopAndPawn(bishop, pawn));
            Console.ReadKey();
        }
    }
}
