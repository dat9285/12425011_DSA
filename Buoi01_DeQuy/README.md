# Buoi01_DeQuy

- Họ tên: Nguyễn Xuân Đạt
- MSV: 12425011
- Lớp: 124251

## Bài đã làm

### Chương 1

| Bài | Nội dung |
|---|---|
| 1 | Sinh mảng 1000 số nguyên ngẫu nhiên trong khoảng 1..999, tìm số lớn nhất và nhỏ nhất |
| 2 | FizzBuzz từ 1 đến 100 |
| 3 | Nhập chuỗi các phần tử cách nhau bởi dấu phẩy, đảo ngược thứ tự các phần tử |
| 4 | Sinh mảng 1000 số ngẫu nhiên trong khoảng 1..10000, in mảng (20 số mỗi dòng), sắp xếp chọn rồi in lại |
| 5 | Nhập n, tính số Fibonacci thứ n bằng vòng lặp |

### Chương 2

| Bài | Nội dung |
|---|---|
| 1 | Tháp Hà Nội bằng đệ quy, đếm số bước và so sánh với 2^n - 1 |
| 2 | Tìm kiếm tuần tự và tìm kiếm nhị phân, so sánh thời gian với n = 10^5, 10^6, 10^7 |
| 3 | Kiểm tra số nguyên tố: giải thuật 1 (duyệt đến n - 1) và giải thuật 2 (duyệt đến căn n), so sánh thời gian |
| 4 | Liệt kê số hoàn hảo nhỏ hơn N: giải thuật 1 (duyệt đến i - 1) và giải thuật 2 (duyệt đến căn i), so sánh thời gian |
| 5 | Số Fibonacci thứ n: đệ quy và vòng lặp, so sánh thời gian |
| 6 | Sắp xếp nổi bọt và sắp xếp chèn trên mảng số thực, so sánh thời gian với n = 1000 đến 20000 |

### Chương 3

| Bài | Nội dung |
|---|---|
| 1 | S(n) = 1 + 2 + 3 + ... + n |
| 2 | S(n) = 1² + 2² + 3² + ... + n² |
| 3 | S(n) = 1 + 1/2 + 1/3 + ... + 1/n |
| 4 | S(x,n) = x^n, hỗ trợ n âm |
| 5 | Tìm ước lẻ lớn nhất của n |
| 6 | Tìm ước chung lớn nhất của a và b (thuật toán Euclid) |
| 7 | Đếm số chữ số của n |
| 8 | S(n) = √(1 + √(2 + √(3 + ... + √n))) |

## Lệnh chạy

### Chương 1

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
```

### Chương 2

```bash
dotnet run 6
dotnet run 7
dotnet run 8
dotnet run 9
dotnet run 10
dotnet run 11
```

### Chương 3

```bash
dotnet run 12
dotnet run 13
dotnet run 14
dotnet run 15
dotnet run 16
dotnet run 17
dotnet run 18
dotnet run 19
```

## Kết quả chạy

### Chương 1

### Bài 1

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B1C1
    {
        public static void Run()
        {
            Random rd = new Random();
            int[] a = new int[1000];
            for (int i = 0; i < a.Length; i++)
                a[i] = rd.Next(0, 10000);

            int max = a[0], min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];

                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("Giá trị lớn nhất: " + max);
            Console.WriteLine("Giá trị nhỏ nhất: " + min);
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 1
Giá trị lớn nhất: 9978
Giá trị nhỏ nhất: 13
```

### Bài 2

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B2C1
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả

```text
Nhập lựa chọn: 2
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
17
Fizz
19
Buzz
Fizz
22
23
Fizz
Buzz
26
Fizz
28
29
FizzBuzz
31
32
Fizz
34
Buzz
Fizz
37
38
Fizz
Buzz
41
Fizz
43
44
FizzBuzz
46
47
Fizz
49
Buzz
Fizz
52
53
Fizz
Buzz
56
Fizz
58
59
FizzBuzz
61
62
Fizz
64
Buzz
Fizz
67
68
Fizz
Buzz
71
Fizz
73
74
FizzBuzz
76
77
Fizz
79
Buzz
Fizz
82
83
Fizz
Buzz
86
Fizz
88
89
FizzBuzz
91
92
Fizz
94
Buzz
Fizz
97
98
Fizz
Buzz
```

