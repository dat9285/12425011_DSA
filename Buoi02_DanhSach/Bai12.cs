using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai12
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng m: ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] board = new int[m, n];
            Random rand = new Random();
            Console.Write("Nhập số lượng mìn muốn đặt: ");
            int soMin = int.Parse(Console.ReadLine()!);
            int dem = 0;
            while (dem < soMin)
            {
                int r = rand.Next(m);
                int c = rand.Next(n);
                if (board[r, c] != -1)
                {
                    board[r, c] = -1;
                    dem++;
                }
            }
            int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == -1) continue;
                    int count = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ni = i + dr[k];
                        int nj = j + dc[k];
                        if (ni >= 0 && ni < m && nj >= 0 && nj < n && board[ni, nj] == -1)
                        {
                            count++;
                        }
                    }
                    board[i, j] = count;
                }
            }
            Console.WriteLine("Bảng Minesweeper (-1 là mìn, số là số mìn xung quanh):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{board[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}