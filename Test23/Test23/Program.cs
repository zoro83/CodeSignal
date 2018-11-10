using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test23
{
    class Program
    {
        // Last night you partied a little too hard.Now there's a black and white photo of you that's 
        //about to go viral! You can't let this ruin your reputation, so you want to apply the box blur 
        //algorithm to the photo to hide its content.
        // The pixels in the input image are represented as integers.The algorithm distorts the input 
        //image in the following way: Every pixel x in the output image has a value equal to the average 
        //value of the pixel values from the 3 × 3 square that has its center at x, including x itself.
        //All the pixels on the border of x are then removed.
        // 
        // Return the blurred image as an integer, with the fractions rounded down.

        static int[][] boxBlur(int[][] image)
        {
            //int[][] clone;
            int n = image.Length;
            int small;
            int[][] res = new int[n - 2][];
            for (int i = 0; i < n-2; i++)
            {
                small = Math.Min(image[i].Length, image[i + 1].Length);
                small = Math.Min(small, image[i + 2].Length);
                res[i] = new int[small-2];

            }


            for (int i = 0; i < n - 2; i++)
            {
                small = Math.Min(image[i].Length, image[i + 1].Length);
                small = Math.Min(small, image[i + 2].Length);

                for (int j = 0; j < small - 2; j++)
                {
                    res[i][j] = (int)(image[i][j] + image[i][j + 1] + image[i][j + 2] +
                        image[i + 1][j] + image[i + 1][j + 1] + image[i + 1][j + 2] +
                        image[i + 2][j] + image[i + 2][j + 1] + image[i + 2][j + 2]) / 9;

                }

            }

            return res;
        }
        static void Main(string[] args)
        {
            int[][] jaggedArray =
                                { new int[] { 3, 5, 7, },
                                  new int[] { 1, 0, 2, 4, 6 },
                                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8},
                                  new int[] { 4, 5, 6, 7, 8}};
            for (int i = 0; i < boxBlur(jaggedArray).Length; i++)
            {
                for (int j = 0; j < boxBlur(jaggedArray)[i].Length; j++)
                {
                    Console.Write($"'{boxBlur(jaggedArray)[i][j]}'");
                }
                Console.WriteLine();
            };
            Console.ReadKey();


        }
    }
}
