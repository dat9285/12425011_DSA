using System;
using System.Text;
namespace Buoi01_DeQuy
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int chon;
            do
            {
                Console.WriteLine("\nBUỔI 01: ĐỆ QUY");
                Console.WriteLine("1.  Bài 1 - Chương 1");
                Console.WriteLine("2.  Bài 2 - Chương 1");
                Console.WriteLine("3.  Bài 3 - Chương 1");
                Console.WriteLine("4.  Bài 4 - Chương 1");
                Console.WriteLine("5.  Bài 5 - Chương 1");
                Console.WriteLine("6.  Bài 1 - Chương 2");
                Console.WriteLine("7.  Bài 2 - Chương 2");
                Console.WriteLine("8.  Bài 3 - Chương 2");
                Console.WriteLine("9.  Bài 4 - Chương 2");
                Console.WriteLine("10. Bài 5 - Chương 2");
                Console.WriteLine("11. Bài 6 - Chương 2");
                Console.WriteLine("12. Bài 1 - Chương 3");
                Console.WriteLine("13. Bài 2 - Chương 3");
                Console.WriteLine("14. Bài 3 - Chương 3");
                Console.WriteLine("15. Bài 4 - Chương 3");
                Console.WriteLine("16. Bài 5 - Chương 3");
                Console.WriteLine("17. Bài 6 - Chương 3");
                Console.WriteLine("18. Bài 7 - Chương 3");
                Console.WriteLine("19. Bài 8 - Chương 3");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:  B1C1.Run(); break;
                    case 2:  B2C1.Run(); break;
                    case 3:  B3C1.Run(); break;
                    case 4:  B4C1.Run(); break;
                    case 5:  B5C1.Run(); break;
                    case 6:  B1C2.Run(); break;
                    case 7:  B2C2.Run(); break;
                    case 8:  B3C2.Run(); break;
                    case 9:  B4C2.Run(); break;
                    case 10: B5C2.Run(); break;
                    case 11: B6C2.Run(); break;
                    case 12: B1C3.Run(); break;
                    case 13: B2C3.Run(); break;
                    case 14: B3C3.Run(); break;
                    case 15: B4C3.Run(); break;
                    case 16: B5C3.Run(); break;
                    case 17: B6C3.Run(); break;
                    case 18: B7C3.Run(); break;
                    case 19: B8C3.Run(); break;
                    case 0:
                        Console.WriteLine("Thoát chương trình!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 0);
        }
    }
}