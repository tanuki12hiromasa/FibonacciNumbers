using System;

namespace FibConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            if (args.Length < 1) num = 8;
            else num = int.Parse(args[0]);
            if (num <= 0) num = 1;
            var fib = Fibonacci.FibonacciNumber.calcFib(num, true);
            Console.WriteLine(num + "項目のフィボナッチ数は" + fib);
        }
    }
}
