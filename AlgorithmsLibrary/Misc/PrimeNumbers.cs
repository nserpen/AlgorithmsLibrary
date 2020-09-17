// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
namespace AlgorithmsLibrary.Misc
{
    public class PrimeNumbers
    {

        /// <summary>
        /// This algorithm is normally O(n). But it is possible to make it O(n^(1/2)) or better.
        /// We'll try this.
        /// See this: <see cref="https://en.wikipedia.org/wiki/Prime_number"/>
        /// </summary>

        public static bool IsPrime1(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i < num; i++)
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    return false;
                }

            return true;
        }

        public static bool IsPrime2(int num)
        {
            if (num < 2)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;

                // O(n^(1/2)) =>
                // also known as trial division
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    return false;
                }


            return true;
        }

        // all primes greater than 3 are of the form 6k ± 1. This is because all integers can be expressed as (6k + i) for some integer k and
        // for i = −1, 0, 1, 2, 3, or 4; 2 divides (6k + 0), (6k + 2), (6k + 4); and 3 divides (6k + 3).
        // A more efficient method is to test if n is divisible by 2 or 3, then to check through all the numbers of the form 6k ± 1 ≤ sqrt(n)
        public static bool IsPrime3(int num)
        {
            if (num <= 3)
                return num > 1;
            else if (num % 2 == 0 || num % 3 == 0)
                return false;

            int i = 5;
            while ((i * i) < num && i > 4)
            {
                if ((num % i) == 0 || (num % (i + 2)) == 0 && num != (i + 2))
                {
                    Console.WriteLine(i);
                    return false;
                }
                i += 6;
            }

            return true;
        }


    }
}
