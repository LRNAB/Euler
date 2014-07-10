using Euler.Maths;
using System;

namespace Euler.Problems
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    class _010
    {
        public static void Solve()
        {
            long sum = 2;
            for (long i = 3; i < 2000000; i += 2)
            {
                if (Prime.IsPrimeBruteForce(i))
                    sum += i;
            }

            Console.WriteLine(String.Format("Sum of all the primes below two million is {0}", sum));
        }
    }
}
