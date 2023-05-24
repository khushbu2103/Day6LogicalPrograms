using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class PerfactNumber
    {
        public static void Factors_Addition(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
              if(n % i == 0)
                {
                  sum += i;
                }
            }
            
            if (sum == n)
            {
                Console.WriteLine("{0} is perfact number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", n);
            }
            Console.ReadLine();

        }
    }
}
