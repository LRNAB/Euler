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

using System;

namespace Euler.Problems
{
    /// <summary>
    // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    // a² + b² = c²
    // For example, 3² + 4² = 9 + 16 = 25 = 5².
    // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    // Find the product abc.
    /// </summary>
    class _009
    {
        public static void Solve()
        {
            // Rearrange equation to make c the subject
            // a + b + c = 1000
            // c = 1000 - a - b

            // Substitute c² = a² + b² in a + b + c = 1000 and Simplify
            // a + b + √a² + b² = 1000
            // a² + b² = (1000 - a - b)²
            // a² + b² = 1000000 - 2000(a+b) + a² + 2ab + b²
            // a² - a² + b² - b² = 1000000 - 2000(a+b) + 2ab
            // 2000(a+b) - 2ab = 1000000
            // 1000(a+b) - ab = 500000
            // 1000a - ab + 1000b = 500000
            // a(1000 - b) + 1000b = 500000
            // a(1000 - b) = 500000 - 1000b
            // a = (500000 - 1000b) ÷ (1000 - b)

            for (int b = 1; b < 1000; b++)
            {
                var a = (500000 - 1000 * b) / (1000 - b);
                var c = 1000 - a - b;

                // Check: a + b + c = 1000, a² + b² = c²
                if (a + b + c == 1000 && (a * a) + (b * b) == (c * c))
                {
                    Console.WriteLine(String.Concat("Pythagorean triplet for which a + b + c = 1000 is ", a * b * c));
                    break;
                }
            }
        }        
    }
}
