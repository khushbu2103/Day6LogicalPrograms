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
            Console.WriteLine("please enter any number of which you want fibonoccie series");
            int n = Convert.ToInt32(Console.ReadLine());
            FibonoccieSeries.FibonoccieNumber(n);
            Console.ReadLine();
        }
    }
}
