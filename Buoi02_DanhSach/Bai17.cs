using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class SongNode
    {
        public string title;
        public SongNode? prev;
        public SongNode? next;
        public SongNode(string t)
        {
            title = t;
            prev = null;
            next = null;
        }
    }
    internal class Bai17
    {
        static SongNode? pHead = null;
        static SongNode? pTail = null;
        static SongNode? current = null;

        static void ThemBaiHat(string title)
        {
            SongNode newNode = new SongNode(title);
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
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemBaiHat("Bài hát số 1: Em của ngày hôm qua");
            ThemBaiHat("Bài hát số 2: Nơi này có anh");
            ThemBaiHat("Bài hát số 3: Chạy ngay đi");
            Console.WriteLine(" DANH SÁCH PLAYLIST ");
            SongNode? p = pHead;
            while (p != null)
            {
                Console.WriteLine($"- {p.title}");
                p = p.next;
            }
            Console.WriteLine();
            Console.WriteLine("Đang phát: " + current?.title);
            if (current?.next != null)
            {
                current = current.next;
                Console.WriteLine("Nhấn Next sang: " + current.title);
            }
            if (current?.prev != null)
            {
                current = current.prev;
                Console.WriteLine("Nhấn Previous về: " + current.title);
            }
        }
    }
}