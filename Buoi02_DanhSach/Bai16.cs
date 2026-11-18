using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class WebNode
    {
        public string url;
        public WebNode? prev;
        public WebNode? next;
        public WebNode(string u)
        {
            url = u;
            prev = null;
            next = null;
        }
    }
    internal class Bai16
    {
        static WebNode? pHead = null;
        static WebNode? pTail = null;
        static WebNode? current = null;
        static void ThemTrang(string u)
        {
            WebNode newNode = new WebNode(u);
            if (pHead == null)
            {
                pHead = newNode;
                pTail = newNode;
                current = newNode;
            }
            else
            {
                pTail!.next = newNode;
                newNode.prev = pTail;
                pTail = newNode;
                current = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemTrang("google.com");
            ThemTrang("github.com");
            ThemTrang("stackoverflow.com");
            Console.WriteLine("Đang ở trang hiện tại: " + current?.url);
            if (current?.prev != null)
            {
                current = current.prev;
                Console.WriteLine("Nhấn Back về trang: " + current.url);
            }
            if (current?.next != null)
            {
                current = current.next;
                Console.WriteLine("Nhấn Forward tới trang: " + current.url);
            }
        }
    }
}