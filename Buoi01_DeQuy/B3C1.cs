using System;
namespace Buoi01_DeQuy
{
    class B3C1
    {
        public static void Run()
        {
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine()!;
            string daoNguoc = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                daoNguoc += s[i];
            }
            Console.WriteLine("Chuỗi đảo ngược: " + daoNguoc);
            Console.ReadKey();
        }
    }
}