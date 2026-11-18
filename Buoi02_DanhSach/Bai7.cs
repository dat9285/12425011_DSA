using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai7
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số ngày n: ");
            int n = int.Parse(Console.ReadLine()!);
            double[] temp = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập nhiệt độ ngày {i + 1}: ");
                temp[i] = double.Parse(Console.ReadLine()!);
            }
            double tong = 0;
            double max = temp[0];
            double min = temp[0];
            int ngayMax = 1, ngayMin = 1;
            for (int i = 0; i < n; i++)
            {
                tong += temp[i];
                if (temp[i] > max)
                {
                    max = temp[i];
                    ngayMax = i + 1;
                }
                if (temp[i] < min)
                {
                    min = temp[i];
                    ngayMin = i + 1;
                }
            }
            double trungBinh = tong / n;
            Console.WriteLine($"Nhiệt độ trung bình tuần: {trungBinh:F2}");
            Console.WriteLine($"Ngày cao nhất: Ngày {ngayMax} với {max}°C");
            Console.WriteLine($"Ngày thấp nhất: Ngày {ngayMin} với {min}°C");
        }
    }
}