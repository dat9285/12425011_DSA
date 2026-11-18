
 # Buoi02_DanhSach

- Họ tên: Nguyễn Xuân Đạt
- MSV: 12425011
- Lớp: 124251

## Bài đã làm

### Chương 4

| Bài | Nội dung |
|---|---|
| 1 | Thao tác chèn phần tử vào mảng tại vị trí k |
| 2 | Quản lý danh sách nhân viên sử dụng struct, tính thực lĩnh, tìm lương min, thống kê thưởng và sắp xếp |
| 3 | Nhập và xử lý ma trận vuông: tính tổng các phần tử, tìm giá trị dương nhỏ nhất, tính tổng đường chéo phụ và kiểm tra đường chéo chính có tăng dần không |
| 4 | Cài đặt danh sách liên kết đơn: thêm cuối, đếm số lượng phần tử bằng x, tìm phần tử dương nhỏ nhất và xóa phần tử có giá trị x đầu tiên |
| 5 | Thao tác trên danh sách liên kết đơn: tìm phần tử lớn nhất, tính tổng các phần tử, đếm số lượng số nguyên tố, thống kê số âm/dương/không, đếm số lần xuất hiện của giá trị x và tìm phần tử dương nhỏ nhất |

### Cài đặt mảng và DSLK

| Bài | Nội dung |
|---|---|
| 7 | Quản lý nhiệt độ: nhập nhiệt độ n ngày, tính nhiệt độ trung bình, tìm ngày có nhiệt độ cao nhất và thấp nhất |
| 8 | Thống kê từ: nhập chuỗi văn bản, tách từ, loại bỏ các ký tự đặc biệt và đếm số lần xuất hiện của mỗi từ |
| 9 | Xử lý số nguyên: nhập mảng số nguyên, kiểm tra và liệt kê các số nguyên tố, số chẵn và số hoàn hảo có trong mảng |
| 10 | Ma trận xoắn ốc: nhập cấp n, tạo và in ma trận vuông theo thứ tự xoắn ốc tăng dần |
| 11 | Ma trận đặc biệt: nhập ma trận vuông và kiểm tra xem có phải là ma trận đơn vị hay ma trận đối xứng không |
| 12 | Game Minesweeper: tạo bảng kích thước m x n, ngẫu nhiên đặt mìn (-1) và tính số mìn xung quanh cho từng ô |
| 13 | Đảo ngược danh sách liên kết đơn: thêm các phần tử vào danh sách, duyệt và đảo ngược liên kết các node không dùng đệ quy |
| 14 | Gộp hai danh sách liên kết đơn đã được sắp xếp thành một danh sách sắp xếp mới bằng phương pháp đệ quy |
| 15 | Phát hiện chu trình trong danh sách liên kết đơn: xây dựng danh sách, tạo chu trình cố ý và kiểm tra bằng thuật toán Floyd (Rùa và Thỏ) |
| 16 | Hệ thống lịch sử duyệt web: mô phỏng tính năng điều hướng Back và Forward bằng danh sách liên kết kép (Doubly Linked List) |
| 17 | Playlist nhạc: quản lý danh sách bài hát với các thao tác duyệt và chuyển bài Next, Previous bằng danh sách liên kết kép |
| 18 | Hệ thống đặt hàng: quản lý và chuyển đổi qua lại giữa các trạng thái đơn hàng bằng danh sách liên kết kép |

## Lệnh chạy

### Chương 4

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
```

### Cài đặt mảng và DSLK

```bash
dotnet run 6
dotnet run 7
dotnet run 8
dotnet run 9
dotnet run 10
dotnet run 11
dotnet run 12
dotnet run 13
dotnet run 14
dotnet run 15
dotnet run 16
dotnet run 17
```

## Kết quả chạy

### Chương 4

### Bài 1

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    class Bai1
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Mảng vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("\nNhập giá trị x: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập vị trí k: ");
            int k = int.Parse(Console.ReadLine()!);
            if (k < 0 || k > n)
            {
                Console.WriteLine("Vị trí k không hợp lệ!");
            }
            else
            {
                int[] b = new int[n + 1];
                for (int i = 0; i < k; i++)
                {
                    b[i] = a[i];
                }
                b[k] = x;

                for (int i = k; i < n; i++)
                {
                    b[i + 1] = a[i];
                }
                Console.WriteLine("Mảng sau khi chèn:");

                for (int i = 0; i < n + 1; i++)
                {
                    Console.Write(b[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 1
Nhập số phần tử n: 4
Nhập a[0]: 10
Nhập a[1]: 20
Nhập a[2]: 30
Nhập a[3]: 40
Mảng vừa nhập:
10 20 30 40
Nhập giá trị x: 99
Nhập vị trí k: 2
Mảng sau khi chèn:
10 20 99 30 40
```

