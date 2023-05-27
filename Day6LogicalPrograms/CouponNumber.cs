using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class CouponNumber
    {
        public static void GenerateCouponNumber()
        {
            int DistinictCouponNumber = Convert.ToInt32(Console.ReadLine());
            int[] CouponNumbers = new int[DistinictCouponNumber];

            Random random = new Random();
            int CountOfDistinict = 0;
            int r = random.Next(0, DistinictCouponNumber + 1);
            CouponNumbers[CountOfDistinict] = r;
            int NumOfItteration = 1;


            while (CountOfDistinict < DistinictCouponNumber)
            {
                bool ValueOccured = false;
                r = random.Next(1, DistinictCouponNumber + 1);
                NumOfItteration++;
                for (int i = 0; i <= CountOfDistinict; i++)
                {
                    if (CouponNumbers[i] == r)
                    {
                        ValueOccured = true;
                        break;
                    }
                }
                if (ValueOccured)
                {
                    continue;
                }
                CouponNumbers[CountOfDistinict] = r;
                CountOfDistinict++;
            }
            Console.WriteLine("Total number of iterations requried to generate {0} distinct numbers are {1}", DistinictCouponNumber, NumOfItteration);
           
            Console.WriteLine("Here are the respective array generated:");
            for (int i = 0; i < DistinictCouponNumber; i++)
            {
                if (i != 0 && i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(CouponNumbers[i] + "\t");
            }
            Console.ReadLine();
        }

    }
}
