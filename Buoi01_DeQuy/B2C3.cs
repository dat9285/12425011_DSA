using System;
namespace Buoi01_DeQuy
{
    class B2C3
    {
        public static int TongBinhPhuong(int n)
        {
            if (n == 1)
                return 1;

            return TongBinhPhuong(n - 1) + n * n;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Tổng bình phương = " + TongBinhPhuong(n));
            Console.ReadKey();
        }
    }
}