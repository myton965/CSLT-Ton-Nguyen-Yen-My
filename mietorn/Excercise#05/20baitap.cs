using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.Excercise_05
{
    internal class _20baitap
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bài 1:
            Console.Write("Nhập số thứ nhất:");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng của {s1} và {s2} là: {tinhtong(s1, s2)}");

            //Bài 2: 
            Console.Write("Nhập một số: ");
            int s3 = int.Parse(Console.ReadLine());
            if (Kiemtrachan(s3))
                Console.WriteLine($"{s3} là số chẵn");
            else
                Console.WriteLine($"{s3} là số lẻ");
            Console.WriteLine();

            //Bài 3: 
            Console.Write("Nhập số thứ nhất: ");
            int s4 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int s5 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int s6 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số lớn nhất trong {s4}, {s5} và {s6} là: {timmax(s4, s5, s6)}");

            //Bài 4:
            Console.Write("Nhập một số: ");
            int sonhap= Convert.ToInt32(Console.ReadLine());
            if (sonhap <0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên không âm.");
            }
            else
            {
                long ketqua = tinhgiaithua(sonhap);
                Console.WriteLine($"{sonhap}! = {ketqua}");
            }
            Console.WriteLine();

            //Bài 5:
            Console.Write("Nhập một chuỗi: ");
            string chuoinhap= Console.ReadLine();
            string ketqua2 = daonguocchuoi(chuoinhap);
            Console.WriteLine($"Chuỗi sau khi đảo ngược: {ketqua2}");

            //Bài 6:
            Console.Write("Nhập một số: ");
            int sonhap2 = Convert.ToInt32(Console.ReadLine());
            bool ketqua3= kiemtranguyento(sonhap2);
            Console.WriteLine($"output: {ketqua3}");

        }

        static int tinhtong (int a, int b) //Bài 1: Tính tổng hai số nguyên
        {
            return a + b;
        }

        static bool Kiemtrachan (int n) //Bài 2: Kiểm tra số chẵn lẻ
        {
            return n % 2 == 0;
        }

        static int timmax(int a, int b, int c) //Bài 3: Tìm số lớn nhất trong 3 số nguyên
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static long tinhgiaithua(int n) //Bài 4: Tính giai thừa của một số nguyên không âm
        {
            long result = 1;
            for (int i=1; i<=n; i++)
            {
                result *= i;
            }
            return result;
        }

        static string daonguocchuoi (string input) //Bài 5: Đảo ngược chuỗi
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static bool kiemtranguyento (int n) //Bài 6: Kiểm tra số nguyên tố
        {
            if (n < 2)
                return false;
            for (int i=2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
