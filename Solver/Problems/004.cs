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
        /// We only need to multiply 2 numbers which must be between 100 and 999 as 3-Digit only
        /// We can reverse the resulting number in String form and check if both normal & reverse are same
        /// </summary>
        public static void Solve()
        {
            var palindromes = new List<Int32>();

            for (int i = 100; i < 999; i++)
            {
                for (int v = 100; v < 999; v++)
                {
                    var result = Convert.ToString(i * v);
                    var reverse = new String(result.Reverse().ToArray());
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