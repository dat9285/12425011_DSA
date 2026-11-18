using System;
using System.Text;
namespace Buoi02_DanhSach
{
    class Bai1
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Mảng vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("\nNhập giá trị x: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập vị trí k: ");
            int k = int.Parse(Console.ReadLine()!);
            if (k < 0 || k > n)
            {
                Console.WriteLine("Vị trí k không hợp lệ!");
            }
            else
            {
                int[] b = new int[n + 1];

                for (int i = 0; i < k; i++)
                {
                    b[i] = a[i];
                }
                b[k] = x;
                for (int i = k; i < n; i++)
                {
                    b[i + 1] = a[i];
                }
                Console.WriteLine("Mảng sau khi chèn:");
                for (int i = 0; i < n + 1; i++)
                {
                    Console.Write(b[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}