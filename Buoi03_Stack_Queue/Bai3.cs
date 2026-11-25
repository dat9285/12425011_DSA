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