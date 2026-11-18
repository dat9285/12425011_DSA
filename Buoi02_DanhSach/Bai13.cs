using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node13
    {
        public int info;
        public Node13? link;
        public Node13(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai13
    {
        static Node13? pHead = null;
        static void ThemCuoi(int x)
        {
            Node13 newNode = new Node13(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node13 q = pHead;
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

            int[] duLieuMau = { 1, 2, 3, 4, 5 };
            foreach (var val in duLieuMau)
            {
                ThemCuoi(val);
            }
            Console.Write("Danh sách ban đầu: ");
            Node13? p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
            Node13? prev = null;
            Node13? current = pHead;
            Node13? next = null;
            while (current != null)
            {
                next = current.link;
                current.link = prev;
                prev = current;
                current = next;
            }
            pHead = prev;
            Console.Write("Danh sách sau khi đảo ngược: ");
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