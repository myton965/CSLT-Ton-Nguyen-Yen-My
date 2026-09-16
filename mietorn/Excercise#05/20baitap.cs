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
            if (ketqua3)
                Console.WriteLine($"{sonhap2} là số nguyên tố.");
            else
                Console.WriteLine($"{sonhap2} không phải là số nguyên tố.");

            //Bài 7:
            Console.Write("Nhập số: ");
            int sonhap3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dãy Fibonacci:");
            InFibonacci(sonhap3);

            //Bài 8: 
            Console.Write("Nhập chuỗi: ");
            string chuoinhap2 = Console.ReadLine();
            int ketqua4 = demnguyenam(chuoinhap2);
            Console.WriteLine($"Tổng số nguyên âm trong chuỗi: {ketqua4}");

            //Bài 9:
            Console.Write("Nhập x: ");
            double x= Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập y: ");
            int y = int.TryParse(Console.ReadLine(), out int tempY) ? tempY : 0; // Nếu không nhập được số, mặc định y = 0
            double ketqua5 = tinhluythua(x, y);
            Console.WriteLine($"Lũy thừa của x,y là: {ketqua5}");

            //Bài 10:
            Console.Write("Nhập chuỗi số: ");
            string chuoinhap3 = Console.ReadLine();
            int[] mangsonguyen = chuoinhap3
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            double ketqua6= tinhtrungbinh(mangsonguyen);
            Console.WriteLine($"Trung bình là: {ketqua6}");

            //Bài 11:

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

        static void InFibonacci(int n) //Bài 7: In ra dãy Fibonacci
        {
            int a = 0, b = 1;
            for (int i=0; i<n; i++)
            {
                Console.Write(a+" ");
                (a, b) = (b, a + b);
            }
            Console.WriteLine();
        }

        static int demnguyenam(string s) //Bài 8: Đếm số nguyên âm trong chuỗi
        {
            char[] nguyenam = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return s.Count(c => nguyenam.Contains(c));
        }

        static double tinhluythua(double x, int y) //Bài 9: Tính lũy thừa
        {
            double result = 1;
            for (int i=0; i<Math.Abs(y); i++)
            {
                result *= x;
            }   
            return y<0 ? 1 / result : result; //Nếu số mũ y là số âm, kết quả sẽ là 1 chia cho result. Nếu y >= 0, giữ nguyên result.
        }

        static double tinhtrungbinh(int[] arr) //Bài 10: Tính điểm trung bình của mảng
        {
            if (arr == null || arr.Length == 0)
                return 0;
            return arr.Average();
        }

    }
}
