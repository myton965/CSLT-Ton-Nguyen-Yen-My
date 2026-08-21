using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.Excersice_02
{
    internal class _15baitap
    {
        static void bai_1()
        {
            // Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            decimal csc=decimal.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số mới (kWh): ");
            decimal csm=decimal.Parse(Console.ReadLine());
            if (csm < csc)
            {
                Console.WriteLine("Lỗi: Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                return;
            }
            decimal kwh = csm - csc;
            decimal tienDienChuaThue = 0m;
            //Bậc 1: Cho 50 kWh đầu tiên (từ 0 - 50 kWh): 1.806 VNĐ/kWh
            decimal bac1 = Math.Min(kwh, 50m);
            tienDienChuaThue += bac1 * 1806m;
            //Bậc 2: Cho 50 kWh tiếp theo (từ 51 - 100 kWh): 1.866 VNĐ/kWh
            if (kwh > 50m)
            {
                decimal bac2 = Math.Min(kwh - 50m, 50m);
            }

        }




        public static void Main(string[] args)
        {
            //III. DANH SÁCH 15 BÀI TẬP LẬP TRÌNH TÌNH HUỐNG THỰC TẾ
            
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN):
            bai_1();



        }
    }
}
