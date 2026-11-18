using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class OrderNode
    {
        public string status;
        public OrderNode? prev;
        public OrderNode? next;
        public OrderNode(string s)
        {
            status = s;
            prev = null;
            next = null;
        }
    }
    internal class Bai18
    {
        static OrderNode? pHead = null;
        static OrderNode? pTail = null;
        static OrderNode? currentOrder = null;
        static void ThemTrangThai(string s)
        {
            OrderNode newNode = new OrderNode(s);
            if (pHead == null)
            {
                pHead = newNode;
                pTail = newNode;
                currentOrder = newNode;
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
            ThemTrangThai("Chờ xử lý");
            ThemTrangThai("Đang giao");
            ThemTrangThai("Hoàn thành");
            Console.WriteLine("=== QUẢN LÝ TRẠNG THÁI ĐƠN HÀNG ===");
            Console.WriteLine("Trạng thái hiện tại: " + currentOrder?.status);
            if (currentOrder?.next != null)
            {
                currentOrder = currentOrder.next;
                Console.WriteLine("Chuyển trạng thái tiếp theo: " + currentOrder.status);
            }
            if (currentOrder?.next != null)
            {
                currentOrder = currentOrder.next;
                Console.WriteLine("Chuyển trạng thái tiếp theo: " + currentOrder.status);
            }
            if (currentOrder?.prev != null)
            {
                currentOrder = currentOrder.prev;
                Console.WriteLine("Quay lại trạng thái trước: " + currentOrder.status);
            }
        }
    }
}