// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary.Misc
{
    public class Strings
    {

        static int HashSum(string s)
        {
            return s.Sum(c => c.GetHashCode());
        }

        /// <summary>
        /// Returns indexes of permutations found [ almost O(n) ]
        /// </summary>
        public static List<int> FindStringPermutations1(string str, string src)
        {
            var lenSrc = src.Length;
            int reqHash = HashSum(src);

            List<int> indexes = new List<int>();

            for (var i = 0; i < str.Length - lenSrc + 1; i++)
            {
                var subStr = str.Substring(i, lenSrc);
                var h = HashSum(subStr);
                if (reqHash == h)
                {
                    indexes.Add(i);
                }
            }

            return indexes;

        }
    }
}
