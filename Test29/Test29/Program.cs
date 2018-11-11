using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test29
{
    class Program
    {
    //Given two cells on the standard chess board, determine whether they have the same color or not.
    //Example
    //For cell1 = "A1" and cell2 = "C3", the output should be
    //chessBoardCellColor(cell1, cell2) = true

        static bool chessBoardCellColor(string cell1, string cell2)
        {
            bool[,] arr = { { true, false }, { false, true } };
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            int index4 = 0;

            if (cell1[0] == 'A' || cell1[0] == 'C' ||
                cell1[0] == 'E' || cell1[0] == 'G')
            {
                index1 = 0;
                if (cell1[1] == '1' || cell1[1] == '3' ||
                cell1[1] == '5' || cell1[1] == '7')
                {
                    index2 = 1;
                }
                else index2 = 0;

            }
            else
            {
                index1 = 1;
                if (cell1[1] == '1' || cell1[1] == '3' ||
                cell1[1] == '5' || cell1[1] == '7')
                {
                    index2 = 1;
                }
                else index2 = 0;
            }
            if (cell2[0] == 'A' || cell2[0] == 'C' ||
                cell2[0] == 'E' || cell2[0] == 'G')
            {
                index3 = 0;
                if (cell2[1] == '1' || cell2[1] == '3' ||
                cell2[1] == '5' || cell2[1] == '7')
                {
                    index4 = 1;
                }
                else index4 = 0;

            }
            else
            {
                index3 = 1;
                if (cell2[1] == '1' || cell2[1] == '3' ||
                cell2[1] == '5' || cell2[1] == '7')
                {
                    index4 = 1;
                }
                else index4 = 0;
            }


            if (arr[index2, index1] == arr[index4, index3])
            {
                return true;
            }
            else
                return false;
        }

        static void Main(string[] args)
        {
            string cell1 = "A1";
            string cell2 = "H3";
            Console.WriteLine(chessBoardCellColor(cell1, cell2));
            Console.ReadKey();
        }
    }
}
