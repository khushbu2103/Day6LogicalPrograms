using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the logical programs");
            Console.WriteLine("Choose any one program");
            
            
            Console.WriteLine("1.Fibonoccie Series\n" +
                "2.Perfact Number\n" +
                "3.Prime Number\n" +
                "4.Reverse Number\n" +
                "5.Coupon Number\n" +
                "6.Stopwatch");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("please enter any number of which you want fibonoccie series");
                        int number = Convert.ToInt32(Console.ReadLine());
                        FibonoccieSeries.FibonoccieNumber(number);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("please enter eny number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PerfactNumber.Factors_Addition(n);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("please enter eny number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber.PrimeNumberCalculation(n);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("please enter eny number");
                        int num = Convert.ToInt32(Console.ReadLine());
                       ReverseNumber.ReverseNumberCalculation(num);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("please enter a number");
              
                        CouponNumber.GenerateCouponNumber();
                        break;
                    }
                case 6:
                    {
                        StopwatchCalculation.TimeElapseCalulation();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("please choose existing program");
                        break;
                    }
                    
            }
            
            
        }
    }
}