### Bài 2

```csharp
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
```

#### Kết quả

```text
Nhập lựa chọn: 2
Nhập số nhân viên: 1

Nhập nhân viên thứ 1
Mã nhân viên: NV01
Họ và tên: Nguyen Xuan Dat
Năm sinh: 2007
Phòng ban: IT
Lương cơ bản: 10000000
Thưởng: 1000000

Tổng thực lĩnh: 11000000

Nhân viên có lương cơ bản thấp nhất:
Mã nhân viên: NV01
Họ và tên: Nguyen Xuan Dat
Lương cơ bản: 10000000

Số nhân viên có thưởng từ 1.200.000 trở lên: 0

Danh sách nhân viên sau khi sắp xếp:
Mã nhân viên: NV01
Họ và tên: Nguyen Xuan Dat
Phòng ban: IT

Danh sách nhân viên sau khi tăng lương 5%:
Mã nhân viên: NV01
Họ và tên: Nguyen Xuan Dat
Lương cơ bản: 10500000
Thưởng: 1000000
Thực lĩnh: 11500000
```

### Bài 3

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    class Bai3
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập cấp ma trận n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhập a[" + i + "," + j + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
            Console.WriteLine("\nMa trận vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong = tong + a[i, j];
                }
            }
            Console.WriteLine("\nTổng các phần tử của ma trận: " + tong);
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0 && a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            if (min == int.MaxValue)
            {
                Console.WriteLine("Ma trận không có phần tử dương");
            }
            else
            {
                Console.WriteLine("Giá trị dương nhỏ nhất: " + min);
            }
            int tongCheoPhu = 0;
            for (int i = 0; i < n; i++)
            {
                tongCheoPhu = tongCheoPhu + a[i, n - 1 - i];
            }
            Console.WriteLine("Tổng đường chéo phụ: " + tongCheoPhu);
            bool tangDan = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    tangDan = false;
                    break;
                }
            }
            if (tangDan)
            {
                Console.WriteLine("Đường chéo chính tăng dần");
            }
            else
            {
                Console.WriteLine("Đường chéo chính không tăng dần");
            }
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 3
Nhập cấp ma trận n: 2
Nhập a[0,0]: 1
Nhập a[0,1]: 2
Nhập a[1,0]: 3
Nhập a[1,1]: 4

Ma trận vừa nhập:
1       2
3       4

Tổng các phần tử của ma trận: 10
Giá trị dương nhỏ nhất: 1
Tổng đường chéo phụ: 5
Đường chéo chính tăng dần
```

### Bài 4

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node
    {
        public int info;
        public Node? link; 
        public Node(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai4
    {
        static Node? pHead = null;
        static void ThemCuoi(int x)
        {
            Node newNode = new Node(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node q = pHead;
                while (q.link != null)
                {
                    q = q.link;
                }
                q.link = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] duLieuMau = { 5, 2, 8, 2, 10 };
            foreach (var val in duLieuMau)
            {
                ThemCuoi(val);
            }
            int x = 2;
            int d = 0;
            Node? p = pHead;
            while (p != null)
            {
                if (p.info == x)
                {
                    d = d + 1;
                }
                p = p.link;
            }
            Console.WriteLine($"a. Số lượng phần tử có giá trị bằng {x}: {d}");
            int minduong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.info > 0 && p.info < minduong)
                {
                    minduong = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("b. Phần tử dương nhỏ nhất: " + (minduong == int.MaxValue ? "Không có" : minduong.ToString()));
            int xXoa = 2;
            if (pHead != null)
            {
                if (pHead.info == xXoa)
                {
                    pHead = pHead.link;
                }
                else
                {
                    Node? t = null;
                    p = pHead;
                    while (p != null && p.info != xXoa)
                    {
                        t = p;
                        p = p.link;
                    }
                    if (p != null && t != null)
                    {
                        t.link = p.link;
                    }
                }
            }
            Console.Write($"c. Danh sách sau khi xóa phần tử {xXoa} đầu tiên: ");
            p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 4
a. Số lượng phần tử có giá trị bằng 2: 3
b. Phần tử dương nhỏ nhất: 2
c. Danh sách sau khi xóa phần tử 2 đầu tiên: 5 8 10 5 2 8 2 10
```

