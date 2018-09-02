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
        static void Main(string[] args)
        {
            int num;
            if (args.Length < 1) num = 8;
            else num = int.Parse(args[0]);
            if (num <= 0) num = 1;
            var fib = calcFib(num, true);
            Console.WriteLine(num + "項目のフィボナッチ数は" + fib);
        }

        public static BigInteger calcFib(int num,bool showProgress=false)
        {
            num = num - 1;
            if (showProgress)
                Console.WriteLine((num+1) + "-1=" + num.ToString("X"));
            int order = 1;
            var FN = new BigIntMat(1, 1, 1, 0);
            var sum = new BigIntMat(0, 0, 0, 0);
            while (num > order)
            {
                if ((num & order) != 0)
                {
                    sum += FN;
                }
                order = order << 1;
                FN = FN * FN;
            }
            return sum.M11;
        } 
    }
}
