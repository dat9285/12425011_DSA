
 # Buoi03_Stack_Queue

- Họ tên: Nguyễn Xuân Đạt
- MSV: 12425011
- Lớp: 124251

## Bài đã làm

### Bài tập cuối chương 5

| Bài | Nội dung |
|---|---|
| 1 | Kiểm tra biểu thức toán học: Sử dụng ngăn xếp (Stack) để kiểm tra tính hợp lệ của biểu thức và các dấu ngoặc |
| 2 | Mô phỏng lịch sử trình duyệt web: sử dụng Stack để thực hiện chức năng truy cập trang mới, quay lại và tiến lên |
| 3 | Mô phỏng Function Call Stack: Sử dụng Stack để mô phỏng quá trình gọi hàm và kết thúc hàm theo nguyên tắc LIFO |
| 4 | Mô phỏng hệ thống in ấn: Sử dụng hàng đợi (Queue) để quản lý tài liệu chờ in theo nguyên tắc FIFO |
| 5 | Mô phỏng đường truyền dữ liệu: Sử dụng Queue để quản lý các gói dữ liệu được gửi và nhận theo đúng thứ tự |
| 6 | Quản lý hàng đợi khách hàng: Sử dụng Queue để thêm khách hàng, phục vụ khách hàng và hiển thị danh sách khách đang chờ |

### Bài tập cuối sách - Bài 3: CÀI ĐẶT NGĂN XẾP VÀ HÀNG ĐỢI

| Bài | Nội dung |
|---|---|
| 4 | Mô phỏng lịch sử trình duyệt web: sử dụng hai ngăn xếp BackStack và ForwardStack để thực hiện chức năng quay lại (Back), tiến lên (Forward) và hiển thị trang hiện tại |
| 5 | Kiểm tra chuỗi ngoặc đúng/sai: sử dụng Stack để kiểm tra các cặp dấu ngoặc mở và đóng trong chuỗi |
| 6 | Mô phỏng hệ thống in: sử dụng Queue để thêm yêu cầu in, xử lý yêu cầu in và hiển thị danh sách yêu cầu đang chờ |
| 7 | Mô phỏng đường truyền dữ liệu: sử dụng Queue để gửi dữ liệu, nhận dữ liệu và hiển thị các gói dữ liệu còn trong hàng đợi |
| 8 | Mô phỏng dịch vụ khách hàng: sử dụng Queue để thêm khách hàng, phục vụ khách hàng theo thứ tự đến trước và hiển thị danh sách khách hàng đang chờ |
| 9 | Tính giá trị biểu thức hậu tố: sử dụng Stack để lưu toán hạng, thực hiện các phép toán và tính kết quả biểu thức hậu tố |
| 10 | Kiểm tra tính hợp lệ của biểu thức trung tố: sử dụng Stack để kiểm tra dấu ngoặc và một số quy tắc cơ bản của biểu thức toán học |
| 11 | Tính giá trị biểu thức trung tố: kiểm tra biểu thức, chuyển biểu thức trung tố sang hậu tố và sử dụng Stack để tính kết quả |

## Lệnh chạy

### Bài tập cuối chương 5

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
dotnet run 6
```

### Bài tập cuối sách - Bài 3: CÀI ĐẶT NGĂN XẾP VÀ HÀNG ĐỢI

```bash
dotnet run 7
dotnet run 8
dotnet run 9
dotnet run 10	
dotnet run 11
dotnet run 12
dotnet run 13
dotnet run 14
```

## Kết quả chạy

### Bài tập cuối chương 5

### Bài 1

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai1
    {
        public static void Run()
        {
            Stack<char> st = new Stack<char>();
            Console.Write("Nhập biểu thức: ");
            string s = Console.ReadLine()!;
            bool dung = true;
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    st.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0)
                    {
                        dung = false;
                        break;
                    }
                    char x = st.Pop();
                    if ((c == ')' && x != '(') ||
                        (c == ']' && x != '[') ||
                        (c == '}' && x != '{'))
                    {
                        dung = false;
                        break;
                    }
                }
            }
            if (st.Count != 0)
                dung = false;

            if (dung)
                Console.WriteLine("Biểu thức hợp lệ");
            else
                Console.WriteLine("Biểu thức không hợp lệ");
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 1
Nhập biểu thức: (a+b)*(c-d)
Biểu thức hợp lệ
```

