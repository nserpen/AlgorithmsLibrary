// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;

namespace AlgorithmsLibrary
{
    public static partial class Arrays
    {
        /// <summary>
        /// Linearly search x in arr[]. If x  
        /// is present then return its location,
        /// otherwise return -1  
        /// </summary>
        /// Time complexity: O(n)
        public static int LinearSearch(int[] arr, int x)
        {
            if (arr == null)
                return -1;

            int n = arr.Length;
            if (n == 0)
                return -1;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }

            return -1;
        }
    }
}
