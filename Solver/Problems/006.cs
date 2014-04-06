using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solver.Problems
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    class _006
    {
        public static void Solve()
        {
            // Find sum of squares of first 100 natural numbers
            var squareSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                squareSum = squareSum + (i * i);
            }
            Console.WriteLine(String.Concat("Sum of Squares of first 100 natural numbers is ", squareSum));

            // Find square of sum of first 100 natural numbers
            var sumSquare = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumSquare += i;
            }

            // sumSquare *= sumSquare;
            sumSquare = sumSquare * sumSquare;
            Console.WriteLine(String.Concat("Square of Sum of first 100 natural numbers is ", sumSquare));

            Console.WriteLine(String.Concat("Difference is ", sumSquare - squareSum));
        }
    }
}
