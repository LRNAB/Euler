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

namespace Euler.Problems
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    class _005
    {
        /// <summary>
        /// Loop throught 1 to 20 and divide number by 1-20. If any division does not result in remainder zere
        /// Increment the number and reset loop to 1.
        /// </summary>
        public static void Solve()
        {
            // Start from 20 as any number below that won't be evenly divisble by 20
            var number = 20;
            
            for (int i = 1; i < 20; i++)
            {
                if (number % i != 0)
                {
                    // Increment number as i could not evenly divide it.
                    number += 1;

                    i = 1; // Reset i for new number.
                }
            }

            Console.WriteLine(String.Concat("Number found ", number));
        }
    }
}