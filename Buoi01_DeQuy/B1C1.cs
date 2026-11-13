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