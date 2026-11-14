using System;
namespace Buoi01_DeQuy
{
    class B6C3
    {
        public static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        public static void Run()
        {
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine()!);
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Vui lòng nhập hai số dương!");
            }
            else
            {
                Console.WriteLine("UCLN = " + UCLN(a, b));
            }
            Console.ReadKey();
        }
    }
}