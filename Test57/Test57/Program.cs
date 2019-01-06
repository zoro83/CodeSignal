using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test57
{
    //You are given an array of desired filenames in the order of their creation.
    //Since two files cannot have equal names, the one which comes later will have an addition 
    //to its name in a form of(k), where k is the smallest positive integer such that the obtained 
    //name is not used yet.
    //Return an array of names that will be given to the files.
    //Example
    //For names = ["doc", "doc", "image", "doc(1)", "doc"], the output should be
    //fileNaming(names) = ["doc", "doc(1)", "image", "doc(1)(1)", "doc(2)"].
    class Program
    {
        public static string[] fileNaming(string[] names)
        {
            string[] copy = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                copy[i] = names[i];
            }
            for (int i = 0; i < names.Length - 1; i++)
            {
                int index = 1;
                string temp = "";
                for (int j = i + 1; j < names.Length; j++)
                {

                    if (names[i] == names[j])
                    {
                        temp = names[i] + $"({index})";
                        for (int p = 0; p < j; p++)
                        {
                            if (copy[p] == temp)
                            {
                                index++;
                                temp = names[i] + $"({index})";
                            }
                        }
                        names[j] = temp;
                        index++;
                    }
                }
            }
            return names;
        }

        static void Main(string[] args)
        {
            string[] names = { "a(1)", "a(6)", "a", "a", "a", "a", "a", "a", "a", "a", "a" };
            names = fileNaming(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
