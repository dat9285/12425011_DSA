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