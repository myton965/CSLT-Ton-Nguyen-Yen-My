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
                tienDienChuaThue += bac2 * 1866m;
            }
            //Bậc 3: Cho 100 kWh tiếp theo (từ 101 - 200 kWh): 2.167 VNĐ/kWh
            if (kwh > 100m)
            {
                decimal bac3 = Math.Min(kwh - 100m, 100m);
                tienDienChuaThue += bac3 * 2167m;
            }
            //Bậc 4: Cho 100 kWh tiếp theo (từ 201 - 300 kWh): 2.729 VNĐ/kWh
            if (kwh > 200m)
            {
                decimal bac4 = Math.Min(kwh - 200m, 100m);
                tienDienChuaThue += bac4 * 2729m;
            }
            //Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3050 VNĐ/kWh
            if (kwh > 300m)
            {
                decimal bac5 = kwh-300m;
                tienDienChuaThue += bac5 * 3050m;
            }
            //Cộng thêm 8% Thuế Giá trị gia tăng (VAT)
            decimal VAT = tienDienChuaThue * 0.08m;
            decimal tongTienDien = tienDienChuaThue + VAT;

            Console.WriteLine($"Số điện tiêu thụ: {kwh} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDienChuaThue:#,##0} VNĐ");
            Console.WriteLine($"Thuế VAT: {VAT:#,##0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongTienDien:#,##0} VNĐ");
        }




        public static void Main(string[] args)
        {
            //III. DANH SÁCH 15 BÀI TẬP LẬP TRÌNH TÌNH HUỐNG THỰC TẾ
            
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN):
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();
            bai_1();



        }
    }
}
