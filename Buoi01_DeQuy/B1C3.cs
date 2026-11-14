using System;
namespace Buoi01_DeQuy
{
    class B1C3
    {
        public static int Tong(int n)
        {
            if (n == 1)
                return 1;
            return Tong(n - 1) + n;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Tổng S(n) = " + Tong(n));
            Console.ReadKey();
        }
    }
}