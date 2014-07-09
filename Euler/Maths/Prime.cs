using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Maths
{
    class Prime
    {
        public static Boolean IsPrimeBruteForce(long n)
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
                    return false;
                }
                else
                {
                    // Increment to next odd number since n would never be even so division by even numbers is
                    // useless
                    i += 2;
                }
            }

            // No factor of n from 3 - Square Root of n found so we have a prime.
            return true;
        }
    }
}
