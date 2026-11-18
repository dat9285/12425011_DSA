using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node
    {
        public int info;
        public Node? link; 
        public Node(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai4
    {
        static Node? pHead = null;
        static void ThemCuoi(int x)
        {
            Node newNode = new Node(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node q = pHead;
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

            int[] duLieuMau = { 5, 2, 8, 2, 10 };
            foreach (var val in duLieuMau)
            {
                ThemCuoi(val);
            }
            int x = 2;
            int d = 0;
            Node? p = pHead;
            while (p != null)
            {
                if (p.info == x)
                {
                    d = d + 1;
                }
                p = p.link;
            }
            Console.WriteLine($"a. Số lượng phần tử có giá trị bằng {x}: {d}");
            int minduong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.info > 0 && p.info < minduong)
                {
                    minduong = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("b. Phần tử dương nhỏ nhất: " + (minduong == int.MaxValue ? "Không có" : minduong.ToString()));
            int xXoa = 2;
            if (pHead != null)
            {
                if (pHead.info == xXoa)
                {
                    pHead = pHead.link;
                }
                else
                {
                    Node? t = null;
                    p = pHead;
                    while (p != null && p.info != xXoa)
                    {
                        t = p;
                        p = p.link;
                    }
                    if (p != null && t != null)
                    {
                        t.link = p.link;
                    }
                }
            }
            Console.Write($"c. Danh sách sau khi xóa phần tử {xXoa} đầu tiên: ");
            p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}