using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai4LichSuTrinhDuyet
    {
        public static void Run()
        {
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string currentPage = "";
            int chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT");
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Quay lại");
                Console.WriteLine("3. Tiến lên");
                Console.WriteLine("4. Hiển thị trang hiện tại");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập URL: ");
                        string url = Console.ReadLine()!;
                        if (currentPage != "")
                        {
                            backStack.Push(currentPage);
                        }
                        currentPage = url;
                        forwardStack.Clear();
                        Console.WriteLine("Đang truy cập: " + currentPage);
                        break;
                    case 2:
                        if (backStack.Count > 0)
                        {
                            forwardStack.Push(currentPage);
                            currentPage = backStack.Pop();
                            Console.WriteLine("Quay lại: " + currentPage);
                        }
                        else
                        {
                            Console.WriteLine("Không thể quay lại");
                        }
                        break;
                    case 3:
                        if (forwardStack.Count > 0)
                        {
                            backStack.Push(currentPage);
                            currentPage = forwardStack.Pop();

                            Console.WriteLine("Tiến lên: " + currentPage);
                        }
                        else
                        {
                            Console.WriteLine("Không thể tiến lên");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Trang hiện tại: " + currentPage);
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