### Bài 2

```csharp
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
```

#### Kết quả

```text
Nhập lựa chọn: 2

1. Truy cập trang mới
2. Back
3. Forward
0. Quay lại menu
Chọn: 1
Nhập trang web: google.com
Trang hiện tại: google.com

1. Truy cập trang mới
2. Back
3. Forward
0. Quay lại menu
Chọn: 2
Không thể Back
Trang hiện tại: google.com

1. Truy cập trang mới
2. Back
3. Forward
0. Quay lại menu
Chọn: 0
Trang hiện tại: google.com
```

### Bài 3

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai3
    {
        public static void Run()
        {
            Stack<string> st = new Stack<string>();
            Console.WriteLine("Mô Phỏng Function Call Stack");
            st.Push("Main");
            Console.WriteLine("Gọi hàm Main");
            st.Push("HamA");
            Console.WriteLine("Gọi hàm HamA");
            st.Push("HamB");
            Console.WriteLine("Gọi hàm HamB");
            Console.WriteLine("\nCác hàm đang hoạt động:");
            foreach (string x in st)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nQuá trình kết thúc:");
            Console.WriteLine("Kết thúc hàm: " + st.Pop());
            Console.WriteLine("Kết thúc hàm: " + st.Pop());
            Console.WriteLine("Kết thúc hàm: " + st.Pop());
            Console.WriteLine("\nNhấn Enter để quay lại menu");
            Console.ReadLine();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 3
Mô Phỏng Function Call Stack
Gọi hàm Main
Gọi hàm HamA
Gọi hàm HamB

Các hàm đang hoạt động:
HamB
HamA
Main

Quá trình kết thúc:
Kết thúc hàm: HamB
Kết thúc hàm: HamA
Kết thúc hàm: Main

Nhấn Enter để quay lại menu
```

### Bài 4

```csharp
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
```

#### Kết quả 

```text
Nhập lựa chọn: 4

 Hệ Thống In Ấn
1. Thêm tài liệu
2. In tài liệu
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 1
Nhập tên tài liệu: BaiTap.docx
Đã thêm tài liệu

 Hệ Thống In Ấn
1. Thêm tài liệu
2. In tài liệu
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 3
Danh sách tài liệu:
BaiTap.docx

 Hệ Thống In Ấn
1. Thêm tài liệu
2. In tài liệu
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 2
Đang in: BaiTap.docx

 Hệ Thống In Ấn
1. Thêm tài liệu
2. In tài liệu
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 0
```

### Bài 5

```csharp
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
```

#### Kết quả

```text
Nhập lựa chọn: 5

 Mô Phỏng Truyền Dữ Liệu
1. Gửi gói tin
2. Xử lý gói tin
3. Hiển thị gói tin
0. Quay lại menu
Nhập lựa chọn: 1
Nhập gói tin: GoiTin01
Đã gửi gói tin

 Mô Phỏng Truyền Dữ Liệu
1. Gửi gói tin
2. Xử lý gói tin
3. Hiển thị gói tin
0. Quay lại menu
Nhập lựa chọn: 3
Các gói tin đang chờ:
GoiTin01

 Mô Phỏng Truyền Dữ Liệu
1. Gửi gói tin
2. Xử lý gói tin
3. Hiển thị gói tin
0. Quay lại menu
Nhập lựa chọn: 2
Đang xử lý: GoiTin01

 Mô Phỏng Truyền Dữ Liệu
1. Gửi gói tin
2. Xử lý gói tin
3. Hiển thị gói tin
0. Quay lại menu
Nhập lựa chọn: 0
```

### Bài 6

```csharp
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
```

#### Kết quả

```text
Nhập lựa chọn: 6

Quản Lý Khách Hàng
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 1
Nhập tên khách hàng: Nguyen Xuan Dat
Đã thêm khách hàng

Quản Lý Khách Hàng
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 3
Danh sách khách hàng đang chờ:
Nguyen Xuan Dat
Số khách đang chờ: 1

Quản Lý Khách Hàng
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 2
Đang phục vụ: Nguyen Xuan Dat

Quản Lý Khách Hàng
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị hàng đợi
0. Quay lại menu
Nhập lựa chọn: 0
```

---

### Bài tập cuối sách - Bài 3: CÀI ĐẶT NGĂN XẾP VÀ HÀNG ĐỢI

### Bài 4 - Mô phỏng lịch sử trình duyệt web

```csharp
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
```

#### Kết quả

```text
Nhập lựa chọn: 7

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Quay lại menu chính
Nhập lựa chọn: 1
Nhập URL: google.com
Đang truy cập: google.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Quay lại menu chính
Nhập lựa chọn: 1
Nhập URL: youtube.com
Đang truy cập: youtube.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Quay lại menu chính
Nhập lựa chọn: 4
Trang hiện tại: youtube.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Quay lại menu chính
Nhập lựa chọn: 2
Quay lại: google.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Quay lại menu chính
Nhập lựa chọn: 3
Tiến lên: youtube.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Quay lại menu chính
Nhập lựa chọn: 0
```

### Bài 5 - Kiểm tra chuỗi ngoặc đúng/sai

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai5KiemTraChuoiNgoac
    {
        public static void Run()
        {
            Console.WriteLine("\nKIỂM TRA CHUỖI NGOẶC");
            Console.Write("Nhập chuỗi ngoặc: ");
            string s = Console.ReadLine()!;
            Stack<char> st = new Stack<char>();
            bool dung = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    st.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (st.Count == 0)
                    {
                        dung = false;
                        break;
                    }
                    else
                    {
                        st.Pop();
                    }
                }
                else
                {
                    dung = false;
                    break;
                }
            }
            if (st.Count > 0)
            {
                dung = false;
            }
            if (dung)
            {
                Console.WriteLine("Chuỗi ngoặc đúng");
            }
            else
            {
                Console.WriteLine("Chuỗi ngoặc sai");
            }
            Console.WriteLine("Nhấn Enter để quay lại menu");
            Console.ReadLine();
        }
    }
}
```

#### Kết quả

```text
Nhập lựa chọn: 8

KIỂM TRA CHUỖI NGOẶC
Nhập chuỗi ngoặc: ((()))
Chuỗi ngoặc đúng
```

### Bài 6 - Mô phỏng hệ thống in

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai6HeThongInCuoiSach
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG HỆ THỐNG IN");
                Console.WriteLine("1. Thêm yêu cầu in");
                Console.WriteLine("2. Xử lý yêu cầu in");
                Console.WriteLine("3. Hiển thị danh sách chờ");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập tên tài liệu: ");
                        string ten = Console.ReadLine()!;
                        q.Enqueue(ten);
                        Console.WriteLine("Đã thêm yêu cầu in");
                        break;
                    case 2:
                        if (q.Count > 0)
                        {
                            Console.WriteLine("Đang in: " + q.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("Không có yêu cầu in nào");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Danh sách yêu cầu in đang chờ:");
                        foreach (string x in q)
                        {
                            Console.WriteLine(x);
                        }
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
```

#### Kết quả 

```text
Nhập lựa chọn: 9

MÔ PHỎNG HỆ THỐNG IN
1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách chờ
0. Quay lại menu chính
Nhập lựa chọn: 1
Nhập tên tài liệu: DeCuong.pdf
Đã thêm yêu cầu in

MÔ PHỎNG HỆ THỐNG IN
1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách chờ
0. Quay lại menu chính
Nhập lựa chọn: 3
Danh sách yêu cầu in đang chờ:
DeCuong.pdf

MÔ PHỎNG HỆ THỐNG IN
1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách chờ
0. Quay lại menu chính
Nhập lựa chọn: 2
Đang in: DeCuong.pdf

MÔ PHỎNG HỆ THỐNG IN
1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách chờ
0. Quay lại menu chính
Nhập lựa chọn: 0
```

### Bài 7 - Mô phỏng đường truyền dữ liệu

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai7DuongTruyenDuLieu
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU");
                Console.WriteLine("1. Gửi dữ liệu");
                Console.WriteLine("2. Nhận dữ liệu");
                Console.WriteLine("3. Hiển thị dữ liệu đang chờ");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập gói dữ liệu: ");
                        string goiTin = Console.ReadLine()!;
                        q.Enqueue(goiTin);
                        Console.WriteLine("Đã gửi dữ liệu");
                        break;
                    case 2:
                        if (q.Count > 0)
                        {
                            Console.WriteLine("Đã nhận dữ liệu: " + q.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("Không có dữ liệu đang chờ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Các gói dữ liệu đang chờ:");
                        foreach (string x in q)
                        {
                            Console.WriteLine(x);
                        }
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
```

#### Kết quả 

```text
Nhập lựa chọn: 10

MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU
1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu đang chờ
0. Quay lại menu chính
Nhập lựa chọn: 1
Nhập gói dữ liệu: Data01
Đã gửi dữ liệu

MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU
1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu đang chờ
0. Quay lại menu chính
Nhập lựa chọn: 3
Các gói dữ liệu đang chờ:
Data01

MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU
1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu đang chờ
0. Quay lại menu chính
Nhập lựa chọn: 2
Đã nhận dữ liệu: Data01

MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU
1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu đang chờ
0. Quay lại menu chính
Nhập lựa chọn: 0
```

### Bài 8 - Mô phỏng dịch vụ khách hàng

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai8DichVuKhachHang
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            int chon;
            do
            {
                Console.WriteLine("\nMÔ PHỎNG DỊCH VỤ KHÁCH HÀNG");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Phục vụ khách hàng");
                Console.WriteLine("3. Hiển thị danh sách khách hàng chờ");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập tên khách hàng: ");
                        string ten = Console.ReadLine()!;
                        q.Enqueue(ten);
                        Console.WriteLine("Đã thêm khách hàng vào hàng đợi");
                        break;
                    case 2:
                        if (q.Count > 0)
                        {
                            Console.WriteLine("Đang phục vụ khách hàng: " + q.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("Không có khách hàng nào trong hàng đợi");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Danh sách khách hàng đang chờ:");
                        foreach (string x in q)
                        {
                            Console.WriteLine(x);
                        }
                        Console.WriteLine("Số khách đang chờ: " + q.Count);
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
```

#### Kết quả 

```text
Nhập lựa chọn: 11

MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại menu chính
Nhập lựa chọn: 1
Nhập tên khách hàng: An
Đã thêm khách hàng vào hàng đợi

MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại menu chính
Nhập lựa chọn: 3
Danh sách khách hàng đang chờ:
An
Số khách đang chờ: 1

MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại menu chính
Nhập lựa chọn: 2
Đang phục vụ khách hàng: An

MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG
1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại menu chính
Nhập lựa chọn: 0
```

### Bài 9 - Tính giá trị biểu thức hậu tố

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai9TinhBieuThucHauTo
    {
        public static void Run()
        {
            Console.WriteLine("\nTÍNH GIÁ TRỊ BIỂU THỨC HẬU TỐ");
            Console.WriteLine("Ví dụ: 3 4 2 * +");
            Console.Write("Nhập biểu thức: ");
            string s = Console.ReadLine()!;
            string[] mang = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<double> st = new Stack<double>();
            try
            {
                foreach (string x in mang)
                {
                    double so;
                    if (double.TryParse(x, out so))
                    {
                        st.Push(so);
                    }
                    else
                    {
                        if (st.Count < 2)
                        {
                            throw new Exception();
                        }
                        double a = st.Pop();
                        double b = st.Pop();
                        double kq = 0;
                        if (x == "+")
                        {
                            kq = b + a;
                        }
                        else if (x == "-")
                        {
                            kq = b - a;
                        }
                        else if (x == "*")
                        {
                            kq = b * a;
                        }
                        else if (x == "/")
                        {
                            if (a == 0)
                            {
                                throw new Exception();
                            }
                            kq = b / a;
                        }
                        else
                        {
                            throw new Exception();
                        }
                        st.Push(kq);
                    }
                }
                if (st.Count == 1)
                {
                    Console.WriteLine("Kết quả: " + st.Pop());
                }
                else
                {
                    Console.WriteLine("Biểu thức không hợp lệ");
                }
            }
            catch
            {
                Console.WriteLine("Biểu thức không hợp lệ");
            }
            Console.WriteLine("Nhấn Enter để quay lại menu");
            Console.ReadLine();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 12

TÍNH GIÁ TRỊ BIỂU THỨC HẬU TỐ
Ví dụ: 3 4 2 * +
Nhập biểu thức: 3 4 2 * +
Kết quả: 11
```

### Bài 10 - Kiểm tra tính hợp lệ biểu thức trung tố

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai10KiemTraTrungTo
    {
        public static void Run()
        {
            Console.WriteLine("\nKIỂM TRA BIỂU THỨC TRUNG TỐ");
            Console.Write("Nhập biểu thức: ");
            string s = Console.ReadLine()!;
            Stack<char> st = new Stack<char>();
            bool hopLe = true;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    st.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0)
                    {
                        hopLe = false;
                        break;
                    }
                    char mo = st.Pop();
                    if ((c == ')' && mo != '(') ||
                        (c == ']' && mo != '[') ||
                        (c == '}' && mo != '{'))
                    {
                        hopLe = false;
                        break;
                    }
                }
            }
            if (st.Count > 0)
            {
                hopLe = false;
            }
            string bieuThuc = s.Replace(" ", "");
            if (bieuThuc.Length == 0)
            {
                hopLe = false;
            }
            else
            {
                char dauDau = bieuThuc[0];
                char dauCuoi = bieuThuc[bieuThuc.Length - 1];
                if (dauDau == '+' || dauDau == '-' ||
                    dauDau == '*' || dauDau == '/')
                {
                    hopLe = false;
                }
                if (dauCuoi == '+' || dauCuoi == '-' ||
                    dauCuoi == '*' || dauCuoi == '/')
                {
                    hopLe = false;
                }
            }
            for (int i = 0; i < bieuThuc.Length - 1; i++)
            {
                if (LaToanTu(bieuThuc[i]) && LaToanTu(bieuThuc[i + 1]))
                {
                    hopLe = false;
                    break;
                }
            }
            if (hopLe)
            {
                Console.WriteLine("Biểu thức hợp lệ");
            }
            else
            {
                Console.WriteLine("Biểu thức không hợp lệ");
            }

            Console.WriteLine("Nhấn Enter để quay lại menu");
            Console.ReadLine();
        }
        static bool LaToanTu(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 13

KIỂM TRA BIỂU THỨC TRUNG TỐ
Nhập biểu thức: (5+3)*2
Biểu thức hợp lệ
```

### Bài 11 - Tính giá trị biểu thức trung tố

```csharp
using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai11TinhBieuThucTrungTo
    {
        public static void Run()
        {
            Console.WriteLine("\nTÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ");
            Console.WriteLine("Chỉ sử dụng số và các phép toán +, -, *, /");
            Console.Write("Nhập biểu thức: ");
            string s = Console.ReadLine()!;
            try
            {
                string hauTo = ChuyenHauTo(s);
                Console.WriteLine("Biểu thức hậu tố: " + hauTo);
                double ketQua = TinhHauTo(hauTo);
                Console.WriteLine("Kết quả: " + ketQua);
            }
            catch
            {
                Console.WriteLine("Biểu thức không hợp lệ");
            }
            Console.WriteLine("Nhấn Enter để quay lại menu");
            Console.ReadLine();
        }
        static int UuTien(string s)
        {
            if (s == "*" || s == "/")
            {
                return 2;
            }
            if (s == "+" || s == "-")
            {
                return 1;
            }
            return 0;
        }
        static string ChuyenHauTo(string s)
        {
            Stack<string> st = new Stack<string>();
            List<string> ketQua = new List<string>();
            int i = 0;
            bool canToanHang = true;
            while (i < s.Length)
            {
                if (s[i] == ' ')
                {
                    i++;
                }
                else if (char.IsDigit(s[i]))
                {
                    if (!canToanHang)
                    {
                        throw new Exception();
                    }
                    string so = "";
                    while (i < s.Length &&
                           (char.IsDigit(s[i]) || s[i] == '.'))
                    {
                        so += s[i];
                        i++;
                    }
                    double kiemTra;
                    if (!double.TryParse(so, out kiemTra))
                    {
                        throw new Exception();
                    }
                    ketQua.Add(so);
                    canToanHang = false;
                }
                else if (s[i] == '(')
                {
                    if (!canToanHang)
                    {
                        throw new Exception();
                    }
                    st.Push("(");
                    i++;
                }
                else if (s[i] == ')')
                {
                    if (canToanHang)
                    {
                        throw new Exception();
                    }
                    while (st.Count > 0 && st.Peek() != "(")
                    {
                        ketQua.Add(st.Pop());
                    }
                    if (st.Count == 0)
                    {
                        throw new Exception();
                    }
                    st.Pop();
                    canToanHang = false;
                    i++;
                }
                else if (s[i] == '+' || s[i] == '-' ||
                         s[i] == '*' || s[i] == '/')
                {
                    if (canToanHang)
                    {
                        throw new Exception();
                    }
                    string toanTu = s[i].ToString();

                    while (st.Count > 0 &&
                           st.Peek() != "(" &&
                           UuTien(st.Peek()) >= UuTien(toanTu))
                    {
                        ketQua.Add(st.Pop());
                    }
                    st.Push(toanTu);
                    canToanHang = true;
                    i++;
                }
                else
                {
                    throw new Exception();
                }
            }
            if (canToanHang)
            {
                throw new Exception();
            }
            while (st.Count > 0)
            {
                if (st.Peek() == "(")
                {
                    throw new Exception();
                }

                ketQua.Add(st.Pop());
            }
            return string.Join(" ", ketQua);
        }
        static double TinhHauTo(string s)
        {
            Stack<double> st = new Stack<double>();
            string[] mang = s.Split(' ');
            foreach (string x in mang)
            {
                double so;
                if (double.TryParse(x, out so))
                {
                    st.Push(so);
                }
                else
                {
                    if (st.Count < 2)
                    {
                        throw new Exception();
                    }
                    double a = st.Pop();
                    double b = st.Pop();
                    double kq = 0;
                    if (x == "+")
                    {
                        kq = b + a;
                    }
                    else if (x == "-")
                    {
                        kq = b - a;
                    }
                    else if (x == "*")
                    {
                        kq = b * a;
                    }
                    else if (x == "/")
                    {
                        if (a == 0)
                        {
                            throw new Exception();
                        }
                        kq = b / a;
                    }
                    st.Push(kq);
                }
            }
            if (st.Count != 1)
            {
                throw new Exception();
            }
            return st.Pop();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 14

TÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ
Chỉ sử dụng số và các phép toán +, -, *, /
Nhập biểu thức:  5+3
Biểu thức hậu tố: 5 3 +
Kết quả: 8
```







