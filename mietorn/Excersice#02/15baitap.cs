using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace mietorn.Excersice_02
{
    internal class _15baitap
    {
        enum CurrencyType
        {
            USD=1,
            EUR=2,
            JPY=3,
            GBP=4,
        }
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

        static void bai_2()
        {
            //Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe
            Console.Write("Nhập chiều cao (m): ");
            double ChieuCao= double.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng (kg):");
            double CanNang= double.Parse(Console.ReadLine());
            //Tính chỉ số BMI:
            double bmi = CanNang / (ChieuCao * ChieuCao);
            //Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á:
            String phanLoai;
            if (bmi < 18.5)
            {
                phanLoai = "Gầy (Thiếu cân)";
            }
            else if (bmi < 23.0)
            {
                phanLoai = "Bình thường (Lý tưởng)";
            }
            else if (bmi < 25.0)
            {
                phanLoai = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                phanLoai = "Béo phì";
            }
            //Tính dải cân nặng lý tưởng cho chiều cao đó:
            double toithieu = 18.5 * (ChieuCao * ChieuCao);
            double toida = 22.9 * (ChieuCao * ChieuCao);
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2} ");
            Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {toithieu:F2} kg đến {toida:F2} kg.");
        }

        static void bai_3()
        {
            //Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng:
            Console.Write("Nhập số tiền VNĐ: ");
            decimal tienVND= decimal.Parse(Console.ReadLine());
            //Khai báo tỷ giá cố định:
            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4- GBP): ");
            int luachon= int.Parse(Console.ReadLine());
            CurrencyType selectedCurrency = (CurrencyType)luachon;
            //Phí dịch vụ quy đổi:
            decimal PDV = tienVND * 0.005m;
            //Tính số tiền VNĐ thực tế sau khi trừ phí dịch vụ:
            decimal thucte = tienVND - PDV;

            decimal tygia = 0m;
            string loaitiente = "";
            switch (selectedCurrency)
            {
                case CurrencyType.USD:
                    tygia = 25400m;
                    loaitiente = "USD";
                    break;
                case CurrencyType.EUR:
                    tygia = 27200m;
                    loaitiente = "EUR";
                    break;
                case CurrencyType.JPY:
                    tygia = 165m;
                    loaitiente = "JPY";
                    break;
                case CurrencyType.GBP:
                    tygia = 32100m;
                    loaitiente = "GBP";
                    break;
                default:
                    Console.WriteLine("Lựa chọn loại tiền tệ không hợp lệ!");
                    return;
            }
            //Tính số tiền ngoại tệ nhận được:
            decimal ngoaite = thucte / tygia;
            Console.WriteLine($"Phí dịch vụ (0.5%): {PDV:#,##0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {thucte:#,##0} VNĐ");
            Console.WriteLine($"Số tiền {loaitiente} nhận được: {ngoaite:F2} {loaitiente}");
        }

        static void bai_4()
        {
            //Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            DateTime ngaysinh;
            bool dung= DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh);
            if (!dung)
            {
                Console.WriteLine("Lỗi ngày sinh: Không hợp lệ!");
                return;
            }
            //Lấy ngày hiện tại của hệ thống:
            DateTime hientai = DateTime.Now.Date;
            //Tính tuổi chính xác tính theo số năm:
            int tuoi = hientai.Year - ngaysinh.Year;
            // Xác định ngày sinh nhật tiếp theo trong năm nay hoặc năm sau. Tính số ngày còn lại đến sinh nhật đó:
            //Sinh nhật năm nay:
            DateTime namnay = new DateTime(hientai.Year, ngaysinh.Month, ngaysinh.Day);
            if (hientai < namnay)
            {
                tuoi = tuoi - 1;
            }
            int songaydasong = (int)(hientai - ngaysinh).TotalDays;
            //Sinh nhật năm sau:
            DateTime namsau = namnay;
            if (namnay < hientai)
            {
                namsau = namnay.AddYears(1);
            }
            //số ngày còn lại để đến sinh nhật tiếp theo:
            int remaining = (int)(namsau - hientai).TotalDays;
            Console.WriteLine($"tuồi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {songaydasong:#,##0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {remaining} ngày nữa");
        }

        static void bai_5()
        {
            Console.Write("Nhập điểm môn C#: ");
            double diemCSharp= double.Parse( Console.ReadLine() );
            Console.Write("Số tín chỉ môn C#: ");
            int tcCSharp= int.Parse( Console.ReadLine() );
            Console.Write("Nhập điểm môn Toán rời rạc: ");
            double diemToan= double.Parse( Console.ReadLine() );
            Console.Write("Số tín chỉ môn Toán rời rạc: ");
            int tcToan= int.Parse( Console.ReadLine() );
            Console.Write("Nhập điểm môn Tiếng Anh: ");
            double diemTiengAnh= double.Parse( Console.ReadLine() );
            Console.Write("Số tín chỉ môn Tiếng Anh: ");
            int tcTiengAnh= int.Parse( Console.ReadLine() );
            // Tính điểm trung bình trọng số:
            int tongtc = tcCSharp + tcToan + tcTiengAnh;
            double diemTB = (diemCSharp * tcCSharp + diemToan * tcToan + diemTiengAnh * tcTiengAnh) / tongtc;
            // Quy đổi Score_Avg sang Điểm chữ (char/string) và Thang điểm 4 (double):
            char diemchu;
            double gpa4;
            string xeploai;
            if (diemTB >= 8.5)
            {
                diemchu = 'A';
                gpa4 = 4.0;
                xeploai = "Xuất sắc/ Giỏi";
            }
            else if (diemTB >= 7.0)
            {
                diemchu = 'B';
                gpa4 = 3.0;
                xeploai = "Khá";
            }
            else if (diemTB >= 5.5)
            {
                diemchu = 'C';
                gpa4 = 2.0;
                xeploai = "Trung bình";
            }
            else if (diemTB >= 4.0)
            {
                diemchu = 'D';
                gpa4 = 1.0;
                xeploai = "Yếu";
            }
            else
            {
                diemchu = 'F';
                gpa4 = 0.0;
                xeploai = "Kém (Trượt)";
            }
            Console.WriteLine($"Điểm trung bình thang 10: {diemTB:F2}");
            Console.WriteLine($"Điểm chữ quy đổi: {diemchu}");
            Console.WriteLine($"Điểm GPA thang 4: {gpa4:F1}");
            Console.WriteLine($"Xếp loại học lực: {xeploai}");
        }





        public static void Main15(string[] args)
        {
            //III. DANH SÁCH 15 BÀI TẬP LẬP TRÌNH TÌNH HUỐNG THỰC TẾ
            
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN):
            bai_1();

            bai_2();

            bai_3();

            bai_4();

            bai_5();

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
