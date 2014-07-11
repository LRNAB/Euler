using System;
using System.Collections.Generic;
using Euler.Problems;

namespace Euler
{
    public static class Program
    {
        static readonly List<IProblem> Problems = new List<IProblem>
        {
            new _001(),
            new _002(),
            new _003(),
            new _004(),
            new _005(),
            new _006(),
            new _007(),
            new _008(),
            new _009(),
            new _010()
        };

        static void Main()
        {
            Console.WriteLine("Please enter the number of the problem you want to solve:");
            Console.WriteLine(Problems[Convert.ToInt32(Console.ReadLine())].Solve());
            Console.ReadKey();
        }
    }
}
