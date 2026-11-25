using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai6HeThongInCuoiSach
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG HỆ THỐNG IN");
                Console.WriteLine("1. Thêm yêu cầu in");
                Console.WriteLine("2. Xử lý yêu cầu in");
                Console.WriteLine("3. Hiển thị danh sách chờ");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập tên tài liệu: ");
                        string ten = Console.ReadLine()!;
                        q.Enqueue(ten);
                        Console.WriteLine("Đã thêm yêu cầu in");
                        break;
                    case 2:
                        if (q.Count > 0)
                        {
                            Console.WriteLine("Đang in: " + q.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("Không có yêu cầu in nào");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Danh sách yêu cầu in đang chờ:");
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