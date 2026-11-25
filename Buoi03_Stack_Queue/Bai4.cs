using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai4
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\n Hệ Thống In Ấn ");
                Console.WriteLine("1. Thêm tài liệu");
                Console.WriteLine("2. In tài liệu");
                Console.WriteLine("3. Hiển thị hàng đợi");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                if (chon == 1)
                {
                    Console.Write("Nhập tên tài liệu: ");
                    string ten = Console.ReadLine()!;
                    q.Enqueue(ten);
                    Console.WriteLine("Đã thêm tài liệu");
                }
                else if (chon == 2)
                {
                    if (q.Count > 0)
                    {
                        Console.WriteLine("Đang in: " + q.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine("Không có tài liệu cần in");
                    }
                }
                else if (chon == 3)
                {
                    Console.WriteLine("Danh sách tài liệu:");

                    foreach (string x in q)
                    {
                        Console.WriteLine(x);
                    }
                }
            } while (chon != 0);
        }
    }
}