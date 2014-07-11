// Copyright 2014 LRNAB <rvaveo+lrnab@gmail.com>

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

using Euler.Maths;
using System;

namespace Euler.Problems
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
    public class _007 : IProblem
    {
        public String Solve()
        {
            var primesFound = 1;
            var n = 3;

            while (primesFound < 10001)
            {
                if (Prime.IsPrimeBruteForce(n))
                {
                    primesFound++;

                    if (primesFound < 10001)
                        n += 2;
                }
            }

            return String.Format("10001st Prime is {0}", n);
        }
    }
}
