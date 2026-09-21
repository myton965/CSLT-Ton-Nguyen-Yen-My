using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace mietorn.buổi_7
{
    internal class bt_mang
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            
            //Create a random integer values array, then create functions that:
            Console.Write("Nhập số phần tử của mảng: ");
            int n=int.Parse(Console.ReadLine());
            int[] a =new int[n];
            tao_mang_ngau_nhien(a);
            in_mang(a);



            //1.to calculate the average value of array elements.
            double ketqua1 = tinh_trung_binh(a);
            Console.WriteLine($"Trung bình các phần tử của mảng là: {ketqua1}");

            //2.to test if an array contains a specific value.
            Console.Write("Nhập số cần kiểm tra: ");
            int sonhap1= int.Parse(Console.ReadLine());
            bool ketqua2 = kiem_tra_ton_tai(a, sonhap1);
            if (ketqua2)
                Console.WriteLine("Số thuộc mảng");
            else
                Console.WriteLine("Số không thuộc mảng");

            //3.to find the index of an array element.
            Console.Write("Nhập số cần tìm vị trí: ");
            int sonhap2= int.Parse(Console.ReadLine());
            int ketqua3= tim_vi_tri(a, sonhap2);
            Console.WriteLine($"Vị trí số cần tìm trong mảng là: {ketqua3}");
            //4.to remove a specific element from an array.
            //5.to find the maximum and minimum value of an array.
            //6.to reverse an array of integer values.
            //7.to find duplicate values in an array of values.
            //8.to remove duplicate elements from an array.

            

        }
        //Create a random integer values array, then create functions that:
        static void tao_mang_ngau_nhien(int[] a)
        {
            Random rnd = new Random();
            for (int i=0;i<a.Length;i++)
            {
                a[i] = rnd.Next(0,100);
            }
        }
        static void in_mang(int[] a)
        {
            for (int i= 0; i < a.Length; i++)
            {
                Console.Write(a[i]+ " ");
            }
            Console.WriteLine();

        }
        //1.to calculate the average value of array elements.
        static double tinh_trung_binh(int[] a)
        {
            if (a == null || a.Length == 0)
                return 0;
            return a.Average();
        }
        //2.to test if an array contains a specific value.
        static bool kiem_tra_ton_tai(int[]a, int b)
        {
            for (int i=0; i<a.Length; i++)
            {
                if (a[i] == b)
                    return true;
            }
            return false;
        }
        //3.to find the index of an array element.
        static int tim_vi_tri(int[] a, int b)
        {
            for (int i=0; i<a.Length; i++)
            {
                if (a[i] == b)
                    return i+1;
            }
            return -1;
        }
        //4.to remove a specific element from an array.


    }
}
