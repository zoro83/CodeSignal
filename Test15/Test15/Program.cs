using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test15
{
    class Program
    {
        // Given a rectangular matrix of characters, add a border of asterisks(*) to it.
        //
        //Example
        //For
        //picture = ["abc",
        //           "ded"]
        //the output should be
        //addBorder(picture) = ["*****",
        //                      "*abc*",
        //                      "*ded*",
        //                      "*****"]

        static string[] addBorder(string[] picture)
        {
            string[] borderArr = new string[picture.Length + 2];
            int length = picture[0].Length;
            for (int i = 0; i < length + 2; i++)
            {
                borderArr[0] += "*";
            }
            borderArr[picture.Length + 1] = borderArr[0];
            for (int i = 1; i < borderArr.Length - 1; i++)
            {
                borderArr[i] = "*" + picture[i - 1] + "*";
            }
            return borderArr;
        }
        static void Main(string[] args)
        {
        }
    }
}
