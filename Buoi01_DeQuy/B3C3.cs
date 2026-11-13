using System;
namespace Buoi01_DeQuy
{
    class B3C3
    {
        public static double TongPhanSo(int n)
        {
            if (n == 1)
                return 1;

            return TongPhanSo(n - 1) + 1.0 / n;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Tổng phân số = " + TongPhanSo(n));
            Console.ReadKey();
        }
    }
}