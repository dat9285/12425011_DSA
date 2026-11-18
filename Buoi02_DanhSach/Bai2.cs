using System;
using System.Text;
namespace Buoi02_DanhSach
{
    struct NhanVien
    {
        public string MaNV;
        public string HoTen;
        public int NamSinh;
        public string PhongBan;
        public int LuongCoBan;
        public int Thuong;
        public int ThucLinh;
    }
    class Bai2
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nhân viên: ");
            int n = int.Parse(Console.ReadLine()!);
            NhanVien[] ds = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhập nhân viên thứ " + (i + 1));
                Console.Write("Mã nhân viên: ");
                ds[i].MaNV = Console.ReadLine()!;
                Console.Write("Họ và tên: ");
                ds[i].HoTen = Console.ReadLine()!;
                Console.Write("Năm sinh: ");
                ds[i].NamSinh = int.Parse(Console.ReadLine()!);
                Console.Write("Phòng ban: ");
                ds[i].PhongBan = Console.ReadLine()!;
                Console.Write("Lương cơ bản: ");
                ds[i].LuongCoBan = int.Parse(Console.ReadLine()!);
                Console.Write("Thưởng: ");
                ds[i].Thuong = int.Parse(Console.ReadLine()!);
                ds[i].ThucLinh = ds[i].LuongCoBan + ds[i].Thuong;
            }
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong = tong + ds[i].ThucLinh;
            }
            Console.WriteLine("\nTổng thực lĩnh: " + tong);
            if (n > 0)
            {
                int min = ds[0].LuongCoBan;

                for (int i = 1; i < n; i++)
                {
                    if (ds[i].LuongCoBan < min)
                    {
                        min = ds[i].LuongCoBan;
                    }
                }
                Console.WriteLine("\nNhân viên có lương cơ bản thấp nhất:");
                for (int i = 0; i < n; i++)
                {
                    if (ds[i].LuongCoBan == min)
                    {
                        Console.WriteLine("Mã nhân viên: " + ds[i].MaNV);
                        Console.WriteLine("Họ và tên: " + ds[i].HoTen);
                        Console.WriteLine("Lương cơ bản: " + ds[i].LuongCoBan);
                    }
                }
            }
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (ds[i].Thuong >= 1200000)
                {
                    dem++;
                }
            }
            Console.WriteLine("\nSố nhân viên có thưởng từ 1.200.000 trở lên: " + dem);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].PhongBan.CompareTo(ds[j].PhongBan) > 0)
                    {
                        NhanVien tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                    else if (ds[i].PhongBan == ds[j].PhongBan)
                    {
                        if (ds[i].MaNV.CompareTo(ds[j].MaNV) < 0)
                        {
                            NhanVien tam = ds[i];
                            ds[i] = ds[j];
                            ds[j] = tam;
                        }
                    }
                }
            }
            Console.WriteLine("\nDanh sách nhân viên sau khi sắp xếp:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mã nhân viên: " + ds[i].MaNV);
                Console.WriteLine("Họ và tên: " + ds[i].HoTen);
                Console.WriteLine("Phòng ban: " + ds[i].PhongBan);
            }
            for (int i = 0; i < n; i++)
            {
                ds[i].LuongCoBan = ds[i].LuongCoBan * 105 / 100;
                ds[i].ThucLinh = ds[i].LuongCoBan + ds[i].Thuong;
            }
            Console.WriteLine("\nDanh sách nhân viên sau khi tăng lương 5%:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mã nhân viên: " + ds[i].MaNV);
                Console.WriteLine("Họ và tên: " + ds[i].HoTen);
                Console.WriteLine("Lương cơ bản: " + ds[i].LuongCoBan);
                Console.WriteLine("Thưởng: " + ds[i].Thuong);
                Console.WriteLine("Thực lĩnh: " + ds[i].ThucLinh);
                Console.WriteLine();
            }
        }
    }
}