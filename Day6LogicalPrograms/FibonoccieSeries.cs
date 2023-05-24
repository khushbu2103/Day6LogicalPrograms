﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class FibonoccieSeries
    {
        public static void FibonoccieNumber(int n) //5
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            if(n == 1)
            {
                Console.Write("{0}", num1);
            }
            else if(n == 2)
            {
                Console.Write("{0} {1}", num1, num2);
            }
            else
            {
                Console.Write("{0} {1}", num1, num2);
            }
            for(int i=3; i<=n; i++)
            {
                sum = num1 + num2;
                Console.Write(" {0}", sum);
                num1 = num2;
                num2 = sum;

            }
        }
    }
}
