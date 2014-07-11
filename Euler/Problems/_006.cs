﻿// Copyright 2014 LRNAB <rvaveo+lrnab@gmail.com>

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace Euler.Problems
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class _006 : IProblem
    {
        public String Solve()
        {
            // Find sum of squares of first 100 natural numbers
            var squareSum = 0;

            for (var i = 1; i <= 100; i++)
            {
                squareSum = squareSum + (i * i);
            }
            Console.WriteLine("Sum of Squares of first 100 natural numbers is {0}", squareSum);

            // Find square of sum of first 100 natural numbers
            var sumSquare = 0;

            for (var i = 1; i <= 100; i++)
            {
                sumSquare += i;
            }

            // sumSquare *= sumSquare;
            sumSquare = sumSquare * sumSquare;
            Console.WriteLine("Square of Sum of first 100 natural numbers is {0}", sumSquare);

            return String.Format("Difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is {0}", sumSquare - squareSum);
        }
    }
}