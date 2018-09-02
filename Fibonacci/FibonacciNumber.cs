using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciNumber
    {
        public static BigInteger calcFib(int num,bool showProgress=false)
        {
            num = num - 1;
            if (showProgress)
                Console.WriteLine((num+1) + "-1=" + num.ToString("X"));
            int order = 1;
            var FN = new BigIntMat(1, 1, 1, 0);
            var sum = new BigIntMat(1, 0, 0, 1);
            while (num >= order)
            {
                if ((num & order) != 0)
                {
                    sum = sum * FN;
                }
                if(showProgress)
                    Console.WriteLine("order="+order+",sum=({0},{1},{2},{3})",sum.M11,sum.M12,sum.M21,sum.M22);
                order = order << 1;
                FN = FN * FN;
            }
            return sum.M11;
        } 
    }
}
