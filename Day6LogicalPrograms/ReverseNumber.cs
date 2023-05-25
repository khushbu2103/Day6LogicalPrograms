using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void ReverseNumberCalculation(int num) //1234
        {
            int remainder = 0;
            int reverse = 0;
           while (num != 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num/ 10;
            }
           Console.WriteLine(reverse);
           Console.ReadLine();
        }
    }
}