### Bài 5

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node5
    {
        public int info;
        public Node5? link;
        public Node5(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai5
    {
        static Node5? pHead = null;
        static void ThemCuoi(int x)
        {
            Node5 newNode = new Node5(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node5 q = pHead;
                while (q.link != null)
                {
                    q = q.link;
                }
                q.link = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] duLieuMau = { -5, 7, 10, 0, 4, -2 };
            foreach (var val in duLieuMau)
            {
                ThemCuoi(val);
            }
            Console.Write("Danh sách hiện tại: ");
            Node5? p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
            int max = int.MinValue;
            p = pHead;
            while (p != null)
            {
                if (p.info > max)
                {
                    max = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("a. Phần tử lớn nhất trong danh sách: " + max);
            int tong = 0;
            p = pHead;
            while (p != null)
            {
                tong += p.info;
                p = p.link;
            }
            Console.WriteLine("b. Tổng các phần tử trong danh sách: " + tong);
            int demNT = 0;
            p = pHead;
            while (p != null)
            {
                int val = p.info;
                bool laNT = true;
                if (val < 2) laNT = false;
                else
                {
                    for (int i = 2; i <= Math.Sqrt(val); i++)
                    {
                        if (val % i == 0) { laNT = false; break; }
                    }
                }
                if (laNT) demNT++;
                p = p.link;
            }
            Console.WriteLine("c. Số lượng số nguyên tố trong danh sách: " + demNT);

            int demAm = 0, demKhong = 0, demDuong = 0;
            p = pHead;
            while (p != null)
            {
                if (p.info < 0) demAm++;
                else if (p.info == 0) demKhong++;
                else demDuong++;
                p = p.link;
            }
            Console.WriteLine($"d. Thống kê: Số âm = {demAm}, Số bằng 0 = {demKhong}, Số dương = {demDuong}");

            int x = 7;
            int demX = 0;
            p = pHead;
            while (p != null)
            {
                if (p.info == x) demX++;
                p = p.link;
            }
            Console.WriteLine($"e. Số lượng phần tử có giá trị bằng {x}: {demX}");
            int minDuong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.info > 0 && p.info < minDuong)
                {
                    minDuong = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("f. Phần tử dương nhỏ nhất: " + (minDuong == int.MaxValue ? "Không có" : minDuong.ToString()));
        }
    }
}
```

#### Kết quả

```text
Nhập lựa chọn: 5
Danh sách hiện tại: -5 7 10 0 4 -2
a. Phần tử lớn nhất trong danh sách: 10
b. Tổng các phần tử trong danh sách: 14
c. Số lượng số nguyên tố trong danh sách: 1
d. Thống kê: Số âm = 2, Số bằng 0 = 1, Số dương = 3
e. Số lượng phần tử có giá trị bằng 7: 1
f. Phần tử dương nhỏ nhất: 4
```

---

### Cài đặt mảng và DSLK

### Bài 7

```csharp
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
```

#### Kết quả

```text
Nhập lựa chọn: 6
Nhập số ngày n: 3
Nhập nhiệt độ ngày 1: 30
Nhập nhiệt độ ngày 2: 35
Nhập nhiệt độ ngày 3: 28
Nhiệt độ trung bình tuần: 31.00
Ngày cao nhất: Ngày 2 với 35°C
Ngày thấp nhất: Ngày 3 với 28°C
```

### Bài 8

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai8
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một chuỗi văn bản: ");
            string s = Console.ReadLine()!;
            string[] words = s.ToLower().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Danh sách các từ đã tách:");
            for (int i = 0; i < words.Length; i++)
            {
                int dem = 1;
                bool daDem = false;
                for (int j = 0; j < i; j++)
                {
                    if (words[i] == words[j])
                    {
                        daDem = true;
                        break;
                    }
                }
                if (!daDem)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            dem++;
                        }
                    }
                    Console.WriteLine($"- Từ '{words[i]}': xuất hiện {dem} lần");
                }
            }
        }
    }
}
```

#### Kết quả

```text
Nhập lựa chọn: 7
Nhập một chuỗi văn bản: lap trinh c sharp rat thu vi
Danh sách các từ đã tách:
- Từ 'lap': xuất hiện 1 lần
- Từ 'trinh': xuất hiện 1 lần
- Từ 'c': xuất hiện 1 lần
- Từ 'sharp': xuất hiện 1 lần
- Từ 'rat': xuất hiện 1 lần
- Từ 'thu': xuất hiện 1 lần
- Từ 'vi': xuất hiện 1 lần
```

### Bài 9

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai9
    {
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static bool LaSoHoanHao(int n)
        {
            if (n < 2) return false;
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i) sum += n / i;
                }
            }
            return sum == n;
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử mảng: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            Console.Write("Các số nguyên tố: ");
            foreach (var x in a) if (LaSoNguyenTo(x)) Console.Write(x + " ");
            Console.WriteLine();
            Console.Write("Các số chẵn: ");
            foreach (var x in a) if (x % 2 == 0) Console.Write(x + " ");
            Console.WriteLine();
            Console.Write("Các số hoàn hảo: ");
            foreach (var x in a) if (LaSoHoanHao(x)) Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 8
Nhập số phần tử mảng: 4
a[0] = 2
a[1] = 6
a[2] = 7
a[3] = 28
Các số nguyên tố: 2 7
Các số chẵn: 2 6 28
Các số hoàn hảo: 6 28
```

### Bài 10

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai10
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng/cột n cho ma trận vuông: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] matrix = new int[n, n];
            int top = 0, bottom = n - 1, left = 0, right = n - 1;
            int val = 1;
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++) matrix[top, i] = val++;
                top++;
                for (int i = top; i <= bottom; i++) matrix[i, right] = val++;
                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) matrix[bottom, i] = val++;
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) matrix[i, left] = val++;
                    left++;
                }
            }
            Console.WriteLine("Ma trận xoắn ốc:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 9
Nhập số hàng/cột n cho ma trận vuông: 3
Ma trận xoắn ốc:
   1   2   3
   8   9   4
   7   6   5
```

### Bài 11

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai11
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng/cột n cho ma trận vuông: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[n, n];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
            bool laDonVi = true;
            bool laDoiXung = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && a[i, j] != 1) laDonVi = false;
                    if (i != j && a[i, j] != 0) laDonVi = false;
                    if (a[i, j] != a[j, i]) laDoiXung = false;
                }
            }
            Console.WriteLine("Ma trận đơn vị: " + (laDonVi ? "Đúng" : "Sai"));
            Console.WriteLine("Ma trận đối xứng: " + (laDoiXung ? "Đúng" : "Sai"));
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 10
Nhập số hàng/cột n cho ma trận vuông: 2
Nhập các phần tử của ma trận:
a[0,0] = 1
a[0,1] = 0
a[1,0] = 1
a[1,1] = 0
Ma trận đơn vị: Sai
Ma trận đối xứng: Sai
```

### Bài 12

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai12
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng m: ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] board = new int[m, n];
            Random rand = new Random();
            Console.Write("Nhập số lượng mìn muốn đặt: ");
            int soMin = int.Parse(Console.ReadLine()!);
            int dem = 0;
            while (dem < soMin)
            {
                int r = rand.Next(m);
                int c = rand.Next(n);
                if (board[r, c] != -1)
                {
                    board[r, c] = -1;
                    dem++;
                }
            }
            int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == -1) continue;
                    int count = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ni = i + dr[k];
                        int nj = j + dc[k];
                        if (ni >= 0 && ni < m && nj >= 0 && nj < n && board[ni, nj] == -1)
                        {
                            count++;
                        }
                    }
                    board[i, j] = count;
                }
            }
            Console.WriteLine("Bảng Minesweeper (-1 là mìn, số là số mìn xung quanh):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{board[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 11
Nhập số hàng m: 3
Nhập số cột n: 3
Nhập số lượng mìn muốn đặt: 2
Bảng Minesweeper (-1 là mìn, số là số mìn xung quanh):
   1  -1   1
   2   2   1
  -1   1   0
```

