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