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