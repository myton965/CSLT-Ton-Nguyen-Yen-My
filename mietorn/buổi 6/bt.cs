using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mietorn.buổi_6
{
    internal class bt
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bài 1:
            Console.Write("Nhập số thứ nhất: "); 
            int s1= int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int s2= int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int s3= int.Parse(Console.ReadLine());
            int max = TimMax(s1, s2, s3);
            Console.WriteLine($"Số lớn nhất là: {max} ");

            //Mở rộng bài 1: 
            Console.WriteLine("Số lớn nhất của (42) là: "+TimMax2(43));
            Console.WriteLine("Số lớn nhất của (42,66,99) là: "+TimMax2(42,66,99));
            Console.WriteLine("Số lớn nhất của (42,66,99,3,4,1,10) là: "+ TimMax2(42, 66, 99, 3, 4, 1, 10));

            //Bài 2: 
            Console.Write("Nhập số: ");
            int n= int.Parse(Console.ReadLine());
            try
            {
                long ketqua = Calculate(n);
                Console.WriteLine($"{n}!= {ketqua}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Lỗi: "+ ex.Message);
            }
        }
        public static int TimMax(int a,int b,int c) //Bài 1: Write a C# function to find the maximum of three numbers.
        {
            return Math.Max(a, Math.Max(b,c));
        }

        public static int TimMax2(int first, params int[] rest) //mở rộng bài 1: Improve the next version that accept at least 1 parameter.
        {
            int maximum = first;
            foreach (int num in rest)
            {
                if (num > maximum)
                    maximum = num;
            }
            return maximum;
        }

        public static long Calculate(int n) //Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        {
            if (n < 0)
                throw new ArgumentException("Số nhập vào phải là số nguyên âm");
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
