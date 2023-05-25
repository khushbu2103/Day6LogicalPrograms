using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void PrimeNumberCalculation(int n)
        {
            int FactorCount = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n%i == 0)
                {
                   FactorCount++;
                }
            }
            if(FactorCount == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", n);
            }
            Console.ReadLine();
        }
    }
}
