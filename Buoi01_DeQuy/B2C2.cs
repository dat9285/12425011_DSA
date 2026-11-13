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