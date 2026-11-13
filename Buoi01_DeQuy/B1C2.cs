using System;
namespace Buoi01_DeQuy
{
    class B1C2
    {
        public static void ThapHaNoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine("Chuyển đĩa 1 từ cọc " + A + " sang cọc " + C);
                return;
            }
            ThapHaNoi(n - 1, A, C, B);
            Console.WriteLine("Chuyển đĩa " + n + " từ cọc " + A + " sang cọc " + C);
            ThapHaNoi(n - 1, B, A, C);
        }
        public static void Run()
        {
            Console.Write("Nhập số đĩa n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập n > 0!");
            }
            else
            {
                Console.WriteLine("\nCác bước chuyển đĩa:");
                ThapHaNoi(n, 'A', 'B', 'C');
                int soLan = (int)Math.Pow(2, n) - 1;
                Console.WriteLine("\nTổng số lần chuyển đĩa = " + soLan);
            }
            Console.ReadKey();
        }
    }
}