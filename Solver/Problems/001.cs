﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solver.Problems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    class _001
    {
        public static Int32 Solve()
        {
            var sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                // Check if number is cleanly (Remainder = 0) divisble by 3 OR 5
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
