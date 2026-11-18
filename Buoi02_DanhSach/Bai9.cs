using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai9
    {
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static bool LaSoHoanHao(int n)
        {
            if (n < 2) return false;
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i) sum += n / i;
                }
            }
            return sum == n;
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử mảng: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            Console.Write("Các số nguyên tố: ");
            foreach (var x in a) if (LaSoNguyenTo(x)) Console.Write(x + " ");
            Console.WriteLine();
            Console.Write("Các số chẵn: ");
            foreach (var x in a) if (x % 2 == 0) Console.Write(x + " ");
            Console.WriteLine();
            Console.Write("Các số hoàn hảo: ");
            foreach (var x in a) if (LaSoHoanHao(x)) Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}