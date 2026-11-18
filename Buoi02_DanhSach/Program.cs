using System;
using System.Runtime.Intrinsics.X86;
using System.Text;
namespace Buoi02_DanhSach
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int chon;
            do
            {
                Console.WriteLine("\n BUỔI 02: DANH SÁCH ");
                Console.WriteLine("1. Bài 1 - Chèn phần tử vào mảng");
                Console.WriteLine("2. Bài 2 - Quản lý nhân viên");
                Console.WriteLine("3. Bài 3 - Xử lý ma trận");
                Console.WriteLine("4. Bài 4 - Danh sách liên kết đơn");
                Console.WriteLine("5. Bài 5 - Thống kê danh sách liên kết đơn");
                Console.WriteLine("\n CÀI ĐẶT MẢNG VÀ DSLK ");
                Console.WriteLine("6. Bài 7 - Quản lý nhiệt độ");
                Console.WriteLine("7. Bài 8 - Thống kê từ");
                Console.WriteLine("8. Bài 9 - Xử lý số nguyên");
                Console.WriteLine("9. Bài 10 - Ma trận xoắn ốc");
                Console.WriteLine("10. Bài 11 - Ma trận đặc biệt");
                Console.WriteLine("11. Bài 12 - Game Minesweeper");
                Console.WriteLine("12. Bài 13 - Đảo ngược danh sách");
                Console.WriteLine("13. Bài 14 - Gộp hai danh sách đã sắp xếp");
                Console.WriteLine("14. Bài 15 - Phát hiện chu trình");
                Console.WriteLine("15. Bài 16 - Lịch sử duyệt web");
                Console.WriteLine("16. Bài 17 - Playlist nhạc");
                Console.WriteLine("17. Bài 18 - Hệ thống đặt hàng");
                Console.WriteLine("\n0. Thoát");   
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Bai1.Run();
                        break;
                    case 2:
                        Bai2.Run();
                        break;
                    case 3:
                        Bai3.Run();
                        break;
                    case 4:
                        Bai4.Run();
                        break;
                    case 5:
                        Bai5.Run();
                        break;
                    case 6:
                        Bai7.Run();
                        break;
                    case 7:
                        Bai8.Run();
                        break;
                    case 8:
                        Bai9.Run();
                        break;
                    case 9:
                        Bai10.Run();
                        break;
                    case 10:
                        Bai11.Run();
                        break;
                    case 11:
                        Bai12.Run();
                        break;
                    case 12:
                        Bai13.Run();
                        break;
                    case 13:
                        Bai14.Run();
                        break;
                    case 14:
                        Bai15.Run();
                        break;
                    case 15:
                        Bai16.Run();
                        break;
                    case 16:
                        Bai17.Run();
                        break;
                    case 17:
                        Bai18.Run();
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 0);
        }
    }
}