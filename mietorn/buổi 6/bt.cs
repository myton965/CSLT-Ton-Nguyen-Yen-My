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
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int s3 = int.Parse(Console.ReadLine());
            int max = TimMax(s1, s2, s3);
            Console.WriteLine($"Số lớn nhất là: {max} ");

            //Mở rộng bài 1: 
            Console.WriteLine("Số lớn nhất của (42) là: " + TimMax2(43));
            Console.WriteLine("Số lớn nhất của (42,66,99) là: " + TimMax2(42, 66, 99));
            Console.WriteLine("Số lớn nhất của (42,66,99,3,4,1,10) là: " + TimMax2(42, 66, 99, 3, 4, 1, 10));

            //Bài 2: 
            Console.Write("Nhập số: ");
            int n = int.Parse(Console.ReadLine());
            try
            {
                long ketqua = Calculate(n);
                Console.WriteLine($"{n}!= {ketqua}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            //Bài 3 và 4.1:
            Console.Write("Nhập số cần kiểm tra: ");
            int so = int.Parse(Console.ReadLine());
            if (IsPrime(so))
                Console.WriteLine($"{so} là số nguyên tố");
            else
                Console.WriteLine($"{so} không phải là số nguyên tố");

            //Bài 5:
            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfectNumber(i))
                    Console.Write($"{i} ");
            }
            Console.WriteLine();

            //Bài 6:
            Console.Write("Nhập chuỗi cần kiểm tra: ");
            string chuoi = Console.ReadLine();
            if (IsPangram(chuoi))
                Console.WriteLine("Đây là pangram");
            else
                Console.WriteLine("Đây không phải là pangram");

        }     
        ///
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
        ///
        public static long Calculate(int n) //Bài 2: Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
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
        ///
        static bool IsPrime(int number) //Bài 3: Prime Number Checker và bài 4.1: all prime numbers that less than a number (enter prompt keyboard).
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        ///
        static void PrintfirstNPrimes (int count) //Bài 4.2: the first N prime numbers
        {
            if (count <= 0) return;
            Console.WriteLine($"first {count} prime: ");
            int found = 0;
            int current = 2;
            while (found < count)
            {
                if (IsPrime(current))
                {
                    Console.Write(current + " ");
                    found++;
                }
                current++;
            }
            Console.WriteLine();
        }
        ///
        static bool IsPerfectNumber (int number) //Bài 5: Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        {
            if (number <= 1) return false;
            int sum = 1;
            int sqrt = (int)Math.Sqrt(number);
            for (int i=2; i<= sqrt; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    int reciprocal = number / i;
                    if (reciprocal != i)
                        sum += reciprocal;
                }
            }
            return sum == number;
        }
        ///
        static bool IsPangram(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;
            HashSet<char> seenLetters = new HashSet<char>();
            foreach (char ch in text.ToLowerInvariant())
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    seenLetters.Add(ch);
                    if (seenLetters.Count == 26)
                        return true;
                }
            }
            return seenLetters.Count == 26;
        }
    }
}
