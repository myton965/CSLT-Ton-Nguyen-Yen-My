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
            Console.OutputEncoding = Encoding.UTF8;

            //Create a random integer values array, then create functions that:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            tao_mang_ngau_nhien(a);
            in_mang(a);


            //1.to calculate the average value of array elements.
            double ketqua1 = tinh_trung_binh(a);
            Console.WriteLine($"Trung bình các phần tử của mảng là: {ketqua1}");

            //2.to test if an array contains a specific value.
            Console.Write("Nhập số cần kiểm tra: ");
            int sonhap1 = int.Parse(Console.ReadLine());
            bool ketqua2 = kiem_tra_ton_tai(a, sonhap1);
            if (ketqua2)
                Console.WriteLine("Số thuộc mảng");
            else
                Console.WriteLine("Số không thuộc mảng");

            //3.to find the index of an array element.
            Console.Write("Nhập số cần tìm vị trí: ");
            int sonhap2 = int.Parse(Console.ReadLine());
            int ketqua3 = tim_vi_tri(a, sonhap2);
            Console.WriteLine($"Vị trí số cần tìm trong mảng là: {ketqua3}");

            //4.to remove a specific element from an array.
            Console.Write("Nhập số cần xóa: ");
            int sonhap3 = int.Parse(Console.ReadLine());
            int[] ketqua4 = XoaPhanTu(a, sonhap3);
            Console.WriteLine("Mảng sau khi xóa phần tử: ");
            in_mang(ketqua4);

            //5.to find the maximum and minimum value of an array.
            Console.WriteLine("Giá trị lớn nhất của mảng: " + TimMax(a));
            Console.WriteLine("Giá trị nhỏ nhất của mảng: " + TimMin(a));

            //6.to reverse an array of integer values.
            int[] ketqua6 = DaoNguocMang(a);
            Console.WriteLine("Mảng sau khi đảo ngược: ");
            in_mang(ketqua6);

            //7.to find duplicate values in an array of values.
            List<int> ketqua7 = TimTrungLap(a);
            if (ketqua7.Count > 0)
            {
                Console.WriteLine("Các phần tử trùng lặp trong mảng là: " + string.Join(", ", ketqua7));
            }
            else
            {
                Console.WriteLine("Không có phần tử trùng lặp trong mảng.");
            }

            //8.to remove duplicate elements from an array.
            int[] ketqua8 = XoaTrungLap(a);
            Console.WriteLine("Mảng sau khi xóa các phần tử trùng lặp: ");
            in_mang(ketqua8);

            //Bài 2: 
            //Create a C# program that
            //-requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
            //- Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
            int[] numbers = new int[10];
            Console.WriteLine("Nhập vào 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Số thứ " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.Write("Mảng sau khi sắp xếp: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\n");
            Console.Write("Nhập một câu bất kỳ: ");
            string cau = Console.ReadLine();
            Console.Write("Nhập từ cần tìm: ");
            string tu = Console.ReadLine();
            // Cắt câu thành các từ dựa vào khoảng trắng
            string[] cacTu = cau.Split(' ');
            bool timThay = false;
            // Tìm kiếm tuyến tính
            for (int i = 0; i < cacTu.Length; i++)
            {
                if (cacTu[i] == tu)
                {
                    timThay = true;
                    break;
                }
            }

            if (timThay == true)
            {
                Console.WriteLine("Từ '" + tu + "' có xuất hiện trong câu.");
            }
            else
            {
                Console.WriteLine("Từ '" + tu + "' không xuất hiện trong câu.");
            }

            //Bài 3: 
            Console.Write("Nhập số hàng (N): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cột (M): ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];
            Random rnd = new Random();

            // 1. Tạo ma trận ngẫu nhiên
            for (int i = 0; i < N; i++)
            {
                for (int c = 0; c < M; c++)
                {
                    matrix[i, c] = rnd.Next(1, 100);
                }
            }

            // 2. In ma trận (dùng \t để tự động tạo khoảng cách canh cột)
            Console.WriteLine("\n--- Ma tran ---");
            for (int i = 0; i < N; i++)
            {
                for (int c = 0; c < M; c++)
                {
                    Console.Write(matrix[i, c] + "\t");
                }
                Console.WriteLine(); // Xuống dòng khi hết 1 hàng
            }

            // 3. In dòng thứ i
            Console.Write("\nNhập chỉ số dòng/cột muốn xem (i): ");
            int r = int.Parse(Console.ReadLine());

            // Kiểm tra xem có vượt quá số hàng không
            if (r < N)
            {
                Console.Write("Dòng " + r + " là: ");
                int minDong = matrix[r, 0]; // Giả sử số nhỏ nhất là số đầu tiên của dòng
                for (int c = 0; c < M; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                    if (matrix[r, c] < minDong) minDong = matrix[r, c];
                }
                Console.WriteLine(" | Số nhỏ nhất của dòng này là: " + minDong);
            }

            // Kiểm tra xem có vượt quá số cột không
            if (r < M)
            {
                Console.Write("Cột " + r + " là: ");
                int minCot = matrix[0, r]; // Giả sử số nhỏ nhất là số đầu tiên của cột
                for (int i = 0; i < N; i++)
                {
                    Console.Write(matrix[i, r] + " ");
                    if (matrix[i, r] < minCot) minCot = matrix[i, r];
                }
                Console.WriteLine(" | Số nhỏ nhất của cột này là: " + minCot);
            }

            // 4. Tìm số lớn nhất ma trận
            int maxMatrix = matrix[0, 0];
            for (int i = 0; i < N; i++)
            {
                for (int c = 0; c < M; c++)
                {
                    if (matrix[i, c] > maxMatrix) maxMatrix = matrix[i, c];
                }
            }
            Console.WriteLine("\nSố lớn nhất trong cả ma trận là: " + maxMatrix);

            // 5. In đường chéo (chỉ áp dụng nếu là ma trận vuông: N = M)
            if (N == M)
            {
                Console.WriteLine("\nĐây là ma trận vuông. Các đường chéo:");

                Console.Write("Đường chéo chính: ");
                for (int d = 0; d < N; d++)
                {
                    Console.Write(matrix[d, d] + " ");
                }
                Console.WriteLine();

                Console.Write("Đường chéo phụ: ");
                for (int d = 0; d < N; d++)
                {
                    // Công thức cột của đường chéo phụ là (Kích thước - 1 - Hàng)
                    Console.Write(matrix[d, N - 1 - d] + " ");
                }
                Console.WriteLine();
            }
        }


        //Create a random integer values array, then create functions that:
        static void tao_mang_ngau_nhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
        }
        static void in_mang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
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
        static bool kiem_tra_ton_tai(int[] a, int b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                    return true;
            }
            return false;
        }

        //3.to find the index of an array element.
        static int tim_vi_tri(int[] a, int b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                    return i + 1;
            }
            return -1;
        }

        //4.to remove a specific element from an array.
        static int[] XoaPhanTu(int[] arr, int target)
        {
            // Bước 1: Đếm xem có bao nhiêu số KHÔNG PHẢI là target
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != target) dem++;
            }

            // Bước 2: Tạo mảng mới với kích thước vừa đếm được
            int[] mangMoi = new int[dem];

            // Bước 3: Chép các số không phải target sang mảng mới
            int viTriMoi = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != target)
                {
                    mangMoi[viTriMoi] = arr[i];
                    viTriMoi++;
                }
            }
            return mangMoi;
        }

        //5.to find the maximum and minimum value of an array.
        static int TimMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }

        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        //6.to reverse an array of integer values.
        static int[] DaoNguocMang(int[] arr)
        {
            int[] mangMoi = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                // Phần tử đầu của mảng cũ sẽ vào phần tử cuối của mảng mới
                mangMoi[i] = arr[arr.Length - 1 - i];
            }
            return mangMoi;
        }

        //7.to find duplicate values in an array of values.
        static List<int> TimTrungLap(int[] arr)
        {
            List<int> trungLap = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !trungLap.Contains(arr[i]))
                    {
                        trungLap.Add(arr[i]);
                    }
                }
            }
            return trungLap;
        }

        //8.to remove duplicate elements from an array.
        static int[] XoaTrungLap(int[] arr)
        {
            List<int> khongTrungLap = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!khongTrungLap.Contains(arr[i]))
                {
                    khongTrungLap.Add(arr[i]);
                }
            }
            return khongTrungLap.ToArray();
        }
    }
}

