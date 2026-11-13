using System;
namespace Buoi01_DeQuy
{
    class B7C3
    {
        static int SoChuSo(int n)
        {
            if (n == 0)
                return 0;

            return SoChuSo(n / 10) + 1;
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
                Console.WriteLine("Số chữ số = " + SoChuSo(n));
            }
            Console.ReadKey();
        }
    }
}