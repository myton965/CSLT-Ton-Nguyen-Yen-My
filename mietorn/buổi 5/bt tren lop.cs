using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.BTCuuChuong
{
    internal class BTCT
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bangcuuchuong();

            randomgame();

            bai_1();

            bai_2();

            bai_3();

            bai_4_va_5();

            bai_6();

            bai_7();

            bai_8();
        }
        static void bangcuuchuong() //Bài tập bảng cửu chương 15:
        {
            for (int i=2; i<=15; i++) //i chạy từ 2 tới 15
            {
                for (int j=1; j<=10; j++) //i chạy lần lượt từ 1 tới 10
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
                Console.WriteLine();
            }
        }

        static void randomgame() //Bài tập đoán số:
        {
            //1. Máy tính nghĩ ngẫu nhiên 1 số
            //2. Hỏi người dùng đoán số
            //3. Nếu người dùng đoán đúng thì thông báo
               //Nếu người dùng đoán nhỏ/lớn hơn thì thông bái nhỏ/lớn hơn
            //Chơi cho đến khi người dùng không chơi nữa
            //Thống kê số lần thắng thua

            bool continue_play=true;
            int dem_thang = 0, tong_so_van_choi = 0;
            int level = 1;
            int so_lan_doan = 0;
            do
            {
                tong_so_van_choi++;
                //Cho người dùng chọn mức độ:
                Console.Write("Bạn chơi mức độ nào <1- dễ; 2-trung bình; 3-khó>?");
                level = int.Parse(Console.ReadLine());
                if (level == 1)
                    so_lan_doan = 9;
                else if (level == 2)
                    so_lan_doan = 6;
                else
                    so_lan_doan = 4;
                //1. Máy tính nghĩ ngẫu nhiên 1 số
                Random rnd = new Random();
                int com_num = rnd.Next(100) + 1;
                for (int i = 0; i < so_lan_doan; i++)
                {
                    Console.Write("Bạn đoán số mấy?");
                    int user_num = int.Parse(Console.ReadLine());
                    if (user_num == com_num)
                    {
                        dem_thang++;
                        Console.WriteLine("Chúc mừng, bạn là thiên tài");
                        Console.WriteLine($"Bạn đã đoán đúng sau {i + 1} lần chơi");
                        break;
                    }
                    else if (user_num < com_num)
                    {
                        Console.WriteLine("Bạn đoán số nhỏ hơn máy nghĩ");
                    }
                    else
                    {
                        Console.WriteLine("Bạn đoán số lớn hơn máy nghĩ");
                    }
                }
                Console.WriteLine($"Số máy nghĩ là {com_num}");
                Console.Write("Bạn dám chơi nữa không <c/k>?");
                string tl = Console.ReadLine();
                if (tl.ToLower() == "k")
                    continue_play = false;
            } while (continue_play);
            
        }

        static void bai_1()
        {
            //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene
            Console.Write("Input side 1 of triangle: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Input side 2 of triangle: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Input side 3 of triangle: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an Equilateral triangle."); // Tam giác đều
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("This is an Isosceles triangle."); // Tam giác cân
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle."); // Tam giác thường
            }
        } 

        static void bai_2()
        {
            //Write a program to read 10 numbers and find their average and sum
            double sum = 0;
            for (int i=1; i<=10; i++)
            {
                Console.Write($"Nhập số {i}: ");
                sum += double.Parse(Console.ReadLine());
            }

            double tb = sum / 10.0;
            Console.WriteLine($"Tổng là: {sum}");
            Console.WriteLine($"Trung bình là: {tb}");
        }

        static void bai_3()
        {
            //Write a program to display the multiplication table of a given integer.
            Console.Write("Nhập số: ");
            int num= int.Parse(Console.ReadLine());
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine($"{i}*{num}={i * num}");
            }

        }

        static void bai_4_va_5()
        {
            //Write a program to display a pattern like triangles with a number.
            //Hình 1:
            int n = 4;
            for (int i=1; i<=n; i++)
            {
                for (int j=1; j<=i; j++) //Xác định số lượng phần tử trong dòng i
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            //Hình 2:
            int val = 1;
            for (int i=1; i<=n; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write(val + " "); //thế giá trị vào phần tử
                    val++;
                }
                Console.WriteLine();
            }
            //Hình 3:
            int val2 = 1;
            for (int i=1; i<=n; i++)
            {
                Console.Write(new string(' ',n-i)); //in khoảng trắng trước mỗi dòng
                for (int j=1; j<=i;j++)
                {
                    Console.Write(val2 + " " );
                    val2++;
                }
                Console.WriteLine();
            }
        }

        static void bai_6()
        {
            //Hãy viết chương trình hiển thị n số hạng của chuỗi điều hòa và tổng của chúng: 1 + 1/2 + 1/3 + 1/4 + 1/5 + ... + 1/n:
            Console.Write("Nhập n: ");
            int n= int.Parse( Console.ReadLine() );
            double sum = 0.0;
            List<string> terms = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                terms.Add($"1/{i}");
                sum += 1.0 / i;
            }
            Console.WriteLine(string.Join(" + ", terms));
            Console.WriteLine($"Tổng = {sum:F2}");
        }

        static void bai_7()
        {
            //Write a program to find the ‘perfect’ numbers within a given number range:
            Console.Write("Nhập số cần kiểm tra: ");
            int so = int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 1; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                    tong += i;
            }
            if (tong== so)
            {
                Console.WriteLine("số nhập vào là số hoàn hảo");
            }
            else
            {
                Console.WriteLine("Số nhập vào không phải là số hoàn hảo");
            }
        }

        static void bai_8()
        {
            //Write a program to determine whether a given number is prime or not
            Console.Write("Nhập số: ");
            int number= int.Parse( Console.ReadLine());
            if (number<=1)
            {
                Console.WriteLine($"{number} không phải là số nguyên tố");
                return;
            }
            bool dung = true;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    dung = false;
                    break;
                }
            }
            Console.WriteLine($"{number} {(dung ? "là số nguyên tố" : "không phải là số nguyên tố")}");
        }
    }
}
