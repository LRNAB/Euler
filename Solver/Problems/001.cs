using System;
using System.Collections.Generic;
using System.Text;

namespace Solver.Problems
{
    class _001
    {
        public static Int32 Solve()
        {
            var sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
