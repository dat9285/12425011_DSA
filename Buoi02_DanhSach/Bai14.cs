using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node14
    {
        public int info;
        public Node14? link;
        public Node14(int x) { info = x; }
    }
    internal class Bai14
    {
        static Node14? Gop(Node14? a, Node14? b)
        {
            if (a == null) return b;
            if (b == null) return a;
            if (a.info < b.info)
            {
                a.link = Gop(a.link, b);
                return a;
            }
            b.link = Gop(a, b.link);
            return b;
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Node14 l1 = new Node14(1) { link = new Node14(3) { link = new Node14(5) } };
            Node14 l2 = new Node14(2) { link = new Node14(4) { link = new Node14(6) } };
            Node14? kq = Gop(l1, l2);
            Console.Write("Sau khi gộp: ");
            while (kq != null)
            {
                Console.Write(kq.info + " ");
                kq = kq.link;
            }
            Console.WriteLine();
        }
    }
}