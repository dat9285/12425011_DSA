using System;
using System.Collections.Generic;
namespace Buoi03_Stack_Queue
{
    class Bai11TinhBieuThucTrungTo
    {
        public static void Run()
        {
            Console.WriteLine("\nTÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ");
            Console.WriteLine("Chỉ sử dụng số và các phép toán +, -, *, /");
            Console.Write("Nhập biểu thức: ");
            string s = Console.ReadLine()!;
            try
            {
                string hauTo = ChuyenHauTo(s);
                Console.WriteLine("Biểu thức hậu tố: " + hauTo);
                double ketQua = TinhHauTo(hauTo);
                Console.WriteLine("Kết quả: " + ketQua);
            }
            catch
            {
                Console.WriteLine("Biểu thức không hợp lệ");
            }
            Console.WriteLine("Nhấn Enter để quay lại menu");
            Console.ReadLine();
        }
        static int UuTien(string s)
        {
            if (s == "*" || s == "/")
            {
                return 2;
            }
            if (s == "+" || s == "-")
            {
                return 1;
            }
            return 0;
        }
        static string ChuyenHauTo(string s)
        {
            Stack<string> st = new Stack<string>();
            List<string> ketQua = new List<string>();
            int i = 0;
            bool canToanHang = true;
            while (i < s.Length)
            {
                if (s[i] == ' ')
                {
                    i++;
                }
                else if (char.IsDigit(s[i]))
                {
                    if (!canToanHang)
                    {
                        throw new Exception();
                    }
                    string so = "";
                    while (i < s.Length &&
                           (char.IsDigit(s[i]) || s[i] == '.'))
                    {
                        so += s[i];
                        i++;
                    }
                    double kiemTra;
                    if (!double.TryParse(so, out kiemTra))
                    {
                        throw new Exception();
                    }
                    ketQua.Add(so);
                    canToanHang = false;
                }
                else if (s[i] == '(')
                {
                    if (!canToanHang)
                    {
                        throw new Exception();
                    }
                    st.Push("(");
                    i++;
                }
                else if (s[i] == ')')
                {
                    if (canToanHang)
                    {
                        throw new Exception();
                    }
                    while (st.Count > 0 && st.Peek() != "(")
                    {
                        ketQua.Add(st.Pop());
                    }
                    if (st.Count == 0)
                    {
                        throw new Exception();
                    }
                    st.Pop();
                    canToanHang = false;
                    i++;
                }
                else if (s[i] == '+' || s[i] == '-' ||
                         s[i] == '*' || s[i] == '/')
                {
                    if (canToanHang)
                    {
                        throw new Exception();
                    }
                    string toanTu = s[i].ToString();

                    while (st.Count > 0 &&
                           st.Peek() != "(" &&
                           UuTien(st.Peek()) >= UuTien(toanTu))
                    {
                        ketQua.Add(st.Pop());
                    }
                    st.Push(toanTu);
                    canToanHang = true;
                    i++;
                }
                else
                {
                    throw new Exception();
                }
            }
            if (canToanHang)
            {
                throw new Exception();
            }
            while (st.Count > 0)
            {
                if (st.Peek() == "(")
                {
                    throw new Exception();
                }

                ketQua.Add(st.Pop());
            }
            return string.Join(" ", ketQua);
        }
        static double TinhHauTo(string s)
        {
            Stack<double> st = new Stack<double>();
            string[] mang = s.Split(' ');
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
                    st.Push(kq);
                }
            }
            if (st.Count != 1)
            {
                throw new Exception();
            }
            return st.Pop();
        }
    }
}