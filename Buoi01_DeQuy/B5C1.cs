using System;
namespace Buoi01_DeQuy
{
    class B5C1
    {
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n < 0 || n > 92)
            {
                Console.WriteLine("Vui lòng nhập n từ 0 đến 92!");
            }
            else
            {
                long a = 0;
                long b = 1;
                for (int i = 2; i <= n; i++)
                {
                    long c = a + b;
                    a = b;
                    b = c;
                }
                if (n == 0)
                {
                    Console.WriteLine("Số Fibonacci thứ " + n + " là: 0");
                }
                else
                {
                    Console.WriteLine("Số Fibonacci thứ " + n + " là: " + b);
                }
            }
            Console.ReadKey();
        }
    }
}