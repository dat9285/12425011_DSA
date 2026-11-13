using System;
namespace Buoi01_DeQuy
{
    class B5C3
    {
        public static int UocLeMax(int n)
        {
            if (n % 2 != 0)
                return n;
            return UocLeMax(n / 2);
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
                Console.WriteLine("Ước lẻ lớn nhất = " + UocLeMax(n));
            }
            Console.ReadKey();
        }
    }
}