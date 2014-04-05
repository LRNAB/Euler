using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solver.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    class _003
    {
        /// <summary>
        /// We solve this problem by finding all the prime factors of a number eg 12
        /// 2|12     Divide 12 by lowest integer for which remainder is zero eg 2
        /// 2|6      Continue above but make the Quotient the Dividend
        /// 3|3      Increase the Divisor if remainder is not zero eg from 2 --> 3
        /// ‾|1      12 = 2 X 2 X 3
        /// So the prime factors are 2, 3
        /// The greatest is the last one ie 3
        /// </summary>
        public static void Solve()
        {
            var number = 600851475143;
            var factors = new List<long>();

            // Factors must be between 2 and 600851475143
            for (var i = 2; i <= number; i++)
            {
                // Check if remainder is 0 when 600851475143 divided by i
                while (number % i == 0)
                {
                    // i is a factor of number
                    factors.Add(i);

                    // Make Quotient the Dividend
                    number = number / i;
                }
            }

            Console.WriteLine(String.Concat("Largest Prime Factor of the number 600851475143 is ", factors[factors.Count - 1]));
        }
    }
}
