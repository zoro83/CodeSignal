using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test33
{
    class Program
    {
        //Given an array of equal-length strings, check if it is possible to rearrange the strings in such a way 
        //that after the rearrangement the strings at consecutive positions would differ by exactly one character.
        //Example
        //For inputArray = ["aba", "bbb", "bab"], the output should be
        //stringsRearrangement(inputArray) = false.
        //All rearrangements don't satisfy the description condition.
        //For inputArray = ["ab", "bb", "aa"], the output should be
        //stringsRearrangement(inputArray) = true.
        //Strings can be rearranged in the following way: "aa", "ab", "bb"

        bool stringsRearrangement(string[] r)
        {
            return r.Select((x, i) => i + x).Any(a => IsSolved(r.Select((x, i) => i + x), a));
        }

        bool IsSolved(IEnumerable<string> rs, string txt)
        {
            return rs.Count() < 2 || rs.Where(x => x.Where((c, i) => i > 0 & c != txt[i]).Count() == 1).Any(x => IsSolved(rs.Except(new[] { txt }), x));
        }
        static void Main(string[] args)
        {
        }
    }
}
