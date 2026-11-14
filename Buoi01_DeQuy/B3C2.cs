using System;
namespace Buoi01_DeQuy
{
    class B3C2
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (KiemTraNguyenTo(n))
                Console.WriteLine(n + " là số nguyên tố");
            else
                Console.WriteLine(n + " không phải số nguyên tố");
            Console.ReadKey();
        }
    }
}