### Bài 3

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B3C1
    {
        public static void Run()
        {
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine()!;
            string daoNguoc = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                daoNguoc += s[i];
            }
            Console.WriteLine("Chuỗi đảo ngược: " + daoNguoc);
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 3
Nhập chuỗi: 234
Chuỗi đảo ngược: 432
```

### Bài 4

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B4C1
    {
        public static void Run()
        {
            int[] a = new int[1000];
            Random rd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                a[i] = rd.Next(0, 10000);
            }
            Console.WriteLine("Mảng ban đầu: ");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(a[i] + " ");
            }
            for (int i = 0; i < 999; i++)
            {
                for (int j = 0; j < 999 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nMảng sau khi sắp xếp tăng dần: ");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 4
Mảng ban đầu:
9431 8361 81 252 7419 8078 7043 8834 4352 5485 1829 1589 6242 2751 2902 9516 3848 3987 8083 1867 8415 2260 7165 6231 7261 7319 2711 8654 1513 7105 3111 1851 2580 951 494 7249 7968 8543 5145 1749 9419 6443 7916 388 8413 6086 8584 6606 17 1449 5586 257 1703 2968 3008 976 8001 1126 9466 3039 4393 6192 9537 4396 8085 7891 4157 4555 3916 878 3546 7399 7826 5930 1346 8866 1941 1147 9787 3135 5117 943 6360 9476 3055 3473 4732 4516 8116 1679 7289 7927 2443 501 5895 7786 4334 5161 2304 2779 6173 2700 2170 2490 2940 9619 9280 6487 2527 8101 8528 9942 368 8511 9682 6027 5385 472 5978 4870 8445 5048 3715 9041 797 9096 419 6711 4489 8100 4700 7630 8237 4153 8975 7537 2869 5854 1112 2505 3658 1680 9473 6347 8510 2100 7273 3029 4890 9755 9059 9477 1777 6455 3132 2028 3484 9735 5102 8950 1493 9022 7446 7016 4960 3396 1268 9479 3216 3273 2525 1667 2614 9139 7550 7886 8898 9566 3734 8315 4474 5709 5528 6546 5296 2146 3610 1937 4201 832 7423 5657 769 3247 6549 4727 7921 8170 7029 1544 843 9882 5309 9818 2660 9880 3700 2076 8743 9001 6407 3943 7044 8464 3156 5102 1059 4049 3045 333 5421 7897 5999 1160 9430 5167 6201 8450 9316 9777 9938 3252 4524 4439 7844 2023 9145 1222 5523 7699 8576 2906 6873 9468 3288 761 5475 9145 683 2545 9143 3237 1564 4628 7841 2391 6684 1539 4644 4995 963 3324 2758 1773 7899 6818 2154 9993 7378 2440 3009 7959 6233 239 8134 8035 4261 8695 2932 327 9671 8185 4686 434 748 7427 7093 4408 7626 5807 8928 7401 8132 6546 2319 3742 6588 1109 6896 7028 4629 5015 5669 1307 468 6347 7136 7012 4661 2011 595 3761 1502 1616 1993 9664 154 2701 6377 314 3228 226 9701 315 5297 5622 687 7894 7009 3471 738 8685 7490 3046 8847 9960 894 6622 2204 2690 4284 6950 6275 9300 6348 297 1724 634 5089 7728 7237 3163 6975 5479 2179 5166 8429 5068 6049 620 264 3327 4415 9587 8437 1357 1932 9002 5139 3642 7292 7108 3701 8082 8374 2696 5670 4592 5848 5670 7945 8519 1072 7462 2137 2477 8353 376 3380 9361 3191 2853 5532 6007 5929 9357 9328 1252 7103 1260 6220 3391 7385 8084 4258 3200 3108 3017 1120 9580 9334 7584 9726 48 1547 9451 3069 1430 6075 9634 1615 3263 7105 5047 4259 7728 3161 7682 6218 931 883 6128 2376 833 7394 8200 4888 8004 9063 6956 6732 5157 5097 4593 2908 1982 7408 6833 3233 7621 2533 1258 1910 8730 2541 4219 4280 4043 5376 3301 6763 8372 7755 4868 5121 204 1926 6376 6 84 6717 2881 3309 1089 4279 1012 1075 2748 3637 9984 4698 8228 8926 7518 3443 3560 9593 1657 9876 7799 2957 5102 569 1165 9618 3330 2320 4857 3002 4030 9621 6292 6447 3125 3955 8186 4943 1656 9036 6415 8110 5717 1572 300 4471 3312 9738 2403 7033 2935 710 5142 2511 2845 7622 7198 5372 7997 5998 649 7672 1993 7468 4711 6863 2498 7654 7907 4415 5112 18 1251 3220 9384 7307 7478 3214 5369 3207 5826 9279 7100 5091 9974 6067 5644 4538 6629 9861 2667 3430 3635 7759 3328 3819 6621 565 7482 4286 146 2324 7179 1701 435 5785 4498 9815 8968 9563 8101 7470 5425 8579 229 7548 7773 811 6806 4746 1797 8208 4306 6218 2165 9378 2828 5736 9353 1381 4522 6107 8935 3345 7100 9947 5442 3710 1055 1137 8850 9594 8177 3018 8272 3931 6963 8892 7146 5564 3630 2748 9658 9164 9054 9975 1729 4816 1429 3731 9192 2561 7310 9799 6293 1097 6761 6498 9049 695 6409 1008 1914 776 5122 7098 4924 1428 8157 7742 607 1564 3817 7968 9065 8445 1826 8648 2637 5 9179 8362 3606 6808 1046 6849 4583 442 4258 7364 36 2287 9423 9164 4906 799 9038 7792 7039 6282 8572 7812 4950 5316 2408 7628 7 5896 9337 6870 107 9484 3021 5851 9901 1478 9924 8188 1559 5227 4079 9857 9699 4166 3268 6556 9155 7517 575 7424 627 4700 5147 784 3885 2805 9872 9094 6211 2595 1533 1628 1130 559 2410 372 6192 5760 3977 3137 7007 8445 9438 8730 2338 430 8029 9537 1599 8646 7022 1752 9473 1004 9135 4043 6359 3721 4244 8984 1495 1595 346 3502 1120 8652 9211 8881 5775 4244 6399 3413 1270 6023 7740 5522 6142 2463 9286 5929 4720 8910 7310 4860 1656 9289 5295 5327 2773 9063 9456 3701 8842 2902 3228 407 4100 3414 5641 8750 7412 4779 2811 2347 9277 2726 6750 4559 1000 6307 5157 2266 7362 4078 5444 6199 2154 5050 8244 1397 7893 3220 7632 1556 6734 2768 7794 1111 1930 8462 3284 9 7630 9580 4910 68 7163 7812 3044 3841 3358 7595 9151 70 5735 1782 2266 312 546 599 9171 4298 8989 9354 5439 1509 534 8079 8660 9295 8716 6853 131 9810 6185 8491 6418 7572 6425 6624 2505 6463 5910 661 3143 6228 1366 7144 7654 3599 1611 1084 2120 2243 4384 9036 6352 3708 9271 666 4869 3016 9714 4470 8423 1300 6754 4468 9281 8673 3958 8503 5688 7 8646 1478 751 8366 3844 7606 8123 4230 3941 4834 4402 1181 3568 2040 2587 6384 805 2038 3137 4687 5371 8824 2756 4599 3383 2294 2753 6215 7000 6310 8158 772 4366 5117 9202 4191 8742 1726 7786 5796 7040 6881 7824 5394 800 1580 653 4483 1218 8422 8262 2722 144 1482 739 1717 5826 3973 2449 2067 4876 2061 811 4699 1525 3818 5023 2277 707 7716 3215 4215 7613 3244 846 5316 3201 785 3044 3977 4799 8731 2805 965 2911 683 2588 4654 8429 9581 9530 8043 3333 7299 2106 888 60 3562 8497 5855 6605 5647 6809 2630 5073 6278 4070
Mảng sau khi sắp xếp tăng dần:
5 6 7 7 9 17 18 36 48 60 68 70 81 84 107 131 144 146 154 204 226 229 239 252 257 264 297 300 312 314 315 327 333 346 368 372 376 388 407 419 430 434 435 442 468 472 494 501 534 546 559 565 569 575 595 599 607 620 627 634 649 653 661 666 683 683 687 695 707 710 738 739 748 751 761 769 772 776 784 785 797 799 800 805 811 811 832 833 843 846 878 883 888 894 931 943 951 963 965 976 1000 1004 1008 1012 1046 1055 1059 1072 1075 1084 1089 1097 1109 1111 1112 1120 1120 1126 1130 1137 1147 1160 1165 1181 1218 1222 1251 1252 1258 1260 1268 1270 1300 1307 1346 1357 1366 1381 1397 1428 1429 1430 1449 1478 1478 1482 1493 1495 1502 1509 1513 1525 1533 1539 1544 1547 1556 1559 1564 1564 1572 1580 1589 1595 1599 1611 1615 1616 1628 1656 1656 1657 1667 1679 1680 1701 1703 1717 1724 1726 1729 1749 1752 1773 1777 1782 1797 1826 1829 1851 1867 1910 1914 1926 1930 1932 1937 1941 1982 1993 1993 2011 2023 2028 2038 2040 2061 2067 2076 2100 2106 2120 2137 2146 2154 2154 2165 2170 2179 2204 2243 2260 2266 2266 2277 2287 2294 2304 2319 2320 2324 2338 2347 2376 2391 2403 2408 2410 2440 2443 2449 2463 2477 2490 2498 2505 2505 2511 2525 2527 2533 2541 2545 2561 2580 2587 2588 2595 2614 2630 2637 2660 2667 2690 2696 2700 2701 2711 2722 2726 2748 2748 2751 2753 2756 2758 2768 2773 2779 2805 2805 2811 2828 2845 2853 2869 2881 2902 2902 2906 2908 2911 2932 2935 2940 2957 2968 3002 3008 3009 3016 3017 3018 3021 3029 3039 3044 3044 3045 3046 3055 3069 3108 3111 3125 3132 3135 3137 3137 3143 3156 3161 3163 3191 3200 3201 3207 3214 3215 3216 3220 3220 3228 3228 3233 3237 3244 3247 3252 3263 3268 3273 3284 3288 3301 3309 3312 3324 3327 3328 3330 3333 3345 3358 3380 3383 3391 3396 3413 3414 3430 3443 3471 3473 3484 3502 3546 3560 3562 3568 3599 3606 3610 3630 3635 3637 3642 3658 3700 3701 3701 3708 3710 3715 3721 3731 3734 3742 3761 3817 3818 3819 3841 3844 3848 3885 3916 3931 3941 3943 3955 3958 3973 3977 3977 3987 4030 4043 4043 4049 4070 4078 4079 4100 4153 4157 4166 4191 4201 4215 4219 4230 4244 4244 4258 4258 4259 4261 4279 4280 4284 4286 4298 4306 4334 4352 4366 4384 4393 4396 4402 4408 4415 4415 4439 4468 4470 4471 4474 4483 4489 4498 4516 4522 4524 4538 4555 4559 4583 4592 4593 4599 4628 4629 4644 4654 4661 4686 4687 4698 4699 4700 4700 4711 4720 4727 4732 4746 4779 4799 4816 4834 4857 4860 4868 4869 4870 4876 4888 4890 4906 4910 4924 4943 4950 4960 4995 5015 5023 5047 5048 5050 5068 5073 5089 5091 5097 5102 5102 5102 5112 5117 5117 5121 5122 5139 5142 5145 5147 5157 5157 5161 5166 5167 5227 5295 5296 5297 5309 5316 5316 5327 5369 5371 5372 5376 5385 5394 5421 5425 5439 5442 5444 5475 5479 5485 5522 5523 5528 5532 5564 5586 5622 5641 5644 5647 5657 5669 5670 5670 5688 5709 5717 5735 5736 5760 5775 5785 5796 5807 5826 5826 5848 5851 5854 5855 5895 5896 5910 5929 5929 5930 5978 5998 5999 6007 6023 6027 6049 6067 6075 6086 6107 6128 6142 6173 6185 6192 6192 6199 6201 6211 6215 6218 6218 6220 6228 6231 6233 6242 6275 6278 6282 6292 6293 6307 6310 6347 6347 6348 6352 6359 6360 6376 6377 6384 6399 6407 6409 6415 6418 6425 6443 6447 6455 6463 6487 6498 6546 6546 6549 6556 6588 6605 6606 6621 6622 6624 6629 6684 6711 6717 6732 6734 6750 6754 6761 6763 6806 6808 6809 6818 6833 6849 6853 6863 6870 6873 6881 6896 6950 6956 6963 6975 7000 7007 7009 7012 7016 7022 7028 7029 7033 7039 7040 7043 7044 7093 7098 7100 7100 7103 7105 7105 7108 7136 7144 7146 7163 7165 7179 7198 7237 7249 7261 7273 7289 7292 7299 7307 7310 7310 7319 7362 7364 7378 7385 7394 7399 7401 7408 7412 7419 7423 7424 7427 7446 7462 7468 7470 7478 7482 7490 7517 7518 7537 7548 7550 7572 7584 7595 7606 7613 7621 7622 7626 7628 7630 7630 7632 7654 7654 7672 7682 7699 7716 7728 7728 7740 7742 7755 7759 7773 7786 7786 7792 7794 7799 7812 7812 7824 7826 7841 7844 7886 7891 7893 7894 7897 7899 7907 7916 7921 7927 7945 7959 7968 7968 7997 8001 8004 8029 8035 8043 8078 8079 8082 8083 8084 8085 8100 8101 8101 8110 8116 8123 8132 8134 8157 8158 8170 8177 8185 8186 8188 8200 8208 8228 8237 8244 8262 8272 8315 8353 8361 8362 8366 8372 8374 8413 8415 8422 8423 8429 8429 8437 8445 8445 8445 8450 8462 8464 8491 8497 8503 8510 8511 8519 8528 8543 8572 8576 8579 8584 8646 8646 8648 8652 8654 8660 8673 8685 8695 8716 8730 8730 8731 8742 8743 8750 8824 8834 8842 8847 8850 8866 8881 8892 8898 8910 8926 8928 8935 8950 8968 8975 8984 8989 9001 9002 9022 9036 9036 9038 9041 9049 9054 9059 9063 9063 9065 9094 9096 9135 9139 9143 9145 9145 9151 9155 9164 9164 9171 9179 9192 9202 9211 9271 9277 9279 9280 9281 9286 9289 9295 9300 9316 9328 9334 9337 9353 9354 9357 9361 9378 9384 9419 9423 9430 9431 9438 9451 9456 9466 9468 9473 9473 9476 9477 9479 9484 9516 9530 9537 9537 9563 9566 9580 9580 9581 9587 9593 9594 9618 9619 9621 9634 9658 9664 9671 9682 9699 9701 9714 9726 9735 9738 9755 9777 9787 9799 9810 9815 9818 9857 9861 9872 9876 9880 9882 9901 9924 9938 9942 9947 9960 9974 9975 9984 9993
```

### Bài 5

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B5C1
    {
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n < 0 || n > 92)
            {
                Console.WriteLine("Vui lòng nhập n từ 0 đến 92!");
            }
            else
            {
                long a = 0;
                long b = 1;
                for (int i = 2; i <= n; i++)
                {
                    long c = a + b;
                    a = b;
                    b = c;
                }
                if (n == 0)
                {
                    Console.WriteLine("Số Fibonacci thứ " + n + " là: 0");
                }
                else
                {
                    Console.WriteLine("Số Fibonacci thứ " + n + " là: " + b);
                }
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả

```text
Nhập lựa chọn: 5
Nhập n: 10
Số Fibonacci thứ 10 là: 55
```

---

### Chương 2

### Bài 1

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B1C2
    {
        public static void ThapHaNoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine("Chuyển đĩa 1 từ cọc " + A + " sang cọc " + C);
                return;
            }
            ThapHaNoi(n - 1, A, C, B);
            Console.WriteLine("Chuyển đĩa " + n + " từ cọc " + A + " sang cọc " + C);
            ThapHaNoi(n - 1, B, A, C);
        }
        public static void Run()
        {
            Console.Write("Nhập số đĩa n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập n > 0!");
            }
            else
            {
                Console.WriteLine("\nCác bước chuyển đĩa:");
                ThapHaNoi(n, 'A', 'B', 'C');
                int soLan = (int)Math.Pow(2, n) - 1;
                Console.WriteLine("\nTổng số lần chuyển đĩa = " + soLan);
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả

```text
Nhập lựa chọn: 6
Nhập số đĩa n: 3

Các bước chuyển đĩa:
Chuyển đĩa 1 từ cọc A sang cọc C
Chuyển đĩa 2 từ cọc A sang cọc B
Chuyển đĩa 1 từ cọc C sang cọc B
Chuyển đĩa 3 từ cọc A sang cọc C
Chuyển đĩa 1 từ cọc B sang cọc A
Chuyển đĩa 2 từ cọc B sang cọc C
Chuyển đĩa 1 từ cọc A sang cọc C

Tổng số lần chuyển đĩa = 7
```

### Bài 2

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B2C2
    {
        public static int BinarySearch(int[] a, int x)
        {
            int left = 0;
            int right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (a[mid] == x)
                    return mid;
                if (a[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
        public static void Run()
        {
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("n phải lớn hơn 0!");
                Console.ReadKey();
                return;
            }
            int[] a = new int[n];
            Console.WriteLine("Nhập mảng tăng dần:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            Console.Write("Nhập số cần tìm x: ");
            int x = int.Parse(Console.ReadLine()!);
            int kq = BinarySearch(a, x);
            if (kq == -1)
                Console.WriteLine("Không tìm thấy!");
            else
                Console.WriteLine("Tìm thấy tại vị trí: " + kq);
            Console.ReadKey();
        }
    }
}
```

#### Kết quả

```text
Nhập lựa chọn: 7
Nhập số phần tử n: 5
Nhập mảng tăng dần:
a[0] = 1
a[1] = 3
a[2] = 5
a[3] = 7
a[4] = 9
Nhập số cần tìm x: 7
Tìm thấy tại vị trí: 3
```

### Bài 3

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B3C2
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (KiemTraNguyenTo(n))
                Console.WriteLine(n + " là số nguyên tố");
            else
                Console.WriteLine(n + " không phải số nguyên tố");
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 8
Nhập n: 7
7 là số nguyên tố
```

### Bài 4

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B4C2
    {
        public static bool LaSoHoanHao(int n)
        {
            if (n <= 1)
                return false;
            int tong = 1;
            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                    int uoc = n / i;

                    if (uoc != i)
                        tong += uoc;
                }
            }
            return tong == n;
        }
        public static void Run()
        {
            Console.Write("Nhập N: ");
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Các số hoàn hảo nhỏ hơn N:");
            for (int i = 2; i < N; i++)
            {
                if (LaSoHoanHao(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 9
Nhập N: 30
Các số hoàn hảo nhỏ hơn N:
6 28
```

### Bài 5

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B5C2
    {
        public static long Fibonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n < 0 || n > 40)
            {
                Console.WriteLine("Nhập n từ 0 đến 40!");
            }
            else
            {
                Console.WriteLine("Fibonacci thứ " + n + " = " + Fibonacci(n));
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 10
Nhập n: 10
Fibonacci thứ 10 = 55
```

### Bài 6

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B6C2
    {
        static void BubbleSort(double[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        double temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        public static void Run()
        {
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("n phải lớn hơn 0!");
                Console.ReadKey();
                return;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập a[" + i + "]: ");
                a[i] = double.Parse(Console.ReadLine()!);
            }
            BubbleSort(a);
            Console.WriteLine("Mảng sau khi sắp xếp:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 11
Nhập số phần tử n: 5
Nhập a[0]: 5
Nhập a[1]: 2
Nhập a[2]: 8
Nhập a[3]: 1
Nhập a[4]: 3
Mảng sau khi sắp xếp:
1 2 3 5 8
```

---

### Chương 3

### Bài 1

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B1C3
    {
        public static int Tong(int n)
        {
            if (n == 1)
                return 1;
            return Tong(n - 1) + n;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Tổng S(n) = " + Tong(n));
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 12
Nhập n: 5
Tổng S(n) = 15
```

### Bài 2

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B2C3
    {
        public static int TongBinhPhuong(int n)
        {
            if (n == 1)
                return 1;

            return TongBinhPhuong(n - 1) + n * n;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Tổng bình phương = " + TongBinhPhuong(n));
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 13
Nhập n: 5
Tổng bình phương = 55
```

### Bài 3

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B3C3
    {
        public static double TongPhanSo(int n)
        {
            if (n == 1)
                return 1;

            return TongPhanSo(n - 1) + 1.0 / n;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Tổng phân số = " + TongPhanSo(n));
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 14
Nhập n: 5
Tổng phân số = 2.283333333333333
```

### Bài 4

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B4C3
    {
        public static double LuyThua(double x, int n)
        {
            if (n == 0)
                return 1;
            if (n < 0)
                return 1.0 / LuyThua(x, -n);
            return LuyThua(x, n - 1) * x;
        }
        public static void Run()
        {
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine()!);
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (x == 0 && n <= 0)
            {
                Console.WriteLine("Không hợp lệ!");
            }
            else if (n == int.MinValue)
            {
                Console.WriteLine("Số mũ không hợp lệ!");
            }
            else
            {
                Console.WriteLine("Kết quả = " + LuyThua(x, n));
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 15
Nhập x: 2
Nhập n: 3
Kết quả = 8
```

### Bài 5

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B5C3
    {
        public static int UocLeMax(int n)
        {
            if (n % 2 != 0)
                return n;
            return UocLeMax(n / 2);
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập n > 0!");
            }
            else
            {
                Console.WriteLine("Ước lẻ lớn nhất = " + UocLeMax(n));
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 16
Nhập n: 40
Ước lẻ lớn nhất = 5
```

### Bài 6

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B6C3
    {
        public static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        public static void Run()
        {
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine()!);
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Vui lòng nhập hai số dương!");
            }
            else
            {
                Console.WriteLine("UCLN = " + UCLN(a, b));
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 17
Nhập a: 24
Nhập b: 18
UCLN = 6
```

### Bài 7

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B7C3
    {
        static int SoChuSo(int n)
        {
            if (n == 0)
                return 0;

            return SoChuSo(n / 10) + 1;
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập n > 0!");
            }
            else
            {
                Console.WriteLine("Số chữ số = " + SoChuSo(n));
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 18
Nhập n: 12345
Số chữ số = 5
```

### Bài 8

```csharp
using System;
namespace Buoi01_DeQuy
{
    class B8C3
    {
        static double Can(int i, int n)
        {
            if (i == n)
                return Math.Sqrt(n);
            return Math.Sqrt(i + Can(i + 1, n));
        }
        static double TongCan(int n)
        {
            return Can(1, n);
        }
        public static void Run()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập n > 0!");
            }
            else
            {
                Console.WriteLine("Kết quả = " + TongCan(n));
            }
            Console.ReadKey();
        }
    }
}
```

#### Kết quả 

```text
Nhập lựa chọn: 19
Nhập n: 4
Kết quả = 1.7487627132551438
```







