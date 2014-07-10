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
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    /// </summary>
    class _002
    {
        public static Int32 Solve()
        {
            var sum = 0;

            var firstTerm = 0;
            var secondTerm = 1;
            var nextTerm = 0;

            // Fibonacci sequence term cannot exceed 4 million
            while (nextTerm < 4000000)
            {
                // Get next Fibonacci sequence term
                nextTerm = firstTerm + secondTerm;

                // Update variables for new term
                firstTerm = secondTerm;
                secondTerm = nextTerm;

                // Check if term is even by dividing by 2 and checking if remainder is zero
                if (nextTerm % 2 == 0)
                    sum += nextTerm;
            }

            return sum;
        }
    }
}