### Bài 13

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node13
    {
        public int info;
        public Node13? link;
        public Node13(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai13
    {
        static Node13? pHead = null;
        static void ThemCuoi(int x)
        {
            Node13 newNode = new Node13(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node13 q = pHead;
                while (q.link != null)
                {
                    q = q.link;
                }
                q.link = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] duLieuMau = { 1, 2, 3, 4, 5 };
            foreach (var val in duLieuMau)
            {
                ThemCuoi(val);
            }
            Console.Write("Danh sách ban đầu: ");
            Node13? p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
            Node13? prev = null;
            Node13? current = pHead;
            Node13? next = null;
            while (current != null)
            {
                next = current.link;
                current.link = prev;
                prev = current;
                current = next;
            }
            pHead = prev;
            Console.Write("Danh sách sau khi đảo ngược: ");
            p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 12
Danh sách ban đầu: 1 2 3 4 5
Danh sách sau khi đảo ngược: 5 4 3 2 1
```

### Bài 14

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node14
    {
        public int info;
        public Node14? link;
        public Node14(int x) { info = x; }
    }
    internal class Bai14
    {
        static Node14? Gop(Node14? a, Node14? b)
        {
            if (a == null) return b;
            if (b == null) return a;
            if (a.info < b.info)
            {
                a.link = Gop(a.link, b);
                return a;
            }
            b.link = Gop(a, b.link);
            return b;
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Node14 l1 = new Node14(1) { link = new Node14(3) { link = new Node14(5) } };
            Node14 l2 = new Node14(2) { link = new Node14(4) { link = new Node14(6) } };
            Node14? kq = Gop(l1, l2);
            Console.Write("Sau khi gộp: ");
            while (kq != null)
            {
                Console.Write(kq.info + " ");
                kq = kq.link;
            }
            Console.WriteLine();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 13
Sau khi gộp: 1 2 3 4 5 6
```

### Bài 15

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class Node15
    {
        public int info;
        public Node15? link;
        public Node15(int x)
        {
            info = x;
            link = null;
        }
    }
    internal class Bai15
    {
        static Node15? pHead = null;
        static void ThemCuoi(int x)
        {
            Node15 newNode = new Node15(x);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node15 q = pHead;
                while (q.link != null)
                {
                    q = q.link;
                }
                q.link = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemCuoi(1);
            ThemCuoi(2);
            ThemCuoi(3);
            ThemCuoi(4);
            Node15? tail = pHead;
            while (tail != null && tail.link != null)
            {
                tail = tail.link;
            }
            if (tail != null)
            {
                tail.link = pHead?.link;
            }
            Node15? slow = pHead;
            Node15? fast = pHead;
            bool coChuTrinh = false;

            while (fast != null && fast.link != null)
            {
                slow = slow!.link;
                fast = fast.link.link;

                if (slow == fast)
                {
                    coChuTrinh = true;
                    break;
                }
            }
            if (coChuTrinh)
            {
                Console.WriteLine("Danh sách liên kết CÓ chứa chu trình.");
            }
            else
            {
                Console.WriteLine("Danh sách liên kết KHÔNG chứa chu trình.");
            }
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 14
Danh sách liên kết CÓ chứa chu trình.
```

### Bài 16

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class WebNode
    {
        public string url;
        public WebNode? prev;
        public WebNode? next;
        public WebNode(string u)
        {
            url = u;
            prev = null;
            next = null;
        }
    }
    internal class Bai16
    {
        static WebNode? pHead = null;
        static WebNode? pTail = null;
        static WebNode? current = null;
        static void ThemTrang(string u)
        {
            WebNode newNode = new WebNode(u);
            if (pHead == null)
            {
                pHead = newNode;
                pTail = newNode;
                current = newNode;
            }
            else
            {
                pTail!.next = newNode;
                newNode.prev = pTail;
                pTail = newNode;
                current = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemTrang("google.com");
            ThemTrang("github.com");
            ThemTrang("stackoverflow.com");
            Console.WriteLine("Đang ở trang hiện tại: " + current?.url);
            if (current?.prev != null)
            {
                current = current.prev;
                Console.WriteLine("Nhấn Back về trang: " + current.url);
            }
            if (current?.next != null)
            {
                current = current.next;
                Console.WriteLine("Nhấn Forward tới trang: " + current.url);
            }
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 15
Đang ở trang hiện tại: stackoverflow.com
Nhấn Back về trang: github.com
Nhấn Forward tới trang: stackoverflow.com
```

### Bài 17

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class SongNode
    {
        public string title;
        public SongNode? prev;
        public SongNode? next;
        public SongNode(string t)
        {
            title = t;
            prev = null;
            next = null;
        }
    }
    internal class Bai17
    {
        static SongNode? pHead = null;
        static SongNode? pTail = null;
        static SongNode? current = null;

        static void ThemBaiHat(string title)
        {
            SongNode newNode = new SongNode(title);
            if (pHead == null)
            {
                pHead = newNode;
                pTail = newNode;
                current = newNode;
            }
            else
            {
                pTail!.next = newNode;
                newNode.prev = pTail;
                pTail = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemBaiHat("Bài hát số 1: Em của ngày hôm qua");
            ThemBaiHat("Bài hát số 2: Nơi này có anh");
            ThemBaiHat("Bài hát số 3: Chạy ngay đi");
            Console.WriteLine(" DANH SÁCH PLAYLIST ");
            SongNode? p = pHead;
            while (p != null)
            {
                Console.WriteLine($"- {p.title}");
                p = p.next;
            }
            Console.WriteLine();
            Console.WriteLine("Đang phát: " + current?.title);
            if (current?.next != null)
            {
                current = current.next;
                Console.WriteLine("Nhấn Next sang: " + current.title);
            }
            if (current?.prev != null)
            {
                current = current.prev;
                Console.WriteLine("Nhấn Previous về: " + current.title);
            }
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 16
 DANH SÁCH PLAYLIST
- Bài hát số 1: Em của ngày hôm qua
- Bài hát số 2: Nơi này có anh
- Bài hát số 3: Chạy ngay đi

Đang phát: Bài hát số 1: Em của ngày hôm qua
Nhấn Next sang: Bài hát số 2: Nơi này có anh
Nhấn Previous về: Bài hát số 1: Em của ngày hôm qua
```

### Bài 18

```csharp
using System;
using System.Text;
namespace Buoi02_DanhSach
{
    public class OrderNode
    {
        public string status;
        public OrderNode? prev;
        public OrderNode? next;
        public OrderNode(string s)
        {
            status = s;
            prev = null;
            next = null;
        }
    }
    internal class Bai18
    {
        static OrderNode? pHead = null;
        static OrderNode? pTail = null;
        static OrderNode? currentOrder = null;
        static void ThemTrangThai(string s)
        {
            OrderNode newNode = new OrderNode(s);
            if (pHead == null)
            {
                pHead = newNode;
                pTail = newNode;
                currentOrder = newNode;
            }
            else
            {
                pTail!.next = newNode;
                newNode.prev = pTail;
                pTail = newNode;
            }
        }
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemTrangThai("Chờ xử lý");
            ThemTrangThai("Đang giao");
            ThemTrangThai("Hoàn thành");
            Console.WriteLine("=== QUẢN LÝ TRẠNG THÁI ĐƠN HÀNG ===");
            Console.WriteLine("Trạng thái hiện tại: " + currentOrder?.status);
            if (currentOrder?.next != null)
            {
                currentOrder = currentOrder.next;
                Console.WriteLine("Chuyển trạng thái tiếp theo: " + currentOrder.status);
            }
            if (currentOrder?.next != null)
            {
                currentOrder = currentOrder.next;
                Console.WriteLine("Chuyển trạng thái tiếp theo: " + currentOrder.status);
            }
            if (currentOrder?.prev != null)
            {
                currentOrder = currentOrder.prev;
                Console.WriteLine("Quay lại trạng thái trước: " + currentOrder.status);
            }
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 17
=== QUẢN LÝ TRẠNG THÁI ĐƠN HÀNG ===
Trạng thái hiện tại: Chờ xử lý
Chuyển trạng thái tiếp theo: Đang giao
Chuyển trạng thái tiếp theo: Hoàn thành
Quay lại trạng thái trước: Đang giao
```








