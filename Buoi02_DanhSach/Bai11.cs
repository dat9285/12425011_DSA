using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai11
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng/cột n cho ma trận vuông: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[n, n];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
            bool laDonVi = true;
            bool laDoiXung = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && a[i, j] != 1) laDonVi = false;
                    if (i != j && a[i, j] != 0) laDonVi = false;
                    if (a[i, j] != a[j, i]) laDoiXung = false;
                }
            }
            Console.WriteLine("Ma trận đơn vị: " + (laDonVi ? "Đúng" : "Sai"));
            Console.WriteLine("Ma trận đối xứng: " + (laDoiXung ? "Đúng" : "Sai"));
        }
    }
}