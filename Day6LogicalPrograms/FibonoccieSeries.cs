using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class FibonoccieSeries
    {
        public static void FibonoccieNumber(int number) //5
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            if(number == 1)
            {
                Console.Write("{0}", num1);
            }
            else if(number == 2)
            {
                Console.Write("{0} {1}", num1, num2);
            }
            else
            {
                Console.Write("{0} {1}", num1, num2);
            }
            for(int i=3; i<=number; i++)
            {
                sum = num1 + num2;
                Console.Write(" {0}", sum);
                num1 = num2;
                num2 = sum;

            }
        }
    }
}
