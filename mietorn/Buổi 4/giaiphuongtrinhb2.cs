using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.Buổi_4
{
    internal class giaiphuongtrinhb2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài tập giải phương trình bậc 2 ax^2+bx+c=0
            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số c: ");
            double c = double.Parse(Console.ReadLine());
            giaipt(a, b, c);
        }
        static void giaipt(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Vô số nghiệm, x tùy ý");
                    }
                    else
                    {
                        Console.WriteLine("Vô nghiệm (vô lý)");
                    }
                }
                else
                {
                    if (c == 0)
                    {
                        Console.WriteLine("x=0");
                    }
                    else
                    {
                        Console.WriteLine($"x= {(-c / b):F2} ");
                    }
                }
                return;
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm thực");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x1=x2= {x:F2}");
                }
                else
                {
                    double sqrtDelta = Math.Sqrt(delta);
                    double x1 = (-b + sqrtDelta) / (2 * a);
                    double x2 = (-b - sqrtDelta) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1= {x1:F2} và x2={x2:F2}");
                }

            }
        }
    }
}

