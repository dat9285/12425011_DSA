using System;
using System.Text;
namespace Buoi02_DanhSach
{
    internal class Bai8
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một chuỗi văn bản: ");
            string s = Console.ReadLine()!;
            string[] words = s.ToLower().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Danh sách các từ đã tách:");
            for (int i = 0; i < words.Length; i++)
            {
                int dem = 1;
                bool daDem = false;
                for (int j = 0; j < i; j++)
                {
                    if (words[i] == words[j])
                    {
                        daDem = true;
                        break;
                    }
                }
                if (!daDem)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            dem++;
                        }
                    }
                    Console.WriteLine($"- Từ '{words[i]}': xuất hiện {dem} lần");
                }
            }
        }
    }
}