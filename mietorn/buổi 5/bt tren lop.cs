using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.BTCuuChuong
{
    internal class BTCT
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bangcuuchuong();


        }
        static void bangcuuchuong() //Bài tập bảng cửu chương 15:
        {
            for (int i=2; i<=15; i++) //i chạy từ 2 tới 15
            {
                for (int j=1; j<=10; j++) //i chạy lần lượt từ 1 tới 10
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
                Console.WriteLine();
            }
        }

        static void 
    }
}
