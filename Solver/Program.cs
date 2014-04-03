using System;
using System.Collections.Generic;
using System.Text;

namespace Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = 0;
            var stopwatch = new System.Diagnostics.Stopwatch();

            stopwatch.Start();
            solution = Problems._002.Solve();
            stopwatch.Stop();

            Console.WriteLine(solution);
            Console.WriteLine(String.Concat("Took ", stopwatch.ElapsedTicks, " ticks"));
            Console.ReadKey();
        }
    }
}
