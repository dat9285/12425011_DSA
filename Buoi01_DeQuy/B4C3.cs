using System;
namespace Buoi01_DeQuy
{
    class B4C3
    {
        public static double LuyThua(double x, int n)
        {
            if (n == 0)
                return 1;
            if (n < 0)
                return 1.0 / LuyThua(x, -n);
            return LuyThua(x, n - 1) * x;
        }
        public static void Run()
        {
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine()!);
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (x == 0 && n <= 0)
            {
                Console.WriteLine("Không hợp lệ!");
            }
            else if (n == int.MinValue)
            {
                Console.WriteLine("Số mũ không hợp lệ!");
            }
            else
            {
                Console.WriteLine("Kết quả = " + LuyThua(x, n));
            }
            Console.ReadKey();
        }
    }
}