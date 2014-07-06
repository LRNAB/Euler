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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solver.Problems
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class _004
    {
        /// <summary>
        /// We only need to multiply 2 numbers which must be between 100 and 999 as 3-Digits only
        /// We can reverse the resulting number in String form and check if both normal & reverse are same
        /// </summary>
        public static void Solve()
        {
            var palindromes = new List<Int32>();

            // Start with a number eg i
            for (int i = 100; i < 999; i++)
            {
                // Find products for i with 3-Digit numbers from 100 to 999
                for (int v = 100; v < 999; v++)
                {
                    // Find product
                    var result = Convert.ToString(i * v);

                    // Reverse the product eg 10000 --> 00001
                    var reverse = new String(result.Reverse().ToArray());

                    // Check if normal and reverse are same eg 10000 != 00001
                    if (String.Equals(result, reverse))
                    {
                        Console.WriteLine(String.Concat("Found palindrome ", result));
                        palindromes.Add(Convert.ToInt32(result));
                    }
                }
            }

            Console.WriteLine(String.Concat("Largest Plaindrome is ", palindromes.Max()));
        }
    }
}