using System;
using System.Text;
namespace Buoi02_DanhSach
{
    class Bai3
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập cấp ma trận n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhập a[" + i + "," + j + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
            Console.WriteLine("\nMa trận vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong = tong + a[i, j];
                }
            }
            Console.WriteLine("\nTổng các phần tử của ma trận: " + tong);
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0 && a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            if (min == int.MaxValue)
            {
                Console.WriteLine("Ma trận không có phần tử dương");
            }
            else
            {
                Console.WriteLine("Giá trị dương nhỏ nhất: " + min);
            }
            int tongCheoPhu = 0;
            for (int i = 0; i < n; i++)
            {
                tongCheoPhu = tongCheoPhu + a[i, n - 1 - i];
            }
            Console.WriteLine("Tổng đường chéo phụ: " + tongCheoPhu);
            bool tangDan = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    tangDan = false;
                    break;
                }
            }
            if (tangDan)
            {
                Console.WriteLine("Đường chéo chính tăng dần");
            }
            else
            {
                Console.WriteLine("Đường chéo chính không tăng dần");
            }
        }
    }
}