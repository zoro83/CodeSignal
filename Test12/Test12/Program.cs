using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12
{
    class Program
    {
        static void Swap(int[] arr, int index1, int index2)
        {
            if (index1 != index2)
            {
                int temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;

            }
        }
            static int[] sortByHeight(int[] a)
        {
            int[] tree = new int[a.Length];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == -1)
                {
                    tree[i] = a[i];
                    count++;
                }
                
            }
            int[] human = new int[a.Length - count];
            for (int i = 0; i < (a.Length - count); )
            {
                for (int k = 0; k < a.Length; k++)
                {
                    if (a[k] != -1)
                    {
                        human[i] = a[k];
                        Console.WriteLine(human[i]);
                        i++;
                    }

                }
            }
            for (int i = 0; i < human.Length; i++)
            {
                for (int j = 1; j < human.Length-i; j++)
                {
                    if (human[j]<human[j-1])
                    {
                        Swap(human, j, j - 1);
                    }
                }
            }
            for (int i = 0; i < human.Length; )
            {
                for (int j= 0; j < tree.Length; j++)
                {
                    if (tree[j] == 0)
                    {
                        tree[j] = human[i];
                        i++;
                    }
                }
            }

            return tree;
        }
        static void Main(string[] args)
        {
            int[] a = { -1, 150, 190, 170, -1, -1, 160, 180 };
            a = sortByHeight(a);
            Console.ReadKey();
        }
    }
}
