using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solver.Problems
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
    class _007
    {
        public static void Solve()
        {
            int primesFound = 1;
            int n = 3;

            while (primesFound < 10001)
            {
                // All primes except 2 are odd so no need to check by 2
                int i = 3;
                
                // Check until Square root only as after that the divisors flip and repeat eg
                // 2 x 5 = 10
                // 5 x 2 = 10
                // So we only need to check until Sqrt(10) = 3.16...
                while (i <= Math.Sqrt(n))
                {
                    if (n % i == 0)
                    {
                        // Remainder was zero so number isn't a prime.
                        // All primes except 2 are odd so only need to test odd numbers and skip even numbers.
                        n += 2;

                        // Reset loop for next odd number
                        i = 3;
                        continue;
                    }
                    else
                    {
                        // Increment to next odd number since n would never be even so division by even numbers is
                        // useless
                        i += 2;
                    }
                }

                // No factor found so we have a new prime. 
                primesFound++;

                if(primesFound < 10001)
                    n += 2;
            }

            Console.WriteLine(String.Concat("10001st Prime is ", n));
        }
    }
}
