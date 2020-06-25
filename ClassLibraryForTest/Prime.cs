using System;
using System.Collections.Generic;


namespace NarekLibrary.ForTest
{
    /// <summary>
    /// A class to deal with prime numbers. It supports integer numbers.
    /// </summary>
    class Prime
    {
        /// <summary>
        /// Checks if the given integer number is prime or not. Note that 0 and 1 are not prime numbers. Returns true for primes.
        /// </summary>
        /// <param name="value"> Integer number</param>
        /// <returns>True/False</returns>
        public static bool IsPrime(int value)
        {
            if (value <= 1) { return false; }
            if (value == 2 || value == 3) { return true; }
            if (value % 2 == 0) { return false; }
            int squar = (int)Math.Ceiling(Math.Sqrt((double)value));
            for (int i = 3; i <= squar; i = i + 2)
            {
                if (value % i == 0) { return false; }
            }
            return true;
        }

        /// <summary>
        /// Returns the next prime in range of Integer numbers. In case of large numbers, close to int.MaxValue, result might be 2.
        /// </summary>
        /// <param name="num">Integer number</param>
        /// <returns>Next prime in range of Integer numbers</returns>
        public int nextPrime(int num)
        {
            if (num < 2) { return 2; }
            if (num < 3) { return 3; }
            if (num < 5) { return 5; }
            if (num < 7) { return 7; }

            
            while (!IsPrime(++num)) ;
            return num;
        }

        /// <summary>
        /// Returns an array of Integer numbers, containing all prime factors of the given number. It returns 0 for numbers smaller than 2.
        /// Example'    25 -> 5 x 5
        ///             12 -> 2 x 2 x 3
        ///             14 -> 2 x 7
        ///             11 -> 11
        /// </summary>
        /// <param name="num"></param>
        /// <returns>An array of prime factors of the given number</returns>
        public int[] primeFactors(int num)
        {
            List<int> result = new List<int>();
            if (num < 2)
            {
                result.Add(0);
                return result.ToArray();
            }
            int prime = 2;
            while (num / prime >= 1)
            {
                if (num % prime == 0)
                {
                    result.Add(prime);
                    num = num / prime;
                }
                else
                {
                    prime = nextPrime(prime);
                }
            }
            return result.ToArray();

        }
    }
}
