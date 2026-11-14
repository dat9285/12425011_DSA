using System;
namespace Buoi01_DeQuy
{
    class B4C2
    {
        public static bool LaSoHoanHao(int n)
        {
            if (n <= 1)
                return false;
            int tong = 1;
            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                    int uoc = n / i;

                    if (uoc != i)
                        tong += uoc;
                }
            }
            return tong == n;
        }
        public static void Run()
        {
            Console.Write("Nhập N: ");
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Các số hoàn hảo nhỏ hơn N:");
            for (int i = 2; i < N; i++)
            {
                if (LaSoHoanHao(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}