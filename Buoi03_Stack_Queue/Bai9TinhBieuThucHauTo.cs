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