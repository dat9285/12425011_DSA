using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai10
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng/cột n cho ma trận vuông: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] matrix = new int[n, n];
            int top = 0, bottom = n - 1, left = 0, right = n - 1;
            int val = 1;
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++) matrix[top, i] = val++;
                top++;
                for (int i = top; i <= bottom; i++) matrix[i, right] = val++;
                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) matrix[bottom, i] = val++;
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) matrix[i, left] = val++;
                    left++;
                }
            }
            Console.WriteLine("Ma trận xoắn ốc:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}