using System;
namespace Buoi01_DeQuy
{
    class B8C3
    {
        static double Can(int i, int n)
        {
            if (i == n)
                return Math.Sqrt(n);
            return Math.Sqrt(i + Can(i + 1, n));
        }
        static double TongCan(int n)
        {
            return Can(1, n);
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập n > 0!");
            }
            else
            {
                Console.WriteLine("Kết quả = " + TongCan(n));
            }
            Console.ReadKey();
        }
    }
}