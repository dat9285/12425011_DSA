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