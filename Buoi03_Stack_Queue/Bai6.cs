using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai6
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\nQuản Lý Khách Hàng");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Phục vụ khách hàng");
                Console.WriteLine("3. Hiển thị hàng đợi");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                if (chon == 1)
                {
                    Console.Write("Nhập tên khách hàng: ");
                    string ten = Console.ReadLine()!;
                    q.Enqueue(ten);
                    Console.WriteLine("Đã thêm khách hàng");
                }
                else if (chon == 2)
                {
                    if (q.Count > 0)
                    {
                        Console.WriteLine("Đang phục vụ: " + q.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine("Không có khách hàng");
                    }
                }
                else if (chon == 3)
                {
                    Console.WriteLine("Danh sách khách hàng đang chờ:");
                    foreach (string x in q)
                    {
                        Console.WriteLine(x);
                    }
                    Console.WriteLine("Số khách đang chờ: " + q.Count);
                }
            } while (chon != 0);
        }
    }
}