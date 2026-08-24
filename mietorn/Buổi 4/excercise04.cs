using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.Buổi_4
{
    internal class excercise04
    {
        static void bai_1()
        {
            Console.Write("Nhập số thứ nhất: ");
            double a= double.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double b= double.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}= {a+b}");
            Console.WriteLine($"{a}-{b}= {a-b}");
            Console.WriteLine($"{a}x{b}= {a*b}");
            Console.WriteLine($"{a}/{b}={(a/b):F2}");
        }

        static void bai_2()
        {
            Console.WriteLine("Bảng giá trị của x = y^2 + 2y + 1: ");
            Console.WriteLine("---------------------");
            Console.WriteLine(" y | x ");
            Console.WriteLine("---------------------");
            for (int y= -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($" {y} | {x} ");
            }
        }

        static void bai_3()
        {
            Console.Write("Nhập quãng đường (m): ");
            float metter= float.Parse(Console.ReadLine());
            Console.Write("Nhập số giờ: ");
            float hours= float.Parse(Console.ReadLine());
            Console.Write("Nhập số phút: ");
            float minutes= float.Parse(Console.ReadLine());
            Console.Write("Nhập số giây: ");
            float seconds= float.Parse(Console.ReadLine());
            //Tổng thời gian quy đổi ra giờ:
            float tongh = hours + (minutes / 60.0f) + (seconds / 3600.0f);
            //vận tốc km/h:
            float km = metter / 1000.0f;
            float vantoc1 = km / tongh;
            //Vận tốc miles per hour:
            float miles = metter / 1609.344f;
            float vantoc2 = miles / tongh;
            Console.WriteLine($"Vận tốc theo km/h: {vantoc1:F2} km/h");
            Console.WriteLine($"Vận tốc theo miles/h: {vantoc2:F2} miles/h");
        }

        static void bai_4()
        {
            Console.WriteLine("Nhập bán kính hình cầu (r): ");
            double r= double.Parse(Console.ReadLine());
            //Diện tích mặt cầu:
            double s = 4 * Math.PI * r * r;
            //Thể tích mặt cầu: 
            double v = (4 / 3) * Math.PI * r * r * r;
            Console.WriteLine($"Diện tích mặt cầu là: {s:F2} ");
            Console.WriteLine($"Thể tích hình cầu là: {v:F2} ");
        }

        static void bai_5()
        {
            Console.WriteLine("Nhập một ký tự: ");
            char kitu = Console.ReadKey().KeyChar;
            Console.WriteLine();
            char lowerch = char.ToLower(kitu);
            if (lowerch == 'a' || lowerch == 'e' || lowerch == 'i' || lowerch == 'o' || lowerch == 'u')
            {
                Console.WriteLine($"{kitu} là một nguyên âm (vowel) ");
            }
            else if (char.IsDigit(kitu))
            {
                Console.WriteLine($"{kitu} là một chữ số (digit) ");
            }
            else
            {
                Console.WriteLine($"{kitu} là một kí hiệu khác (other symbols) ");
            }
        }

       


        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            bai_1();

            bai_2();

            bai_3();

            bai_4();

            bai_5();

        }
    }
}
