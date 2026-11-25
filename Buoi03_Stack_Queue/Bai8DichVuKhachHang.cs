using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai8DichVuKhachHang
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG DỊCH VỤ KHÁCH HÀNG");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Phục vụ khách hàng");
                Console.WriteLine("3. Hiển thị danh sách khách hàng chờ");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập tên khách hàng: ");
                        string ten = Console.ReadLine()!;
                        q.Enqueue(ten);
                        Console.WriteLine("Đã thêm khách hàng vào hàng đợi");
                        break;
                    case 2:
                        if (q.Count > 0)
                        {
                            Console.WriteLine("Đang phục vụ khách hàng: " + q.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("Không có khách hàng nào trong hàng đợi");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Danh sách khách hàng đang chờ:");
                        foreach (string x in q)
                        {
                            Console.WriteLine(x);
                        }
                        Console.WriteLine("Số khách đang chờ: " + q.Count);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            } while (chon != 0);
        }
    }
}