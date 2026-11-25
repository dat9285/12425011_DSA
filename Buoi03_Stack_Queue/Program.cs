using System;
using System.Text;
namespace Buoi03_Stack_Queue
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int chon;
            do
            {
                Console.WriteLine("\nBUỔI 03: STACK VÀ QUEUE - BÀI TẬP CUỐI CHƯƠNG 5");
                Console.WriteLine("1. Bài 1 - Kiểm tra biểu thức toán học");
                Console.WriteLine("2. Bài 2 - Lịch sử trình duyệt web");
                Console.WriteLine("3. Bài 3 - Function Call Stack");
                Console.WriteLine("4. Bài 4 - Mô phỏng hệ thống in ấn");
                Console.WriteLine("5. Bài 5 - Mô phỏng đường truyền dữ liệu");
                Console.WriteLine("6. Bài 6 - Quản lý hàng đợi khách hàng");
                Console.WriteLine("\nBÀI TẬP CUỐI SÁCH - BÀI 3: CÀI ĐẶT NGĂN XẾP VÀ HÀNG ĐỢI");
                Console.WriteLine("7. Bài 4 - Mô phỏng lịch sử trình duyệt web");
                Console.WriteLine("8. Bài 5 - Kiểm tra chuỗi ngoặc đúng/sai");
                Console.WriteLine("9. Bài 6 - Mô phỏng hệ thống in");
                Console.WriteLine("10. Bài 7 - Mô phỏng đường truyền dữ liệu");
                Console.WriteLine("11. Bài 8 - Mô phỏng dịch vụ khách hàng");
                Console.WriteLine("12. Bài 9 - Tính giá trị biểu thức hậu tố");
                Console.WriteLine("13. Bài 10 - Kiểm tra tính hợp lệ biểu thức trung tố");
                Console.WriteLine("14. Bài 11 - Tính giá trị biểu thức trung tố");
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
                        Bai6.Run();
                        break;
                    case 7:
                        Bai4LichSuTrinhDuyet.Run();
                        break;
                    case 8:
                        Bai5KiemTraChuoiNgoac.Run();
                        break;
                    case 9:
                        Bai6HeThongInCuoiSach.Run();
                        break;
                    case 10:
                        Bai7DuongTruyenDuLieu.Run();
                        break;
                    case 11:
                        Bai8DichVuKhachHang.Run();
                        break;
                    case 12:
                        Bai9TinhBieuThucHauTo.Run();
                        break;
                    case 13:
                        Bai10KiemTraTrungTo.Run();
                        break;
                    case 14:
                        Bai11TinhBieuThucTrungTo.Run();
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            } while (chon != 0);
        }
    }
}