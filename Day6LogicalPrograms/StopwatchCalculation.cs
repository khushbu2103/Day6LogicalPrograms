using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class StopwatchCalculation
    {
        public static void TimeElapseCalulation()
        {
            Console.WriteLine("please enter any key to start stopwatch");
            Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("stopwatch start");

            Console.WriteLine("please enter any key to print series");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("please enter any key to stop stopwatch");
            Console.ReadLine();

            stopwatch.Stop();

            TimeSpan Elapsed = stopwatch.Elapsed;
            Console.WriteLine("stopwatch stoped");

            Console.WriteLine("Time elapded: {0}", Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
