using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node15
    {
        public int info;
        public Node15? link;
        public Node15(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai15
    {
        static Node15? pHead = null;
        static void ThemCuoi(int x)
        {
            Node15 newNode = new Node15(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node15 q = pHead;
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
            ThemCuoi(1);
            ThemCuoi(2);
            ThemCuoi(3);
            ThemCuoi(4);
            Node15? tail = pHead;
            while (tail != null && tail.link != null)
            {
                tail = tail.link;
            }
            if (tail != null)
            {
                tail.link = pHead?.link;
            }
            Node15? slow = pHead;
            Node15? fast = pHead;
            bool coChuTrinh = false;

            while (fast != null && fast.link != null)
            {
                slow = slow!.link;
                fast = fast.link.link;

                if (slow == fast)
                {
                    coChuTrinh = true;
                    break;
                }
            }
            if (coChuTrinh)
            {
                Console.WriteLine("Danh sách liên kết CÓ chứa chu trình.");
            }
            else
            {
                Console.WriteLine("Danh sách liên kết KHÔNG chứa chu trình.");
            }
        }
    }
}