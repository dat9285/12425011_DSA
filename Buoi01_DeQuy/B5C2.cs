using System;
namespace Buoi01_DeQuy
{
    class B5C2
    {
        public static long Fibonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n < 0 || n > 40)
            {
                Console.WriteLine("Nhập n từ 0 đến 40!");
            }
            else
            {
                Console.WriteLine("Fibonacci thứ " + n + " = " + Fibonacci(n));
            }
            Console.ReadKey();
        }
    }
}