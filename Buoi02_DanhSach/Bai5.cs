using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node5
    {
        public int info;
        public Node5? link;
        public Node5(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai5
    {
        static Node5? pHead = null;
        static void ThemCuoi(int x)
        {
            Node5 newNode = new Node5(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node5 q = pHead;
                while (q.link != null)
                {
                    q = q.link;
                }
                q.link = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] duLieuMau = { -5, 7, 10, 0, 4, -2 };
            foreach (var val in duLieuMau)
            {
                ThemCuoi(val);
            }
            Console.Write("Danh sách hiện tại: ");
            Node5? p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
            int max = int.MinValue;
            p = pHead;
            while (p != null)
            {
                if (p.info > max)
                {
                    max = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("a. Phần tử lớn nhất trong danh sách: " + max);
            int tong = 0;
            p = pHead;
            while (p != null)
            {
                tong += p.info;
                p = p.link;
            }
            Console.WriteLine("b. Tổng các phần tử trong danh sách: " + tong);
            int demNT = 0;
            p = pHead;
            while (p != null)
            {
                int val = p.info;
                bool laNT = true;
                if (val < 2) laNT = false;
                else
                {
                    for (int i = 2; i <= Math.Sqrt(val); i++)
                    {
                        if (val % i == 0) { laNT = false; break; }
                    }
                }
                if (laNT) demNT++;
                p = p.link;
            }
            Console.WriteLine("c. Số lượng số nguyên tố trong danh sách: " + demNT);

            int demAm = 0, demKhong = 0, demDuong = 0;
            p = pHead;
            while (p != null)
            {
                if (p.info < 0) demAm++;
                else if (p.info == 0) demKhong++;
                else demDuong++;
                p = p.link;
            }
            Console.WriteLine($"d. Thống kê: Số âm = {demAm}, Số bằng 0 = {demKhong}, Số dương = {demDuong}");

            int x = 7;
            int demX = 0;
            p = pHead;
            while (p != null)
            {
                if (p.info == x) demX++;
                p = p.link;
            }
            Console.WriteLine($"e. Số lượng phần tử có giá trị bằng {x}: {demX}");
            int minDuong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.info > 0 && p.info < minDuong)
                {
                    minDuong = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("f. Phần tử dương nhỏ nhất: " + (minDuong == int.MaxValue ? "Không có" : minDuong.ToString()));
        }
    }
}