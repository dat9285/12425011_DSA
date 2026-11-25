using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai5
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\n Mô Phỏng Truyền Dữ Liệu ");
                Console.WriteLine("1. Gửi gói tin");
                Console.WriteLine("2. Xử lý gói tin");
                Console.WriteLine("3. Hiển thị gói tin");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                if (chon == 1)
                {
                    Console.Write("Nhập gói tin: ");
                    string goiTin = Console.ReadLine()!;
                    q.Enqueue(goiTin);
                    Console.WriteLine("Đã gửi gói tin");
                }
                else if (chon == 2)
                {
                    if (q.Count > 0)
                    {
                        Console.WriteLine("Đang xử lý: " + q.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine("Không có gói tin");
                    }
                }
                else if (chon == 3)
                {
                    Console.WriteLine("Các gói tin đang chờ:");
                    foreach (string x in q)
                    {
                        Console.WriteLine(x);
                    }
                }
            } while (chon != 0);
        }
    }
}