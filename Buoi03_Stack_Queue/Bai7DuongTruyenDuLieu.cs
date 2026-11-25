using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai7DuongTruyenDuLieu
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU");
                Console.WriteLine("1. Gửi dữ liệu");
                Console.WriteLine("2. Nhận dữ liệu");
                Console.WriteLine("3. Hiển thị dữ liệu đang chờ");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập gói dữ liệu: ");
                        string goiTin = Console.ReadLine()!;
                        q.Enqueue(goiTin);
                        Console.WriteLine("Đã gửi dữ liệu");
                        break;
                    case 2:
                        if (q.Count > 0)
                        {
                            Console.WriteLine("Đã nhận dữ liệu: " + q.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("Không có dữ liệu đang chờ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Các gói dữ liệu đang chờ:");
                        foreach (string x in q)
                        {
                            Console.WriteLine(x);
                        }
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