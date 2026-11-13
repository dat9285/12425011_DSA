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