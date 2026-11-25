using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai2
    {
        public static void Run()
        {
            Stack<string> back = new Stack<string>();
            Stack<string> forward = new Stack<string>();
            string hienTai = "";
            int chon;
            do
            {
                Console.WriteLine("\n1. Truy cập trang mới");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                if (chon == 1)
                {
                    Console.Write("Nhập trang web: ");
                    string trang = Console.ReadLine()!;

                    if (hienTai != "")
                        back.Push(hienTai);
                    hienTai = trang;
                    forward.Clear();
                }
                else if (chon == 2)
                {
                    if (back.Count > 0)
                    {
                        forward.Push(hienTai);
                        hienTai = back.Pop();
                    }
                    else
                        Console.WriteLine("Không thể Back");
                }
                else if (chon == 3)
                {
                    if (forward.Count > 0)
                    {
                        back.Push(hienTai);
                        hienTai = forward.Pop();
                    }
                    else
                        Console.WriteLine("Không thể Forward");
                }
                Console.WriteLine("Trang hiện tại: " + hienTai);
            } while (chon != 0);
        }
    }
}